namespace PBO_Gymly.Status_Membership
{
    partial class TambahStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahStatus));
            comboBoxstatus = new ComboBox();
            LabelFasilitasBaik = new Label();
            LabelJumlahFasilitas = new Label();
            TextBoxtNama = new TextBox();
            LabelNamaFasilitas = new Label();
            ButtonSimpan = new Button();
            ButtonCancel = new Button();
            comboBoxJenis = new ComboBox();
            SuspendLayout();
            // 
            // comboBoxstatus
            // 
            comboBoxstatus.FormattingEnabled = true;
            comboBoxstatus.Location = new Point(14, 287);
            comboBoxstatus.Margin = new Padding(3, 4, 3, 4);
            comboBoxstatus.Name = "comboBoxstatus";
            comboBoxstatus.Size = new Size(138, 28);
            comboBoxstatus.TabIndex = 25;
            // 
            // LabelFasilitasBaik
            // 
            LabelFasilitasBaik.AutoSize = true;
            LabelFasilitasBaik.BackColor = Color.Transparent;
            LabelFasilitasBaik.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            LabelFasilitasBaik.ForeColor = Color.Black;
            LabelFasilitasBaik.Location = new Point(14, 245);
            LabelFasilitasBaik.Name = "LabelFasilitasBaik";
            LabelFasilitasBaik.Size = new Size(85, 35);
            LabelFasilitasBaik.TabIndex = 24;
            LabelFasilitasBaik.Text = "Status";
            // 
            // LabelJumlahFasilitas
            // 
            LabelJumlahFasilitas.AutoSize = true;
            LabelJumlahFasilitas.BackColor = Color.Transparent;
            LabelJumlahFasilitas.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            LabelJumlahFasilitas.ForeColor = Color.Black;
            LabelJumlahFasilitas.Location = new Point(14, 135);
            LabelJumlahFasilitas.Name = "LabelJumlahFasilitas";
            LabelJumlahFasilitas.Size = new Size(221, 35);
            LabelJumlahFasilitas.TabIndex = 22;
            LabelJumlahFasilitas.Text = "Jenis Membership";
            // 
            // TextBoxtNama
            // 
            TextBoxtNama.BackColor = Color.White;
            TextBoxtNama.BorderStyle = BorderStyle.None;
            TextBoxtNama.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            TextBoxtNama.ForeColor = Color.Black;
            TextBoxtNama.Location = new Point(14, 63);
            TextBoxtNama.Margin = new Padding(3, 4, 3, 4);
            TextBoxtNama.Name = "TextBoxtNama";
            TextBoxtNama.Size = new Size(286, 29);
            TextBoxtNama.TabIndex = 21;
            // 
            // LabelNamaFasilitas
            // 
            LabelNamaFasilitas.AutoSize = true;
            LabelNamaFasilitas.BackColor = Color.Transparent;
            LabelNamaFasilitas.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            LabelNamaFasilitas.ForeColor = Color.Black;
            LabelNamaFasilitas.Location = new Point(14, 21);
            LabelNamaFasilitas.Name = "LabelNamaFasilitas";
            LabelNamaFasilitas.Size = new Size(199, 35);
            LabelNamaFasilitas.TabIndex = 20;
            LabelNamaFasilitas.Text = "Nama Customer";
            // 
            // ButtonSimpan
            // 
            ButtonSimpan.BackColor = Color.FromArgb(45, 48, 71);
            ButtonSimpan.FlatAppearance.BorderSize = 0;
            ButtonSimpan.FlatStyle = FlatStyle.Flat;
            ButtonSimpan.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonSimpan.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonSimpan.Location = new Point(353, 528);
            ButtonSimpan.Margin = new Padding(3, 4, 3, 4);
            ButtonSimpan.Name = "ButtonSimpan";
            ButtonSimpan.Size = new Size(78, 48);
            ButtonSimpan.TabIndex = 19;
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
            ButtonCancel.Location = new Point(269, 528);
            ButtonCancel.Margin = new Padding(3, 4, 3, 4);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(78, 48);
            ButtonCancel.TabIndex = 18;
            ButtonCancel.Text = "Kembali";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // comboBoxJenis
            // 
            comboBoxJenis.FormattingEnabled = true;
            comboBoxJenis.Location = new Point(14, 176);
            comboBoxJenis.Margin = new Padding(3, 4, 3, 4);
            comboBoxJenis.Name = "comboBoxJenis";
            comboBoxJenis.Size = new Size(138, 28);
            comboBoxJenis.TabIndex = 26;
            // 
            // TambahStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(457, 600);
            Controls.Add(comboBoxJenis);
            Controls.Add(comboBoxstatus);
            Controls.Add(LabelFasilitasBaik);
            Controls.Add(LabelJumlahFasilitas);
            Controls.Add(TextBoxtNama);
            Controls.Add(LabelNamaFasilitas);
            Controls.Add(ButtonSimpan);
            Controls.Add(ButtonCancel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TambahStatus";
            Text = "TambahStatus";
            Load += TambahStatus_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxstatus;
        private Label LabelFasilitasBaik;
        private Label LabelJumlahFasilitas;
        private TextBox TextBoxtNama;
        private Label LabelNamaFasilitas;
        private Button ButtonSimpan;
        private Button ButtonCancel;
        private ComboBox comboBoxJenis;
    }
}