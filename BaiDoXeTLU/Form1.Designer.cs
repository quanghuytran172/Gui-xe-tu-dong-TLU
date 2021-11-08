
namespace BaiDoXeTLU
{
    public partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cmbThietBi = new System.Windows.Forms.ComboBox();
            this.btnOnCamera = new System.Windows.Forms.Button();
            this.btnOffCamera = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThẻToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Label();
            this.btnXeVao = new System.Windows.Forms.Button();
            this.btnXeRa = new System.Windows.Forms.Button();
            this.pXeRa = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pXeVao = new System.Windows.Forms.PictureBox();
            this.pView = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pXeRa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pXeVao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pView)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbThietBi
            // 
            this.cmbThietBi.FormattingEnabled = true;
            this.cmbThietBi.Location = new System.Drawing.Point(350, 62);
            this.cmbThietBi.Name = "cmbThietBi";
            this.cmbThietBi.Size = new System.Drawing.Size(175, 21);
            this.cmbThietBi.TabIndex = 0;
            // 
            // btnOnCamera
            // 
            this.btnOnCamera.Location = new System.Drawing.Point(542, 62);
            this.btnOnCamera.Name = "btnOnCamera";
            this.btnOnCamera.Size = new System.Drawing.Size(69, 21);
            this.btnOnCamera.TabIndex = 3;
            this.btnOnCamera.Text = "Start";
            this.btnOnCamera.UseVisualStyleBackColor = true;
            this.btnOnCamera.Click += new System.EventHandler(this.btnOnCamera_Click);
            // 
            // btnOffCamera
            // 
            this.btnOffCamera.Location = new System.Drawing.Point(632, 60);
            this.btnOffCamera.Name = "btnOffCamera";
            this.btnOffCamera.Size = new System.Drawing.Size(69, 23);
            this.btnOffCamera.TabIndex = 4;
            this.btnOffCamera.Text = "Stop";
            this.btnOffCamera.UseVisualStyleBackColor = true;
            this.btnOffCamera.Click += new System.EventHandler(this.btnOffCamera_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1364, 30);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýThẻToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mENUToolStripMenuItem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(78, 26);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // quảnLýThẻToolStripMenuItem
            // 
            this.quảnLýThẻToolStripMenuItem.Name = "quảnLýThẻToolStripMenuItem";
            this.quảnLýThẻToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.quảnLýThẻToolStripMenuItem.Text = "Quản lý thẻ";
            this.quảnLýThẻToolStripMenuItem.Click += new System.EventHandler(this.quảnLýThẻToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.aboutUsToolStripMenuItem.Text = "About us";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chọn Camera giám sát";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(768, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chọn cổng COM RFID-Readers";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(772, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(926, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Kết nối";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Camera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ảnh chụp lúc vào";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(503, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ảnh chụp lúc ra";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(741, 482);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(601, 318);
            this.dataGridView1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(937, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Danh sách xe đang trong bãi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(921, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Phí gửi xe:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Red;
            this.lbPrice.Location = new System.Drawing.Point(1031, 342);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(97, 25);
            this.lbPrice.TabIndex = 20;
            this.lbPrice.Text = "          VND";
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.ForeColor = System.Drawing.Color.Blue;
            this.timer.Location = new System.Drawing.Point(982, 207);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(141, 43);
            this.timer.TabIndex = 21;
            this.timer.Text = "10:07:23";
            // 
            // btnXeVao
            // 
            this.btnXeVao.Location = new System.Drawing.Point(950, 282);
            this.btnXeVao.Name = "btnXeVao";
            this.btnXeVao.Size = new System.Drawing.Size(75, 23);
            this.btnXeVao.TabIndex = 22;
            this.btnXeVao.Text = "Vào";
            this.btnXeVao.UseVisualStyleBackColor = true;
            this.btnXeVao.Click += new System.EventHandler(this.btnXeVao_Click);
            // 
            // btnXeRa
            // 
            this.btnXeRa.Location = new System.Drawing.Point(1072, 282);
            this.btnXeRa.Name = "btnXeRa";
            this.btnXeRa.Size = new System.Drawing.Size(75, 23);
            this.btnXeRa.TabIndex = 23;
            this.btnXeRa.Text = "Ra";
            this.btnXeRa.UseVisualStyleBackColor = true;
            this.btnXeRa.Click += new System.EventHandler(this.btnXeRa_Click);
            // 
            // pXeRa
            // 
            this.pXeRa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pXeRa.Location = new System.Drawing.Point(413, 505);
            this.pXeRa.Name = "pXeRa";
            this.pXeRa.Size = new System.Drawing.Size(288, 295);
            this.pXeRa.TabIndex = 15;
            this.pXeRa.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BaiDoXeTLU.Properties.Resources.unnamed;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 75);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pXeVao
            // 
            this.pXeVao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pXeVao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pXeVao.Location = new System.Drawing.Point(57, 505);
            this.pXeVao.Name = "pXeVao";
            this.pXeVao.Size = new System.Drawing.Size(276, 295);
            this.pXeVao.TabIndex = 6;
            this.pXeVao.TabStop = false;
            // 
            // pView
            // 
            this.pView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pView.Location = new System.Drawing.Point(57, 155);
            this.pView.Name = "pView";
            this.pView.Size = new System.Drawing.Size(644, 317);
            this.pView.TabIndex = 2;
            this.pView.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1012, 386);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 825);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnXeRa);
            this.Controls.Add(this.btnXeVao);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pXeRa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pXeVao);
            this.Controls.Add(this.btnOffCamera);
            this.Controls.Add(this.btnOnCamera);
            this.Controls.Add(this.pView);
            this.Controls.Add(this.cmbThietBi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bãi đỗ xe TLU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pXeRa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pXeVao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbThietBi;
        private System.Windows.Forms.PictureBox pView;
        private System.Windows.Forms.Button btnOnCamera;
        private System.Windows.Forms.Button btnOffCamera;
        private System.Windows.Forms.PictureBox pXeVao;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThẻToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pXeRa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Button btnXeVao;
        private System.Windows.Forms.Button btnXeRa;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClear;
    }
}

