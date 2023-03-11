
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bnt_ketnoi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bnt_timten = new System.Windows.Forms.Button();
            this.txt_sothe = new System.Windows.Forms.TextBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cl_mathietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bnt_ketnoi
            // 
            this.bnt_ketnoi.Location = new System.Drawing.Point(101, 29);
            this.bnt_ketnoi.Name = "bnt_ketnoi";
            this.bnt_ketnoi.Size = new System.Drawing.Size(75, 23);
            this.bnt_ketnoi.TabIndex = 1;
            this.bnt_ketnoi.Text = "mở ";
            this.bnt_ketnoi.UseVisualStyleBackColor = true;
            this.bnt_ketnoi.Click += new System.EventHandler(this.bnt_ketnoi_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bnt_timten
            // 
            this.bnt_timten.Location = new System.Drawing.Point(383, 116);
            this.bnt_timten.Name = "bnt_timten";
            this.bnt_timten.Size = new System.Drawing.Size(75, 23);
            this.bnt_timten.TabIndex = 3;
            this.bnt_timten.Text = "tim ten";
            this.bnt_timten.UseVisualStyleBackColor = true;
            this.bnt_timten.Click += new System.EventHandler(this.bnt_timten_Click);
            // 
            // txt_sothe
            // 
            this.txt_sothe.Location = new System.Drawing.Point(334, 175);
            this.txt_sothe.Name = "txt_sothe";
            this.txt_sothe.Size = new System.Drawing.Size(100, 23);
            this.txt_sothe.TabIndex = 4;
            // 
            // STT
            // 
            this.STT.HeaderText = "Ma thiet bi";
            this.STT.Name = "STT";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Bo phan";
            this.Column1.Name = "Column1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(133, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(620, 154);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // cl_mathietbi
            // 
            this.cl_mathietbi.HeaderText = "Ma thiet bi";
            this.cl_mathietbi.Name = "cl_mathietbi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 777);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_sothe);
            this.Controls.Add(this.bnt_timten);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bnt_ketnoi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button bnt_ketnoi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bnt_timten;
        private System.Windows.Forms.TextBox txt_sothe;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_mathietbi;
    }
}

