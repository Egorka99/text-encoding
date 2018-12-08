namespace CourseWork
{
    partial class Arithmetic
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDecodingArithm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDecodingArithm_Text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDecodingArithm_Code = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonEncodingArithm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodingArithm_Code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodingArithm_Text = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HuffmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arithmeticToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lZ77ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.lZ77ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArithmToHuffmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(45, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Арифметическое кодирование";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDecodingArithm);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxDecodingArithm_Text);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxDecodingArithm_Code);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(430, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 273);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Декодирование";
            // 
            // buttonDecodingArithm
            // 
            this.buttonDecodingArithm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDecodingArithm.Location = new System.Drawing.Point(43, 222);
            this.buttonDecodingArithm.Name = "buttonDecodingArithm";
            this.buttonDecodingArithm.Size = new System.Drawing.Size(141, 32);
            this.buttonDecodingArithm.TabIndex = 7;
            this.buttonDecodingArithm.Text = "Декодировать";
            this.buttonDecodingArithm.UseVisualStyleBackColor = false;
            this.buttonDecodingArithm.Click += new System.EventHandler(this.buttonDecodingArithm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(40, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Текст";
            // 
            // textBoxDecodingArithm_Text
            // 
            this.textBoxDecodingArithm_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDecodingArithm_Text.Location = new System.Drawing.Point(43, 170);
            this.textBoxDecodingArithm_Text.Name = "textBoxDecodingArithm_Text";
            this.textBoxDecodingArithm_Text.ReadOnly = true;
            this.textBoxDecodingArithm_Text.Size = new System.Drawing.Size(164, 26);
            this.textBoxDecodingArithm_Text.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(40, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Код";
            // 
            // textBoxDecodingArithm_Code
            // 
            this.textBoxDecodingArithm_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDecodingArithm_Code.Location = new System.Drawing.Point(43, 82);
            this.textBoxDecodingArithm_Code.Name = "textBoxDecodingArithm_Code";
            this.textBoxDecodingArithm_Code.ReadOnly = true;
            this.textBoxDecodingArithm_Code.Size = new System.Drawing.Size(164, 26);
            this.textBoxDecodingArithm_Code.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelError);
            this.groupBox1.Controls.Add(this.buttonEncodingArithm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxCodingArithm_Code);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCodingArithm_Text);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(49, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 297);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Кодирование";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(44, 124);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 9;
            // 
            // buttonEncodingArithm
            // 
            this.buttonEncodingArithm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEncodingArithm.Location = new System.Drawing.Point(43, 259);
            this.buttonEncodingArithm.Name = "buttonEncodingArithm";
            this.buttonEncodingArithm.Size = new System.Drawing.Size(141, 32);
            this.buttonEncodingArithm.TabIndex = 8;
            this.buttonEncodingArithm.Text = "Кодировать";
            this.buttonEncodingArithm.UseVisualStyleBackColor = false;
            this.buttonEncodingArithm.Click += new System.EventHandler(this.buttonEncodingArithm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Код";
            // 
            // textBoxCodingArithm_Code
            // 
            this.textBoxCodingArithm_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCodingArithm_Code.Location = new System.Drawing.Point(43, 194);
            this.textBoxCodingArithm_Code.Name = "textBoxCodingArithm_Code";
            this.textBoxCodingArithm_Code.ReadOnly = true;
            this.textBoxCodingArithm_Code.Size = new System.Drawing.Size(164, 26);
            this.textBoxCodingArithm_Code.TabIndex = 5;
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
            // textBoxCodingArithm_Text
            // 
            this.textBoxCodingArithm_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCodingArithm_Text.Location = new System.Drawing.Point(43, 82);
            this.textBoxCodingArithm_Text.Name = "textBoxCodingArithm_Text";
            this.textBoxCodingArithm_Text.Size = new System.Drawing.Size(164, 26);
            this.textBoxCodingArithm_Text.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HuffmanToolStripMenuItem,
            this.arithmeticToolStripMenu,
            this.lZ77ToolStrip,
            this.lZ77ToolStripMenuItem,
            this.ArithmToHuffmanToolStripMenuItem,
            this.HuffToolStripMenuItem,
            this.uTF8ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HuffmanToolStripMenuItem
            // 
            this.HuffmanToolStripMenuItem.Name = "HuffmanToolStripMenuItem";
            this.HuffmanToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // arithmeticToolStripMenu
            // 
            this.arithmeticToolStripMenu.Name = "arithmeticToolStripMenu";
            this.arithmeticToolStripMenu.Size = new System.Drawing.Size(12, 20);
            // 
            // lZ77ToolStrip
            // 
            this.lZ77ToolStrip.Name = "lZ77ToolStrip";
            this.lZ77ToolStrip.Size = new System.Drawing.Size(12, 20);
            // 
            // lZ77ToolStripMenuItem
            // 
            this.lZ77ToolStripMenuItem.Name = "lZ77ToolStripMenuItem";
            this.lZ77ToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.lZ77ToolStripMenuItem.Text = "LZ-78";
            this.lZ77ToolStripMenuItem.Click += new System.EventHandler(this.lZ77ToolStripMenuItem_Click);
            // 
            // ArithmToHuffmanToolStripMenuItem
            // 
            this.ArithmToHuffmanToolStripMenuItem.Name = "ArithmToHuffmanToolStripMenuItem";
            this.ArithmToHuffmanToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // HuffToolStripMenuItem
            // 
            this.HuffToolStripMenuItem.Name = "HuffToolStripMenuItem";
            this.HuffToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.HuffToolStripMenuItem.Text = "Метод Хаффмана";
            this.HuffToolStripMenuItem.Click += new System.EventHandler(this.HuffToolStripMenuItem_Click);
            // 
            // uTF8ToolStripMenuItem
            // 
            this.uTF8ToolStripMenuItem.Name = "uTF8ToolStripMenuItem";
            this.uTF8ToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.uTF8ToolStripMenuItem.Text = "UTF-8";
            this.uTF8ToolStripMenuItem.Click += new System.EventHandler(this.uTF8ToolStripMenuItem_Click);
            // 
            // Arithmetic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Arithmetic";
            this.Text = "Кодирование текста";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDecodingArithm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDecodingArithm_Text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDecodingArithm_Code;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodingArithm_Code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodingArithm_Text;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HuffmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arithmeticToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem lZ77ToolStrip;
        private System.Windows.Forms.Button buttonEncodingArithm;
        private System.Windows.Forms.ToolStripMenuItem lZ77ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArithmToHuffmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HuffToolStripMenuItem;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.ToolStripMenuItem uTF8ToolStripMenuItem;
    }
}