
namespace BaiDoXeTLU
{
    partial class QuanLyThe
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtReader = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThemThe = new System.Windows.Forms.Button();
            this.btnXoaThe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thẻ đọc từ Reader";
            // 
            // txtReader
            // 
            this.txtReader.Location = new System.Drawing.Point(312, 46);
            this.txtReader.Name = "txtReader";
            this.txtReader.Size = new System.Drawing.Size(169, 20);
            this.txtReader.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(426, 227);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnThemThe
            // 
            this.btnThemThe.Location = new System.Drawing.Point(509, 104);
            this.btnThemThe.Name = "btnThemThe";
            this.btnThemThe.Size = new System.Drawing.Size(82, 45);
            this.btnThemThe.TabIndex = 3;
            this.btnThemThe.Text = "Thêm";
            this.btnThemThe.UseVisualStyleBackColor = true;
            this.btnThemThe.Click += new System.EventHandler(this.btnThemThe_Click);
            // 
            // btnXoaThe
            // 
            this.btnXoaThe.Location = new System.Drawing.Point(509, 197);
            this.btnXoaThe.Name = "btnXoaThe";
            this.btnXoaThe.Size = new System.Drawing.Size(82, 42);
            this.btnXoaThe.TabIndex = 4;
            this.btnXoaThe.Text = "Xóa";
            this.btnXoaThe.UseVisualStyleBackColor = true;
            this.btnXoaThe.Click += new System.EventHandler(this.btnXoaThe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(509, 282);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 39);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // QuanLyThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 371);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaThe);
            this.Controls.Add(this.btnThemThe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtReader);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyThe";
            this.Text = "QuanLyThe";
            this.Load += new System.EventHandler(this.QuanLyThe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReader;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThemThe;
        private System.Windows.Forms.Button btnXoaThe;
        private System.Windows.Forms.Button btnThoat;
    }
}