namespace QLSV_DATABASE
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttsv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.malopBox = new System.Windows.Forms.ComboBox();
            this.anhBox = new System.Windows.Forms.TextBox();
            this.vanBox = new System.Windows.Forms.TextBox();
            this.toanBox = new System.Windows.Forms.TextBox();
            this.hotenBox = new System.Windows.Forms.TextBox();
            this.mssvBox = new System.Windows.Forms.TextBox();
            this.anhLabel = new System.Windows.Forms.Label();
            this.vanLabel = new System.Windows.Forms.Label();
            this.toanLabel = new System.Windows.Forms.Label();
            this.malopLabel = new System.Windows.Forms.Label();
            this.hotenLabel = new System.Windows.Forms.Label();
            this.mssvLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ttsv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ttsv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Sinh Viên";
            // 
            // ttsv
            // 
            this.ttsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ttsv.Location = new System.Drawing.Point(6, 23);
            this.ttsv.Name = "ttsv";
            this.ttsv.RowHeadersWidth = 51;
            this.ttsv.RowTemplate.Height = 24;
            this.ttsv.Size = new System.Drawing.Size(1040, 259);
            this.ttsv.TabIndex = 0;
            this.ttsv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DSSV_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.malopBox);
            this.groupBox2.Controls.Add(this.anhBox);
            this.groupBox2.Controls.Add(this.vanBox);
            this.groupBox2.Controls.Add(this.toanBox);
            this.groupBox2.Controls.Add(this.hotenBox);
            this.groupBox2.Controls.Add(this.mssvBox);
            this.groupBox2.Controls.Add(this.anhLabel);
            this.groupBox2.Controls.Add(this.vanLabel);
            this.groupBox2.Controls.Add(this.toanLabel);
            this.groupBox2.Controls.Add(this.malopLabel);
            this.groupBox2.Controls.Add(this.hotenLabel);
            this.groupBox2.Controls.Add(this.mssvLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 279);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chi Tiết";
            // 
            // malopBox
            // 
            this.malopBox.FormattingEnabled = true;
            this.malopBox.Items.AddRange(new object[] {
            "KTPM2022.1",
            "KTPM2022.2",
            "KTPM2022.3"});
            this.malopBox.Location = new System.Drawing.Point(129, 205);
            this.malopBox.Name = "malopBox";
            this.malopBox.Size = new System.Drawing.Size(195, 33);
            this.malopBox.TabIndex = 11;
            this.malopBox.Text = "KTPM2022.1";
            // 
            // anhBox
            // 
            this.anhBox.Location = new System.Drawing.Point(491, 205);
            this.anhBox.Name = "anhBox";
            this.anhBox.Size = new System.Drawing.Size(195, 30);
            this.anhBox.TabIndex = 10;
            // 
            // vanBox
            // 
            this.vanBox.Location = new System.Drawing.Point(491, 126);
            this.vanBox.Name = "vanBox";
            this.vanBox.Size = new System.Drawing.Size(195, 30);
            this.vanBox.TabIndex = 9;
            // 
            // toanBox
            // 
            this.toanBox.Location = new System.Drawing.Point(491, 47);
            this.toanBox.Name = "toanBox";
            this.toanBox.Size = new System.Drawing.Size(195, 30);
            this.toanBox.TabIndex = 8;
            // 
            // hotenBox
            // 
            this.hotenBox.Location = new System.Drawing.Point(129, 129);
            this.hotenBox.Name = "hotenBox";
            this.hotenBox.Size = new System.Drawing.Size(195, 30);
            this.hotenBox.TabIndex = 7;
            // 
            // mssvBox
            // 
            this.mssvBox.Location = new System.Drawing.Point(129, 47);
            this.mssvBox.Name = "mssvBox";
            this.mssvBox.Size = new System.Drawing.Size(195, 30);
            this.mssvBox.TabIndex = 6;
            // 
            // anhLabel
            // 
            this.anhLabel.AutoSize = true;
            this.anhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anhLabel.Location = new System.Drawing.Point(427, 208);
            this.anhLabel.Name = "anhLabel";
            this.anhLabel.Size = new System.Drawing.Size(48, 25);
            this.anhLabel.TabIndex = 5;
            this.anhLabel.Text = "Anh";
            // 
            // vanLabel
            // 
            this.vanLabel.AutoSize = true;
            this.vanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanLabel.Location = new System.Drawing.Point(427, 126);
            this.vanLabel.Name = "vanLabel";
            this.vanLabel.Size = new System.Drawing.Size(48, 25);
            this.vanLabel.TabIndex = 4;
            this.vanLabel.Text = "Văn";
            // 
            // toanLabel
            // 
            this.toanLabel.AutoSize = true;
            this.toanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toanLabel.Location = new System.Drawing.Point(427, 47);
            this.toanLabel.Name = "toanLabel";
            this.toanLabel.Size = new System.Drawing.Size(58, 25);
            this.toanLabel.TabIndex = 3;
            this.toanLabel.Text = "Toán";
            // 
            // malopLabel
            // 
            this.malopLabel.AutoSize = true;
            this.malopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malopLabel.Location = new System.Drawing.Point(41, 211);
            this.malopLabel.Name = "malopLabel";
            this.malopLabel.Size = new System.Drawing.Size(78, 25);
            this.malopLabel.TabIndex = 2;
            this.malopLabel.Text = "Mã Lớp";
            // 
            // hotenLabel
            // 
            this.hotenLabel.AutoSize = true;
            this.hotenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotenLabel.Location = new System.Drawing.Point(41, 129);
            this.hotenLabel.Name = "hotenLabel";
            this.hotenLabel.Size = new System.Drawing.Size(77, 25);
            this.hotenLabel.TabIndex = 1;
            this.hotenLabel.Text = "Họ Tên";
            // 
            // mssvLabel
            // 
            this.mssvLabel.AutoSize = true;
            this.mssvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mssvLabel.Location = new System.Drawing.Point(41, 50);
            this.mssvLabel.Name = "mssvLabel";
            this.mssvLabel.Size = new System.Drawing.Size(71, 25);
            this.mssvLabel.TabIndex = 0;
            this.mssvLabel.Text = "MSSV";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(849, 327);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(123, 49);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Thêm";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.ThemButt_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(849, 402);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(123, 49);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Xóa";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.XoaButt_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(849, 471);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 49);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SuaButt_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(364, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.timButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(528, 635);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 34);
            this.textBox1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(849, 538);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 49);
            this.button2.TabIndex = 11;
            this.button2.Text = "Xem";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(93, 618);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 64);
            this.button4.TabIndex = 12;
            this.button4.Text = "Kết nối Database";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 694);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ttsv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox malopBox;
        private System.Windows.Forms.TextBox anhBox;
        private System.Windows.Forms.TextBox vanBox;
        private System.Windows.Forms.TextBox toanBox;
        private System.Windows.Forms.TextBox hotenBox;
        private System.Windows.Forms.TextBox mssvBox;
        private System.Windows.Forms.Label anhLabel;
        private System.Windows.Forms.Label vanLabel;
        private System.Windows.Forms.Label toanLabel;
        private System.Windows.Forms.Label malopLabel;
        private System.Windows.Forms.Label hotenLabel;
        private System.Windows.Forms.Label mssvLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView ttsv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}

