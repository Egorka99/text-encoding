namespace CourseWork
{
    partial class LZ78
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
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLZDecoding = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelError = new System.Windows.Forms.Label();
            this.textBoxDecodingLZ_Text = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.buttonLZCoding = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodingLZ_Text = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HuffmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arithmeticToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(38, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "LZ-78";
            // 
            // buttonLZDecoding
            // 
            this.buttonLZDecoding.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLZDecoding.Location = new System.Drawing.Point(559, 107);
            this.buttonLZDecoding.Name = "buttonLZDecoding";
            this.buttonLZDecoding.Size = new System.Drawing.Size(141, 32);
            this.buttonLZDecoding.TabIndex = 7;
            this.buttonLZDecoding.Text = "Декодировать";
            this.buttonLZDecoding.UseVisualStyleBackColor = false;
            this.buttonLZDecoding.Click += new System.EventHandler(this.buttonLZDecoding_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelError);
            this.groupBox1.Controls.Add(this.textBoxDecodingLZ_Text);
            this.groupBox1.Controls.Add(this.buttonLZDecoding);
            this.groupBox1.Controls.Add(this.listBox);
            this.groupBox1.Controls.Add(this.buttonLZCoding);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCodingLZ_Text);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(42, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 282);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Кодирование";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(6, 251);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 10;
            // 
            // textBoxDecodingLZ_Text
            // 
            this.textBoxDecodingLZ_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDecodingLZ_Text.Location = new System.Drawing.Point(550, 165);
            this.textBoxDecodingLZ_Text.Name = "textBoxDecodingLZ_Text";
            this.textBoxDecodingLZ_Text.Size = new System.Drawing.Size(164, 26);
            this.textBoxDecodingLZ_Text.TabIndex = 9;
            // 
            // listBox
            // 
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(260, 82);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(245, 162);
            this.listBox.TabIndex = 8;
            // 
            // buttonLZCoding
            // 
            this.buttonLZCoding.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLZCoding.Location = new System.Drawing.Point(62, 135);
            this.buttonLZCoding.Name = "buttonLZCoding";
            this.buttonLZCoding.Size = new System.Drawing.Size(128, 32);
            this.buttonLZCoding.TabIndex = 7;
            this.buttonLZCoding.Text = "Кодировать";
            this.buttonLZCoding.UseVisualStyleBackColor = false;
            this.buttonLZCoding.Click += new System.EventHandler(this.buttonLZCoding_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(360, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Код";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Текст";
            // 
            // textBoxCodingLZ_Text
            // 
            this.textBoxCodingLZ_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCodingLZ_Text.Location = new System.Drawing.Point(43, 82);
            this.textBoxCodingLZ_Text.Name = "textBoxCodingLZ_Text";
            this.textBoxCodingLZ_Text.Size = new System.Drawing.Size(164, 26);
            this.textBoxCodingLZ_Text.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HuffmanToolStripMenuItem,
            this.arithmeticToolStripMenu,
            this.uTF8ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HuffmanToolStripMenuItem
            // 
            this.HuffmanToolStripMenuItem.Name = "HuffmanToolStripMenuItem";
            this.HuffmanToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.HuffmanToolStripMenuItem.Text = "Метод Хаффмана";
            this.HuffmanToolStripMenuItem.Click += new System.EventHandler(this.HuffmanToolStripMenuItem_Click);
            // 
            // arithmeticToolStripMenu
            // 
            this.arithmeticToolStripMenu.Name = "arithmeticToolStripMenu";
            this.arithmeticToolStripMenu.Size = new System.Drawing.Size(190, 20);
            this.arithmeticToolStripMenu.Text = "Арифметическое кодирование";
            this.arithmeticToolStripMenu.Click += new System.EventHandler(this.arithmeticToolStripMenu_Click);
            // 
            // uTF8ToolStripMenuItem
            // 
            this.uTF8ToolStripMenuItem.Name = "uTF8ToolStripMenuItem";
            this.uTF8ToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.uTF8ToolStripMenuItem.Text = "UTF-8";
            this.uTF8ToolStripMenuItem.Click += new System.EventHandler(this.uTF8ToolStripMenuItem_Click);
            // 
            // LZ78
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "LZ78";
            this.Text = "Кодирование текста";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLZDecoding;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLZCoding;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodingLZ_Text;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HuffmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arithmeticToolStripMenu;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox textBoxDecodingLZ_Text;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.ToolStripMenuItem uTF8ToolStripMenuItem;
    }
}