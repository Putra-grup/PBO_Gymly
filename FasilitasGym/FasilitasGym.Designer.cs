using System.Windows.Forms;

namespace PBO_Gymly
{
    partial class FasilitasGym
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FasilitasGym));
            ButtonBack = new Button();
            ButtonAddFasilitasGym = new Button();
            ButtonChange = new Button();
            ButtonDelete = new Button();
            DataGridView_FasilitasGym = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView_FasilitasGym).BeginInit();
            SuspendLayout();
            // 
            // ButtonBack
            // 
            ButtonBack.BackColor = Color.FromArgb(127, 200, 248);
            ButtonBack.FlatAppearance.BorderSize = 0;
            ButtonBack.FlatStyle = FlatStyle.Flat;
            ButtonBack.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonBack.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonBack.Location = new Point(23, 516);
            ButtonBack.Margin = new Padding(3, 4, 3, 4);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(69, 40);
            ButtonBack.TabIndex = 0;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // ButtonAddFasilitasGym
            // 
            ButtonAddFasilitasGym.BackColor = Color.FromArgb(127, 200, 248);
            ButtonAddFasilitasGym.FlatAppearance.BorderSize = 0;
            ButtonAddFasilitasGym.FlatStyle = FlatStyle.Flat;
            ButtonAddFasilitasGym.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonAddFasilitasGym.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonAddFasilitasGym.Location = new Point(835, 516);
            ButtonAddFasilitasGym.Margin = new Padding(3, 4, 3, 4);
            ButtonAddFasilitasGym.Name = "ButtonAddFasilitasGym";
            ButtonAddFasilitasGym.Size = new Size(49, 40);
            ButtonAddFasilitasGym.TabIndex = 1;
            ButtonAddFasilitasGym.Text = "Add";
            ButtonAddFasilitasGym.UseVisualStyleBackColor = true;
            ButtonAddFasilitasGym.Click += ButtonAddFasilitasGym_Click;
            // 
            // ButtonChange
            // 
            ButtonChange.BackColor = Color.FromArgb(127, 200, 248);
            ButtonChange.FlatAppearance.BorderSize = 0;
            ButtonChange.FlatStyle = FlatStyle.Flat;
            ButtonChange.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonChange.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonChange.Location = new Point(749, 516);
            ButtonChange.Margin = new Padding(3, 4, 3, 4);
            ButtonChange.Name = "ButtonChange";
            ButtonChange.Size = new Size(80, 40);
            ButtonChange.TabIndex = 2;
            ButtonChange.Text = "Change";
            ButtonChange.UseVisualStyleBackColor = true;
            ButtonChange.Click += ButtonChange_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.BackColor = Color.FromArgb(127, 200, 248);
            ButtonDelete.FlatAppearance.BorderSize = 0;
            ButtonDelete.FlatStyle = FlatStyle.Flat;
            ButtonDelete.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonDelete.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonDelete.Location = new Point(674, 516);
            ButtonDelete.Margin = new Padding(3, 4, 3, 4);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(69, 40);
            ButtonDelete.TabIndex = 3;
            ButtonDelete.Text = "Hapus";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // DataGridView_FasilitasGym
            // 
            DataGridView_FasilitasGym.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView_FasilitasGym.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_FasilitasGym.Location = new Point(53, 123);
            DataGridView_FasilitasGym.Margin = new Padding(0);
            DataGridView_FasilitasGym.Name = "DataGridView_FasilitasGym";
            DataGridView_FasilitasGym.RowHeadersWidth = 51;
            DataGridView_FasilitasGym.Size = new Size(811, 373);
            DataGridView_FasilitasGym.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(279, 12);
            label1.Name = "label1";
            label1.Size = new Size(431, 69);
            label1.TabIndex = 5;
            label1.Text = "Daftar Fasilitas";
            // 
            // FasilitasGym
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(DataGridView_FasilitasGym);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonChange);
            Controls.Add(ButtonAddFasilitasGym);
            Controls.Add(ButtonBack);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FasilitasGym";
            Text = "FasilitasGym";
            Load += FasilitasGym_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView_FasilitasGym).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonBack;
        private Button ButtonAddFasilitasGym;
        private Button ButtonChange;
        private Button ButtonDelete;
        private DataGridView DataGridView_FasilitasGym;
        private Label label1;
    }
}