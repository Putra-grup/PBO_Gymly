namespace PBO_Gymly.Pembayaran
{
    partial class RiwayatPembayaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RiwayatPembayaran));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ButtonTambah = new Button();
            ButtonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(66, 140);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(773, 328);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(149, 21);
            label1.Name = "label1";
            label1.Size = new Size(597, 69);
            label1.TabIndex = 8;
            label1.Text = "Riwayat Pembayaran";
            // 
            // ButtonTambah
            // 
            ButtonTambah.BackColor = Color.FromArgb(127, 200, 248);
            ButtonTambah.FlatAppearance.BorderSize = 0;
            ButtonTambah.FlatStyle = FlatStyle.Flat;
            ButtonTambah.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonTambah.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonTambah.Location = new Point(808, 532);
            ButtonTambah.Margin = new Padding(3, 4, 3, 4);
            ButtonTambah.Name = "ButtonTambah";
            ButtonTambah.Size = new Size(80, 40);
            ButtonTambah.TabIndex = 7;
            ButtonTambah.Text = "Tambah";
            ButtonTambah.UseVisualStyleBackColor = true;
            ButtonTambah.Click += ButtonAddFasilitasGym_Click;
            // 
            // ButtonBack
            // 
            ButtonBack.BackColor = Color.FromArgb(127, 200, 248);
            ButtonBack.FlatAppearance.BorderSize = 0;
            ButtonBack.FlatStyle = FlatStyle.Flat;
            ButtonBack.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonBack.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonBack.Location = new Point(26, 532);
            ButtonBack.Margin = new Padding(3, 4, 3, 4);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(69, 40);
            ButtonBack.TabIndex = 6;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // RiwayatPembayaran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(ButtonTambah);
            Controls.Add(ButtonBack);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RiwayatPembayaran";
            Text = "RiwayatPembayaran";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button ButtonTambah;
        private Button ButtonBack;
    }
}