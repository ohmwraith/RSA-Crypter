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
            toolStripComboBox1.SelectedIndex = 0;
        }
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(512);
        SymmetricAlgorithm algorithm;
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
            try
            {
                RSA.FromXmlString(File.ReadAllText(ofd.FileName));
                MessageBox.Show("Ключ успешно загружен", "Ключи RSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Security.XmlSyntaxException)
            {
                MessageBox.Show("Файл не является ключом", "Ключи RSA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void зашифроватьВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Сохранить в файл";
            sfd.DefaultExt = ".crypt";
            if (sfd.ShowDialog() != DialogResult.OK) return;
            raw_data = Encoding.UTF8.GetBytes(decryptedTextBox.Text);
            encrypted_data = RSAEncryptionDecryption.encrypt(RSA, algorithm, raw_data);
            File.WriteAllBytes(sfd.FileName, encrypted_data);
            MessageBox.Show("Данные успешно зашифрованы и сохранены", "Шифрование RSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Сохранить зашифрованные данные в файл";
            if (sfd.ShowDialog() != DialogResult.OK) return;
            File.WriteAllBytes(sfd.FileName, encrypted_data);
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
            File.WriteAllBytes(ofd.FileName, raw_data);
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            raw_data = Encoding.UTF8.GetBytes(decryptedTextBox.Text);
            encrypted_data = RSAEncryptionDecryption.encrypt(RSA, algorithm, raw_data);
            encryptedTextBox.Text = Encoding.UTF8.GetString(encrypted_data);
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            raw_data = RSAEncryptionDecryption.decrypt(RSA, algorithm, encrypted_data);
            decryptedTextBox.Text = Encoding.UTF8.GetString(raw_data);
        }

        private void расшифроватьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выбор зашифрованного файла";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            try
            {
                raw_data = RSAEncryptionDecryption.decrypt(RSA, algorithm, File.ReadAllBytes(ofd.FileName));
                decryptedTextBox.Text = Encoding.UTF8.GetString(raw_data);
            }
            catch (System.Security.Cryptography.CryptographicException)
            {
                MessageBox.Show("Плохой формат файла или неверный закрытый ключ", "RSA шифрование", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.SelectedIndex)
            {
                case 0:
                    label1.Text = "RSA/DES";
                    algorithm = SymmetricAlgorithm.Create("DES");
                    break;
                case 1:
                    label1.Text = "RSA/TripleDES";
                    algorithm = SymmetricAlgorithm.Create("TripleDES");
                    break;
                case 2:
                    label1.Text = "RSA/RC2";
                    algorithm = SymmetricAlgorithm.Create("RC2");
                    break;
                case 3:
                    label1.Text = "RSA/Rij";
                    algorithm = SymmetricAlgorithm.Create("Rijndael");
                    break;
                case 4:
                    label1.Text = "RSA/AES";
                    algorithm = SymmetricAlgorithm.Create("AES");
                    break;
            }
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
        public static byte[] encrypt(RSACryptoServiceProvider RSA, SymmetricAlgorithm algorithm, byte[] data)
        {
            byte[] encrypted_data;

            using (MemoryStream ms = new MemoryStream())
            {
                byte[] encryptedDESKey = RSA.Encrypt(algorithm.Key, false);
                byte[] encryptedDESIV = RSA.Encrypt(algorithm.IV, false);

                ms.Write(encryptedDESKey, 0, encryptedDESKey.Length);
                ms.Write(encryptedDESIV, 0, encryptedDESIV.Length);

                ICryptoTransform transform = algorithm.CreateEncryptor();
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
        public static byte[] decrypt(RSACryptoServiceProvider RSA, SymmetricAlgorithm algorithm, byte[] data)
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
                Byte[] EncrypKey = new Byte[KeyBlockSize];
                Byte[] EncrypIV = new Byte[KeyBlockSize];

                ms.Read(EncrypKey, 0, EncrypKey.Length);
                ms.Read(EncrypIV, 0, EncrypIV.Length);

                algorithm.Key = RSA.Decrypt(EncrypKey, false);
                algorithm.IV = RSA.Decrypt(EncrypIV, false);

                // Чтение оставшейся части файла с помощью симметричного ключа
                ICryptoTransform transform = algorithm.CreateDecryptor();
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
