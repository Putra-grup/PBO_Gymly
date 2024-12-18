namespace PBO_Gymly.Pembayaran
{
    partial class TambahPembayaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahPembayaran));
            comboBox_jenis = new ComboBox();
            comboBoxmetod = new ComboBox();
            textBox_jumlah = new TextBox();
            Label_jumlah = new Label();
            Label_jenis = new Label();
            Label_Metod = new Label();
            ButtonSimpan = new Button();
            ButtonCancel = new Button();
            SuspendLayout();
            // 
            // comboBox_jenis
            // 
            comboBox_jenis.FormattingEnabled = true;
            comboBox_jenis.Location = new Point(47, 207);
            comboBox_jenis.Margin = new Padding(3, 4, 3, 4);
            comboBox_jenis.Name = "comboBox_jenis";
            comboBox_jenis.Size = new Size(138, 28);
            comboBox_jenis.TabIndex = 0;
            // 
            // comboBoxmetod
            // 
            comboBoxmetod.FormattingEnabled = true;
            comboBoxmetod.Location = new Point(47, 308);
            comboBoxmetod.Margin = new Padding(3, 4, 3, 4);
            comboBoxmetod.Name = "comboBoxmetod";
            comboBoxmetod.Size = new Size(138, 28);
            comboBoxmetod.TabIndex = 1;
            comboBoxmetod.SelectedIndexChanged += comboBoxmetod_SelectedIndexChanged;
            // 
            // textBox_jumlah
            // 
            textBox_jumlah.Location = new Point(47, 100);
            textBox_jumlah.Margin = new Padding(3, 4, 3, 4);
            textBox_jumlah.Name = "textBox_jumlah";
            textBox_jumlah.Size = new Size(138, 27);
            textBox_jumlah.TabIndex = 2;
            // 
            // Label_jumlah
            // 
            Label_jumlah.AutoSize = true;
            Label_jumlah.BackColor = Color.Transparent;
            Label_jumlah.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            Label_jumlah.Location = new Point(47, 63);
            Label_jumlah.Name = "Label_jumlah";
            Label_jumlah.Size = new Size(234, 32);
            Label_jumlah.TabIndex = 3;
            Label_jumlah.Text = "Jumlah Pembayaran";
            // 
            // Label_jenis
            // 
            Label_jenis.AutoSize = true;
            Label_jenis.BackColor = Color.Transparent;
            Label_jenis.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            Label_jenis.Location = new Point(47, 169);
            Label_jenis.Name = "Label_jenis";
            Label_jenis.Size = new Size(210, 32);
            Label_jenis.TabIndex = 4;
            Label_jenis.Text = "Jenis Membership";
            // 
            // Label_Metod
            // 
            Label_Metod.AutoSize = true;
            Label_Metod.BackColor = Color.Transparent;
            Label_Metod.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            Label_Metod.Location = new Point(47, 271);
            Label_Metod.Name = "Label_Metod";
            Label_Metod.Size = new Size(241, 32);
            Label_Metod.TabIndex = 5;
            Label_Metod.Text = "Metode Pembayaran";
            // 
            // ButtonSimpan
            // 
            ButtonSimpan.BackColor = Color.FromArgb(45, 48, 71);
            ButtonSimpan.FlatAppearance.BorderSize = 0;
            ButtonSimpan.FlatStyle = FlatStyle.Flat;
            ButtonSimpan.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonSimpan.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonSimpan.Location = new Point(350, 508);
            ButtonSimpan.Margin = new Padding(3, 4, 3, 4);
            ButtonSimpan.Name = "ButtonSimpan";
            ButtonSimpan.Size = new Size(77, 48);
            ButtonSimpan.TabIndex = 7;
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
            ButtonCancel.Location = new Point(271, 508);
            ButtonCancel.Margin = new Padding(3, 4, 3, 4);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(72, 48);
            ButtonCancel.TabIndex = 6;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // TambahPembayaran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(457, 600);
            Controls.Add(ButtonSimpan);
            Controls.Add(ButtonCancel);
            Controls.Add(Label_Metod);
            Controls.Add(Label_jenis);
            Controls.Add(Label_jumlah);
            Controls.Add(textBox_jumlah);
            Controls.Add(comboBoxmetod);
            Controls.Add(comboBox_jenis);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TambahPembayaran";
            Text = "TambahPembayaran";
            Load += TambahPembayaran_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_jenis;
        private ComboBox comboBoxmetod;
        private TextBox textBox_jumlah;
        private Label Label_jumlah;
        private Label Label_jenis;
        private Label Label_Metod;
        private Button ButtonSimpan;
        private Button ButtonCancel;
    }
}