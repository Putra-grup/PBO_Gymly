namespace PBO_Gymly.Status_Membership
{
    partial class UbahStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UbahStatus));
            LabelFasilitasBaik = new Label();
            TextBoxtJenis = new TextBox();
            LabelJumlahFasilitas = new Label();
            TextBoxtNama = new TextBox();
            LabelNamaFasilitas = new Label();
            ButtonChange = new Button();
            ButtonCancel = new Button();
            comboBoxstatus = new ComboBox();
            SuspendLayout();
            // 
            // LabelFasilitasBaik
            // 
            LabelFasilitasBaik.AutoSize = true;
            LabelFasilitasBaik.BackColor = Color.Transparent;
            LabelFasilitasBaik.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            LabelFasilitasBaik.ForeColor = Color.Black;
            LabelFasilitasBaik.Location = new Point(32, 241);
            LabelFasilitasBaik.Name = "LabelFasilitasBaik";
            LabelFasilitasBaik.Size = new Size(85, 35);
            LabelFasilitasBaik.TabIndex = 16;
            LabelFasilitasBaik.Text = "Status";
            // 
            // TextBoxtJenis
            // 
            TextBoxtJenis.BackColor = Color.White;
            TextBoxtJenis.BorderStyle = BorderStyle.None;
            TextBoxtJenis.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            TextBoxtJenis.ForeColor = Color.Black;
            TextBoxtJenis.Location = new Point(32, 172);
            TextBoxtJenis.Margin = new Padding(3, 4, 3, 4);
            TextBoxtJenis.Name = "TextBoxtJenis";
            TextBoxtJenis.Size = new Size(286, 29);
            TextBoxtJenis.TabIndex = 15;
            // 
            // LabelJumlahFasilitas
            // 
            LabelJumlahFasilitas.AutoSize = true;
            LabelJumlahFasilitas.BackColor = Color.Transparent;
            LabelJumlahFasilitas.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            LabelJumlahFasilitas.ForeColor = Color.Black;
            LabelJumlahFasilitas.Location = new Point(32, 131);
            LabelJumlahFasilitas.Name = "LabelJumlahFasilitas";
            LabelJumlahFasilitas.Size = new Size(221, 35);
            LabelJumlahFasilitas.TabIndex = 14;
            LabelJumlahFasilitas.Text = "Jenis Membership";
            // 
            // TextBoxtNama
            // 
            TextBoxtNama.BackColor = Color.White;
            TextBoxtNama.BorderStyle = BorderStyle.None;
            TextBoxtNama.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            TextBoxtNama.ForeColor = Color.Black;
            TextBoxtNama.Location = new Point(32, 59);
            TextBoxtNama.Margin = new Padding(3, 4, 3, 4);
            TextBoxtNama.Name = "TextBoxtNama";
            TextBoxtNama.Size = new Size(286, 29);
            TextBoxtNama.TabIndex = 13;
            // 
            // LabelNamaFasilitas
            // 
            LabelNamaFasilitas.AutoSize = true;
            LabelNamaFasilitas.BackColor = Color.Transparent;
            LabelNamaFasilitas.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            LabelNamaFasilitas.ForeColor = Color.Black;
            LabelNamaFasilitas.Location = new Point(32, 17);
            LabelNamaFasilitas.Name = "LabelNamaFasilitas";
            LabelNamaFasilitas.Size = new Size(199, 35);
            LabelNamaFasilitas.TabIndex = 12;
            LabelNamaFasilitas.Text = "Nama Customer";
            // 
            // ButtonChange
            // 
            ButtonChange.BackColor = Color.FromArgb(45, 48, 71);
            ButtonChange.FlatAppearance.BorderSize = 0;
            ButtonChange.FlatStyle = FlatStyle.Flat;
            ButtonChange.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonChange.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonChange.Location = new Point(359, 524);
            ButtonChange.Margin = new Padding(3, 4, 3, 4);
            ButtonChange.Name = "ButtonChange";
            ButtonChange.Size = new Size(84, 48);
            ButtonChange.TabIndex = 11;
            ButtonChange.Text = "Change";
            ButtonChange.UseVisualStyleBackColor = true;
            ButtonChange.Click += ButtonChange_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.BackColor = Color.FromArgb(45, 48, 71);
            ButtonCancel.FlatAppearance.BorderSize = 0;
            ButtonCancel.FlatStyle = FlatStyle.Flat;
            ButtonCancel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonCancel.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonCancel.Location = new Point(281, 524);
            ButtonCancel.Margin = new Padding(3, 4, 3, 4);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(72, 48);
            ButtonCancel.TabIndex = 10;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // comboBoxstatus
            // 
            comboBoxstatus.FormattingEnabled = true;
            comboBoxstatus.Location = new Point(32, 283);
            comboBoxstatus.Margin = new Padding(3, 4, 3, 4);
            comboBoxstatus.Name = "comboBoxstatus";
            comboBoxstatus.Size = new Size(138, 28);
            comboBoxstatus.TabIndex = 17;
            // 
            // UbahStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(457, 600);
            Controls.Add(comboBoxstatus);
            Controls.Add(LabelFasilitasBaik);
            Controls.Add(TextBoxtJenis);
            Controls.Add(LabelJumlahFasilitas);
            Controls.Add(TextBoxtNama);
            Controls.Add(LabelNamaFasilitas);
            Controls.Add(ButtonChange);
            Controls.Add(ButtonCancel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UbahStatus";
            Text = "UbahStatus";
            Load += UbahStatus_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LabelFasilitasBaik;
        private TextBox TextBoxtJenis;
        private Label LabelJumlahFasilitas;
        private TextBox TextBoxtNama;
        private Label LabelNamaFasilitas;
        private Button ButtonChange;
        private Button ButtonCancel;
        private ComboBox comboBoxstatus;
    }
}