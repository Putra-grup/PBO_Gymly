﻿namespace PBO_Gymly.Pembayaran
{
    partial class UbahPembayaran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UbahPembayaran));
            ButtonSimpan = new Button();
            ButtonCancel = new Button();
            Label_Metod = new Label();
            Label_jumlah = new Label();
            textBox_jumlah = new TextBox();
            comboBoxmetod = new ComboBox();
            label1 = new Label();
            textBoxidprofil = new TextBox();
            label2 = new Label();
            textBoxidmembership = new TextBox();
            label3 = new Label();
            comboBoxstatus = new ComboBox();
            SuspendLayout();
            // 
            // ButtonSimpan
            // 
            ButtonSimpan.BackColor = Color.FromArgb(45, 48, 71);
            ButtonSimpan.FlatAppearance.BorderSize = 0;
            ButtonSimpan.FlatStyle = FlatStyle.Flat;
            ButtonSimpan.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonSimpan.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonSimpan.Location = new Point(354, 516);
            ButtonSimpan.Margin = new Padding(3, 4, 3, 4);
            ButtonSimpan.Name = "ButtonSimpan";
            ButtonSimpan.Size = new Size(74, 48);
            ButtonSimpan.TabIndex = 15;
            ButtonSimpan.Text = "Simpan";
            ButtonSimpan.UseVisualStyleBackColor = true;
            ButtonSimpan.Click += ButtonSimpan_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.BackColor = Color.FromArgb(45, 48, 71);
            ButtonCancel.FlatAppearance.BorderSize = 0;
            ButtonCancel.FlatStyle = FlatStyle.Flat;
            ButtonCancel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonCancel.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonCancel.Location = new Point(275, 516);
            ButtonCancel.Margin = new Padding(3, 4, 3, 4);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(72, 48);
            ButtonCancel.TabIndex = 14;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // Label_Metod
            // 
            Label_Metod.AutoSize = true;
            Label_Metod.BackColor = Color.Transparent;
            Label_Metod.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            Label_Metod.Location = new Point(24, 111);
            Label_Metod.Name = "Label_Metod";
            Label_Metod.Size = new Size(241, 32);
            Label_Metod.TabIndex = 13;
            Label_Metod.Text = "Metode Pembayaran";
            // 
            // Label_jumlah
            // 
            Label_jumlah.AutoSize = true;
            Label_jumlah.BackColor = Color.Transparent;
            Label_jumlah.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            Label_jumlah.Location = new Point(24, 13);
            Label_jumlah.Name = "Label_jumlah";
            Label_jumlah.Size = new Size(234, 32);
            Label_jumlah.TabIndex = 11;
            Label_jumlah.Text = "Jumlah Pembayaran";
            // 
            // textBox_jumlah
            // 
            textBox_jumlah.Location = new Point(24, 51);
            textBox_jumlah.Margin = new Padding(3, 4, 3, 4);
            textBox_jumlah.Name = "textBox_jumlah";
            textBox_jumlah.Size = new Size(138, 27);
            textBox_jumlah.TabIndex = 10;
            // 
            // comboBoxmetod
            // 
            comboBoxmetod.FormattingEnabled = true;
            comboBoxmetod.Location = new Point(24, 148);
            comboBoxmetod.Margin = new Padding(3, 4, 3, 4);
            comboBoxmetod.Name = "comboBoxmetod";
            comboBoxmetod.Size = new Size(138, 28);
            comboBoxmetod.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label1.Location = new Point(24, 207);
            label1.Name = "label1";
            label1.Size = new Size(99, 32);
            label1.TabIndex = 17;
            label1.Text = "Id Profil";
            // 
            // textBoxidprofil
            // 
            textBoxidprofil.Location = new Point(24, 244);
            textBoxidprofil.Margin = new Padding(3, 4, 3, 4);
            textBoxidprofil.Name = "textBoxidprofil";
            textBoxidprofil.Size = new Size(138, 27);
            textBoxidprofil.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label2.Location = new Point(24, 308);
            label2.Name = "label2";
            label2.Size = new Size(178, 32);
            label2.TabIndex = 19;
            label2.Text = "Id Membership";
            // 
            // textBoxidmembership
            // 
            textBoxidmembership.Location = new Point(24, 345);
            textBoxidmembership.Margin = new Padding(3, 4, 3, 4);
            textBoxidmembership.Name = "textBoxidmembership";
            textBoxidmembership.Size = new Size(138, 27);
            textBoxidmembership.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.Location = new Point(24, 391);
            label3.Name = "label3";
            label3.Size = new Size(81, 32);
            label3.TabIndex = 21;
            label3.Text = "Status";
            // 
            // comboBoxstatus
            // 
            comboBoxstatus.FormattingEnabled = true;
            comboBoxstatus.Location = new Point(24, 428);
            comboBoxstatus.Margin = new Padding(3, 4, 3, 4);
            comboBoxstatus.Name = "comboBoxstatus";
            comboBoxstatus.Size = new Size(138, 28);
            comboBoxstatus.TabIndex = 20;
            // 
            // UbahPembayaran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(457, 600);
            Controls.Add(label3);
            Controls.Add(comboBoxstatus);
            Controls.Add(label2);
            Controls.Add(textBoxidmembership);
            Controls.Add(label1);
            Controls.Add(textBoxidprofil);
            Controls.Add(ButtonSimpan);
            Controls.Add(ButtonCancel);
            Controls.Add(Label_Metod);
            Controls.Add(Label_jumlah);
            Controls.Add(textBox_jumlah);
            Controls.Add(comboBoxmetod);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UbahPembayaran";
            Text = "UbahPembayaran";
            Load += UbahPembayaran_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonSimpan;
        private Button ButtonCancel;
        private Label Label_Metod;
        private Label Label_jumlah;
        private TextBox textBox_jumlah;
        private ComboBox comboBoxmetod;
        private Label label1;
        private TextBox textBoxidprofil;
        private Label label2;
        private TextBox textBoxidmembership;
        private Label label3;
        private ComboBox comboBoxstatus;
    }
}