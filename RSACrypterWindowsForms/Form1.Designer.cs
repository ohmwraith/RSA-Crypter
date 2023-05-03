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
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.алгоритмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.дешифрованиеToolStripMenuItem,
            this.toolStripComboBox1,
            this.алгоритмToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ключиRSAToolStripMenuItem
            // 
            this.ключиRSAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяПараRSAToolStripMenuItem,
            this.сохранитьКлючиToolStripMenuItem});
            this.ключиRSAToolStripMenuItem.Name = "ключиRSAToolStripMenuItem";
            this.ключиRSAToolStripMenuItem.Size = new System.Drawing.Size(91, 27);
            this.ключиRSAToolStripMenuItem.Text = "Ключи RSA";
            // 
            // новаяПараRSAToolStripMenuItem
            // 
            this.новаяПараRSAToolStripMenuItem.Name = "новаяПараRSAToolStripMenuItem";
            this.новаяПараRSAToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.новаяПараRSAToolStripMenuItem.Text = "Новая пара RSA";
            this.новаяПараRSAToolStripMenuItem.Click += new System.EventHandler(this.новаяПараRSAToolStripMenuItem_Click);
            // 
            // сохранитьКлючиToolStripMenuItem
            // 
            this.сохранитьКлючиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьПаруToolStripMenuItem,
            this.сохранитьОткрытыйToolStripMenuItem});
            this.сохранитьКлючиToolStripMenuItem.Name = "сохранитьКлючиToolStripMenuItem";
            this.сохранитьКлючиToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.сохранитьКлючиToolStripMenuItem.Text = "Сохранить ключи";
            // 
            // сохранитьПаруToolStripMenuItem
            // 
            this.сохранитьПаруToolStripMenuItem.Name = "сохранитьПаруToolStripMenuItem";
            this.сохранитьПаруToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.сохранитьПаруToolStripMenuItem.Text = "Сохранить пару";
            this.сохранитьПаруToolStripMenuItem.Click += new System.EventHandler(this.сохранитьПаруToolStripMenuItem_Click);
            // 
            // сохранитьОткрытыйToolStripMenuItem
            // 
            this.сохранитьОткрытыйToolStripMenuItem.Name = "сохранитьОткрытыйToolStripMenuItem";
            this.сохранитьОткрытыйToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
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
            this.шифрованиеToolStripMenuItem.Size = new System.Drawing.Size(105, 27);
            this.шифрованиеToolStripMenuItem.Text = "Шифрование";
            // 
            // прочитатьОткрытыйКлючToolStripMenuItem
            // 
            this.прочитатьОткрытыйКлючToolStripMenuItem.Name = "прочитатьОткрытыйКлючToolStripMenuItem";
            this.прочитатьОткрытыйКлючToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.прочитатьОткрытыйКлючToolStripMenuItem.Text = "Прочитать открытый ключ";
            this.прочитатьОткрытыйКлючToolStripMenuItem.Click += new System.EventHandler(this.прочитатьОткрытыйКлючToolStripMenuItem_Click);
            // 
            // обновитьКлючDESToolStripMenuItem
            // 
            this.обновитьКлючDESToolStripMenuItem.Name = "обновитьКлючDESToolStripMenuItem";
            this.обновитьКлючDESToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.обновитьКлючDESToolStripMenuItem.Text = "Обновить ключ DES";
            // 
            // зашифроватьВФайлToolStripMenuItem
            // 
            this.зашифроватьВФайлToolStripMenuItem.Name = "зашифроватьВФайлToolStripMenuItem";
            this.зашифроватьВФайлToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.зашифроватьВФайлToolStripMenuItem.Text = "Зашифровать в файл";
            this.зашифроватьВФайлToolStripMenuItem.Click += new System.EventHandler(this.зашифроватьВФайлToolStripMenuItem_Click);
            // 
            // дешифрованиеToolStripMenuItem
            // 
            this.дешифрованиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отобразитьЗашифрованныйФайлToolStripMenuItem,
            this.расшифроватьФайлToolStripMenuItem});
            this.дешифрованиеToolStripMenuItem.Name = "дешифрованиеToolStripMenuItem";
            this.дешифрованиеToolStripMenuItem.Size = new System.Drawing.Size(120, 27);
            this.дешифрованиеToolStripMenuItem.Text = "Дешифрование";
            // 
            // отобразитьЗашифрованныйФайлToolStripMenuItem
            // 
            this.отобразитьЗашифрованныйФайлToolStripMenuItem.Name = "отобразитьЗашифрованныйФайлToolStripMenuItem";
            this.отобразитьЗашифрованныйФайлToolStripMenuItem.Size = new System.Drawing.Size(299, 24);
            this.отобразитьЗашифрованныйФайлToolStripMenuItem.Text = "Отобразить зашифрованный файл";
            this.отобразитьЗашифрованныйФайлToolStripMenuItem.Click += new System.EventHandler(this.отобразитьЗашифрованныйФайлToolStripMenuItem_Click);
            // 
            // расшифроватьФайлToolStripMenuItem
            // 
            this.расшифроватьФайлToolStripMenuItem.Name = "расшифроватьФайлToolStripMenuItem";
            this.расшифроватьФайлToolStripMenuItem.Size = new System.Drawing.Size(299, 24);
            this.расшифроватьФайлToolStripMenuItem.Text = "Расшифровать файл";
            this.расшифроватьФайлToolStripMenuItem.Click += new System.EventHandler(this.расшифроватьФайлToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "DES",
            "TripleDES",
            "RC2",
            "Rij",
            "AES"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 27);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // алгоритмToolStripMenuItem
            // 
            this.алгоритмToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.алгоритмToolStripMenuItem.Name = "алгоритмToolStripMenuItem";
            this.алгоритмToolStripMenuItem.Size = new System.Drawing.Size(82, 27);
            this.алгоритмToolStripMenuItem.Text = "Алгоритм";
            // 
            // encryptedTextBox
            // 
            this.encryptedTextBox.Location = new System.Drawing.Point(38, 148);
            this.encryptedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.encryptedTextBox.Name = "encryptedTextBox";
            this.encryptedTextBox.ReadOnly = true;
            this.encryptedTextBox.Size = new System.Drawing.Size(263, 131);
            this.encryptedTextBox.TabIndex = 1;
            this.encryptedTextBox.Text = "";
            // 
            // decryptedTextBox
            // 
            this.decryptedTextBox.Location = new System.Drawing.Point(305, 148);
            this.decryptedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.decryptedTextBox.Name = "decryptedTextBox";
            this.decryptedTextBox.Size = new System.Drawing.Size(263, 129);
            this.decryptedTextBox.TabIndex = 2;
            this.decryptedTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Metropolis", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 64);
            this.label1.TabIndex = 3;
            this.label1.Text = "RSA Crypter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Metropolis", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Crypted";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Metropolis", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Decrypted";
            // 
            // openEncryptedButton
            // 
            this.openEncryptedButton.BackgroundImage = global::RSACrypterWindowsForms.Properties.Resources.open;
            this.openEncryptedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openEncryptedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openEncryptedButton.Location = new System.Drawing.Point(237, 113);
            this.openEncryptedButton.Margin = new System.Windows.Forms.Padding(2);
            this.openEncryptedButton.Name = "openEncryptedButton";
            this.openEncryptedButton.Size = new System.Drawing.Size(30, 32);
            this.openEncryptedButton.TabIndex = 8;
            this.openEncryptedButton.UseVisualStyleBackColor = true;
            this.openEncryptedButton.Click += new System.EventHandler(this.openEncryptedButton_Click);
            // 
            // saveEncryptedButton
            // 
            this.saveEncryptedButton.BackgroundImage = global::RSACrypterWindowsForms.Properties.Resources.save;
            this.saveEncryptedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveEncryptedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveEncryptedButton.Location = new System.Drawing.Point(271, 113);
            this.saveEncryptedButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveEncryptedButton.Name = "saveEncryptedButton";
            this.saveEncryptedButton.Size = new System.Drawing.Size(30, 32);
            this.saveEncryptedButton.TabIndex = 5;
            this.saveEncryptedButton.UseVisualStyleBackColor = true;
            this.saveEncryptedButton.Click += new System.EventHandler(this.saveEncryptedButton_Click);
            // 
            // saveRawButton
            // 
            this.saveRawButton.BackgroundImage = global::RSACrypterWindowsForms.Properties.Resources.save;
            this.saveRawButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveRawButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveRawButton.Location = new System.Drawing.Point(536, 112);
            this.saveRawButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveRawButton.Name = "saveRawButton";
            this.saveRawButton.Size = new System.Drawing.Size(30, 32);
            this.saveRawButton.TabIndex = 4;
            this.saveRawButton.UseVisualStyleBackColor = true;
            this.saveRawButton.Click += new System.EventHandler(this.saveRawButton_Click);
            // 
            // openRawButton
            // 
            this.openRawButton.BackgroundImage = global::RSACrypterWindowsForms.Properties.Resources.open;
            this.openRawButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openRawButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openRawButton.Location = new System.Drawing.Point(501, 112);
            this.openRawButton.Margin = new System.Windows.Forms.Padding(2);
            this.openRawButton.Name = "openRawButton";
            this.openRawButton.Size = new System.Drawing.Size(30, 32);
            this.openRawButton.TabIndex = 9;
            this.openRawButton.UseVisualStyleBackColor = true;
            this.openRawButton.Click += new System.EventHandler(this.openRawButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decryptButton.Location = new System.Drawing.Point(38, 284);
            this.decryptButton.Margin = new System.Windows.Forms.Padding(2);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(263, 40);
            this.decryptButton.TabIndex = 10;
            this.decryptButton.Text = "Расшифровать";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryptButton.Location = new System.Drawing.Point(305, 284);
            this.encryptButton.Margin = new System.Windows.Forms.Padding(2);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(263, 40);
            this.encryptButton.TabIndex = 11;
            this.encryptButton.Text = "Зашифровать";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 350);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem алгоритмToolStripMenuItem;
    }
}

