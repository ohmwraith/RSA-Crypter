namespace RSACrypterWindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ключиRSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяПараRSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКлючиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьПаруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьОткрытыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шифрованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прочитатьОткрытыйКлючToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьКлючDESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зашифроватьВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дешифрованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отобразитьЗашифрованныйФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расшифроватьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptedTextBox = new System.Windows.Forms.RichTextBox();
            this.decryptedTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openEncryptedButton = new System.Windows.Forms.Button();
            this.saveEncryptedButton = new System.Windows.Forms.Button();
            this.saveRawButton = new System.Windows.Forms.Button();
            this.openRawButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ключиRSAToolStripMenuItem,
            this.шифрованиеToolStripMenuItem,
            this.дешифрованиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ключиRSAToolStripMenuItem
            // 
            this.ключиRSAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяПараRSAToolStripMenuItem,
            this.сохранитьКлючиToolStripMenuItem});
            this.ключиRSAToolStripMenuItem.Name = "ключиRSAToolStripMenuItem";
            this.ключиRSAToolStripMenuItem.Size = new System.Drawing.Size(105, 25);
            this.ключиRSAToolStripMenuItem.Text = "Ключи RSA";
            // 
            // новаяПараRSAToolStripMenuItem
            // 
            this.новаяПараRSAToolStripMenuItem.Name = "новаяПараRSAToolStripMenuItem";
            this.новаяПараRSAToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.новаяПараRSAToolStripMenuItem.Text = "Новая пара RSA";
            this.новаяПараRSAToolStripMenuItem.Click += new System.EventHandler(this.новаяПараRSAToolStripMenuItem_Click);
            // 
            // сохранитьКлючиToolStripMenuItem
            // 
            this.сохранитьКлючиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьПаруToolStripMenuItem,
            this.сохранитьОткрытыйToolStripMenuItem});
            this.сохранитьКлючиToolStripMenuItem.Name = "сохранитьКлючиToolStripMenuItem";
            this.сохранитьКлючиToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.сохранитьКлючиToolStripMenuItem.Text = "Сохранить ключи";
            // 
            // сохранитьПаруToolStripMenuItem
            // 
            this.сохранитьПаруToolStripMenuItem.Name = "сохранитьПаруToolStripMenuItem";
            this.сохранитьПаруToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.сохранитьПаруToolStripMenuItem.Text = "Сохранить пару";
            this.сохранитьПаруToolStripMenuItem.Click += new System.EventHandler(this.сохранитьПаруToolStripMenuItem_Click);
            // 
            // сохранитьОткрытыйToolStripMenuItem
            // 
            this.сохранитьОткрытыйToolStripMenuItem.Name = "сохранитьОткрытыйToolStripMenuItem";
            this.сохранитьОткрытыйToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.сохранитьОткрытыйToolStripMenuItem.Text = "Сохранить открытый";
            this.сохранитьОткрытыйToolStripMenuItem.Click += new System.EventHandler(this.сохранитьОткрытыйToolStripMenuItem_Click);
            // 
            // шифрованиеToolStripMenuItem
            // 
            this.шифрованиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прочитатьОткрытыйКлючToolStripMenuItem,
            this.обновитьКлючDESToolStripMenuItem,
            this.зашифроватьВФайлToolStripMenuItem});
            this.шифрованиеToolStripMenuItem.Name = "шифрованиеToolStripMenuItem";
            this.шифрованиеToolStripMenuItem.Size = new System.Drawing.Size(119, 25);
            this.шифрованиеToolStripMenuItem.Text = "Шифрование";
            // 
            // прочитатьОткрытыйКлючToolStripMenuItem
            // 
            this.прочитатьОткрытыйКлючToolStripMenuItem.Name = "прочитатьОткрытыйКлючToolStripMenuItem";
            this.прочитатьОткрытыйКлючToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.прочитатьОткрытыйКлючToolStripMenuItem.Text = "Прочитать открытый ключ";
            this.прочитатьОткрытыйКлючToolStripMenuItem.Click += new System.EventHandler(this.прочитатьОткрытыйКлючToolStripMenuItem_Click);
            // 
            // обновитьКлючDESToolStripMenuItem
            // 
            this.обновитьКлючDESToolStripMenuItem.Name = "обновитьКлючDESToolStripMenuItem";
            this.обновитьКлючDESToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.обновитьКлючDESToolStripMenuItem.Text = "Обновить ключ DES";
            // 
            // зашифроватьВФайлToolStripMenuItem
            // 
            this.зашифроватьВФайлToolStripMenuItem.Name = "зашифроватьВФайлToolStripMenuItem";
            this.зашифроватьВФайлToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.зашифроватьВФайлToolStripMenuItem.Text = "Зашифровать в файл";
            this.зашифроватьВФайлToolStripMenuItem.Click += new System.EventHandler(this.зашифроватьВФайлToolStripMenuItem_Click);
            // 
            // дешифрованиеToolStripMenuItem
            // 
            this.дешифрованиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отобразитьЗашифрованныйФайлToolStripMenuItem,
            this.расшифроватьФайлToolStripMenuItem});
            this.дешифрованиеToolStripMenuItem.Name = "дешифрованиеToolStripMenuItem";
            this.дешифрованиеToolStripMenuItem.Size = new System.Drawing.Size(136, 25);
            this.дешифрованиеToolStripMenuItem.Text = "Дешифрование";
            // 
            // отобразитьЗашифрованныйФайлToolStripMenuItem
            // 
            this.отобразитьЗашифрованныйФайлToolStripMenuItem.Name = "отобразитьЗашифрованныйФайлToolStripMenuItem";
            this.отобразитьЗашифрованныйФайлToolStripMenuItem.Size = new System.Drawing.Size(343, 26);
            this.отобразитьЗашифрованныйФайлToolStripMenuItem.Text = "Отобразить зашифрованный файл";
            this.отобразитьЗашифрованныйФайлToolStripMenuItem.Click += new System.EventHandler(this.отобразитьЗашифрованныйФайлToolStripMenuItem_Click);
            // 
            // расшифроватьФайлToolStripMenuItem
            // 
            this.расшифроватьФайлToolStripMenuItem.Name = "расшифроватьФайлToolStripMenuItem";
            this.расшифроватьФайлToolStripMenuItem.Size = new System.Drawing.Size(343, 26);
            this.расшифроватьФайлToolStripMenuItem.Text = "Расшифровать файл";
            this.расшифроватьФайлToolStripMenuItem.Click += new System.EventHandler(this.расшифроватьФайлToolStripMenuItem_Click);
            // 
            // encryptedTextBox
            // 
            this.encryptedTextBox.Location = new System.Drawing.Point(51, 193);
            this.encryptedTextBox.Name = "encryptedTextBox";
            this.encryptedTextBox.ReadOnly = true;
            this.encryptedTextBox.Size = new System.Drawing.Size(283, 158);
            this.encryptedTextBox.TabIndex = 1;
            this.encryptedTextBox.Text = "";
            // 
            // decryptedTextBox
            // 
            this.decryptedTextBox.Location = new System.Drawing.Point(441, 193);
            this.decryptedTextBox.Name = "decryptedTextBox";
            this.decryptedTextBox.Size = new System.Drawing.Size(283, 158);
            this.decryptedTextBox.TabIndex = 2;
            this.decryptedTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Metropolis", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 80);
            this.label1.TabIndex = 3;
            this.label1.Text = "RSA Crypter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Metropolis", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Crypted";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Metropolis", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Decrypted";
            // 
            // openEncryptedButton
            // 
            this.openEncryptedButton.BackgroundImage = global::RSACrypterWindowsForms.Properties.Resources.open;
            this.openEncryptedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openEncryptedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openEncryptedButton.Location = new System.Drawing.Point(248, 147);
            this.openEncryptedButton.Name = "openEncryptedButton";
            this.openEncryptedButton.Size = new System.Drawing.Size(40, 40);
            this.openEncryptedButton.TabIndex = 8;
            this.openEncryptedButton.UseVisualStyleBackColor = true;
            this.openEncryptedButton.Click += new System.EventHandler(this.openEncryptedButton_Click);
            // 
            // saveEncryptedButton
            // 
            this.saveEncryptedButton.BackgroundImage = global::RSACrypterWindowsForms.Properties.Resources.save;
            this.saveEncryptedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveEncryptedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveEncryptedButton.Location = new System.Drawing.Point(294, 147);
            this.saveEncryptedButton.Name = "saveEncryptedButton";
            this.saveEncryptedButton.Size = new System.Drawing.Size(40, 40);
            this.saveEncryptedButton.TabIndex = 5;
            this.saveEncryptedButton.UseVisualStyleBackColor = true;
            this.saveEncryptedButton.Click += new System.EventHandler(this.saveEncryptedButton_Click);
            // 
            // saveRawButton
            // 
            this.saveRawButton.BackgroundImage = global::RSACrypterWindowsForms.Properties.Resources.save;
            this.saveRawButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveRawButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveRawButton.Location = new System.Drawing.Point(684, 147);
            this.saveRawButton.Name = "saveRawButton";
            this.saveRawButton.Size = new System.Drawing.Size(40, 40);
            this.saveRawButton.TabIndex = 4;
            this.saveRawButton.UseVisualStyleBackColor = true;
            this.saveRawButton.Click += new System.EventHandler(this.saveRawButton_Click);
            // 
            // openRawButton
            // 
            this.openRawButton.BackgroundImage = global::RSACrypterWindowsForms.Properties.Resources.open;
            this.openRawButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openRawButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openRawButton.Location = new System.Drawing.Point(638, 147);
            this.openRawButton.Name = "openRawButton";
            this.openRawButton.Size = new System.Drawing.Size(40, 40);
            this.openRawButton.TabIndex = 9;
            this.openRawButton.UseVisualStyleBackColor = true;
            this.openRawButton.Click += new System.EventHandler(this.openRawButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decryptButton.Location = new System.Drawing.Point(51, 358);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(283, 49);
            this.decryptButton.TabIndex = 10;
            this.decryptButton.Text = "Расшифровать";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryptButton.Location = new System.Drawing.Point(441, 358);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(283, 49);
            this.encryptButton.TabIndex = 11;
            this.encryptButton.Text = "Зашифровать";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.openRawButton);
            this.Controls.Add(this.openEncryptedButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveEncryptedButton);
            this.Controls.Add(this.saveRawButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decryptedTextBox);
            this.Controls.Add(this.encryptedTextBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "RSA Шифрование";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ключиRSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяПараRSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКлючиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шифрованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дешифрованиеToolStripMenuItem;
        private System.Windows.Forms.RichTextBox encryptedTextBox;
        private System.Windows.Forms.RichTextBox decryptedTextBox;
        private System.Windows.Forms.ToolStripMenuItem сохранитьПаруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьОткрытыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прочитатьОткрытыйКлючToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьКлючDESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зашифроватьВФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отобразитьЗашифрованныйФайлToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveRawButton;
        private System.Windows.Forms.Button saveEncryptedButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button openEncryptedButton;
        private System.Windows.Forms.Button openRawButton;
        private System.Windows.Forms.ToolStripMenuItem расшифроватьФайлToolStripMenuItem;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button encryptButton;
    }
}

