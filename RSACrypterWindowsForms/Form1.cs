using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace RSACrypterWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(512);
        DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
        byte[] raw_data, encrypted_data;

        private void новаяПараRSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RSA = new RSACryptoServiceProvider(512);
            MessageBox.Show("Ключи успешно обновлены", "Ключи RSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void сохранитьПаруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Сохранение пары ключей RSA";
            sfd.DefaultExt = ".pem";
            if (sfd.ShowDialog() != DialogResult.OK) return;
            File.WriteAllText(sfd.FileName, RSA.ToXmlString(true));
        }

        private void сохранитьОткрытыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Сохранение открытого ключа RSA";
            sfd.DefaultExt = ".pub";
            if (sfd.ShowDialog() != DialogResult.OK) return;
            File.WriteAllText(sfd.FileName, RSA.ToXmlString(false));
        }

        private void прочитатьОткрытыйКлючToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выбрать открытый ключ";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            RSA.FromXmlString(File.ReadAllText(ofd.FileName));
            MessageBox.Show("Ключ успешно загружен", "Ключи RSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void зашифроватьВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Сохранить в файл";
            sfd.DefaultExt = ".crypt";
            if (sfd.ShowDialog() != DialogResult.OK) return;
            File.WriteAllBytes(sfd.FileName, RSAEncryptionDecryption.encrypt(RSA, DES, Encoding.UTF8.GetBytes(decryptedTextBox.Text)));
            MessageBox.Show("Данные успешно зашифрованы и сохранены", "Шифрование RSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void расшифроватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openEncryptedButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выбор зашифрованного файла";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            encrypted_data = File.ReadAllBytes(ofd.FileName);
            encryptedTextBox.Text = Encoding.UTF8.GetString(encrypted_data);
        }

        private void saveEncryptedButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Сохранить зашифрованные данные в файл";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            encrypted_data = Encoding.UTF8.GetBytes(encryptedTextBox.Text);
            File.WriteAllBytes(ofd.FileName, encrypted_data);
        }

        private void openRawButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выбор файла";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            raw_data = File.ReadAllBytes(ofd.FileName);
            decryptedTextBox.Text = Encoding.UTF8.GetString(raw_data);
        }

        private void saveRawButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Сохранить текст в файл";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            encrypted_data = Encoding.UTF8.GetBytes(encryptedTextBox.Text);
            File.WriteAllBytes(ofd.FileName, raw_data);
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            raw_data = Encoding.UTF8.GetBytes(decryptedTextBox.Text);
            encrypted_data = RSAEncryptionDecryption.encrypt(RSA, DES, raw_data);
            encryptedTextBox.Text = Encoding.UTF8.GetString(encrypted_data);
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            raw_data = RSAEncryptionDecryption.decrypt(RSA, encrypted_data);
            decryptedTextBox.Text = Encoding.UTF8.GetString(raw_data);
        }

        private void расшифроватьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            raw_data = RSAEncryptionDecryption.decrypt(RSA, File.ReadAllBytes(ofd.FileName));
            decryptedTextBox.Text = Encoding.UTF8.GetString(raw_data);
        }

        private void отобразитьЗашифрованныйФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выбрать зашифрованный файл";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            raw_data = File.ReadAllBytes(ofd.FileName);
            encryptedTextBox.Text = Encoding.UTF8.GetString(raw_data);
        }
    }
    public class RSAEncryptionDecryption{
        public static byte[] encrypt(RSACryptoServiceProvider RSA, DESCryptoServiceProvider DES, byte[] data)
        {
            byte[] encrypted_data;

            using (MemoryStream ms = new MemoryStream())
            {
                byte[] encryptedDESKey = RSA.Encrypt(DES.Key, false);
                byte[] encryptedDESIV = RSA.Encrypt(DES.IV, false);

                ms.Write(encryptedDESKey, 0, encryptedDESKey.Length);
                ms.Write(encryptedDESIV, 0, encryptedDESIV.Length);

                ICryptoTransform transform = DES.CreateEncryptor();
                using (CryptoStream cs = new CryptoStream(ms, transform, CryptoStreamMode.Write))
                {
                    cs.Write(data, 0, data.Length);
                    cs.Flush();
                    cs.FlushFinalBlock();
                }
                encrypted_data = ms.ToArray();
            }
            return encrypted_data;
        }
        public static byte[] decrypt(RSACryptoServiceProvider RSA, byte[] data)
        {
            byte[] decrypted_data;

            using (MemoryStream ms = new MemoryStream()) {
                // Запись данных в память
                ms.Write(data, 0, data.Length);
                ms.Position = 0;
                // Вычисление числа байт в зашифрованном блок,
                // которое равно размеру ключа
                Int32 KeyBlockSize = System.Convert.ToInt32(RSA.KeySize / 8);
                // Получение зашифрованного симметричного ключа и
                // вектора инициализации
                DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                Byte[] EncrypKey = new Byte[KeyBlockSize];
                Byte[] EncrypIV = new Byte[KeyBlockSize];

                ms.Read(EncrypKey, 0, EncrypKey.Length);
                ms.Read(EncrypIV, 0, EncrypIV.Length);

                DES.KeySize = KeyBlockSize;
                DES.Key = RSA.Decrypt(EncrypKey, false);
                DES.IV = RSA.Decrypt(EncrypIV, false);

                // Чтение оставшейся части файла с помощью симметричного ключа
                ICryptoTransform transform = DES.CreateDecryptor();
                using (CryptoStream cs = new CryptoStream(ms, transform, CryptoStreamMode.Read))
                {
                    decrypted_data = new byte[ms.Length];
                    cs.Read(decrypted_data, 0, decrypted_data.Length);
                }
            }
            return decrypted_data;
        }

        }
}
