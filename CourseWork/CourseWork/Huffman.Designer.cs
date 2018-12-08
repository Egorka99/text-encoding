namespace CourseWork
{
    partial class Huffman
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonCodingHuff = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodingHuff_Code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodingHuff_Text = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDecodingHuff = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDecodingHuff_Text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDecodingHuff_Code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arithmeticToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lZ77ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.uTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelError);
            this.groupBox1.Controls.Add(this.buttonCodingHuff);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxCodingHuff_Code);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCodingHuff_Text);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(49, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 286);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Кодирование";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(42, 120);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 8;
            // 
            // buttonCodingHuff
            // 
            this.buttonCodingHuff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCodingHuff.Location = new System.Drawing.Point(44, 241);
            this.buttonCodingHuff.Name = "buttonCodingHuff";
            this.buttonCodingHuff.Size = new System.Drawing.Size(128, 32);
            this.buttonCodingHuff.TabIndex = 7;
            this.buttonCodingHuff.Text = "Кодировать";
            this.buttonCodingHuff.UseVisualStyleBackColor = false;
            this.buttonCodingHuff.Click += new System.EventHandler(this.buttonCodingHuff_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(41, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Код";
            // 
            // textBoxCodingHuff_Code
            // 
            this.textBoxCodingHuff_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCodingHuff_Code.Location = new System.Drawing.Point(44, 195);
            this.textBoxCodingHuff_Code.Name = "textBoxCodingHuff_Code";
            this.textBoxCodingHuff_Code.ReadOnly = true;
            this.textBoxCodingHuff_Code.Size = new System.Drawing.Size(259, 26);
            this.textBoxCodingHuff_Code.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Текст";
            // 
            // textBoxCodingHuff_Text
            // 
            this.textBoxCodingHuff_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCodingHuff_Text.Location = new System.Drawing.Point(44, 82);
            this.textBoxCodingHuff_Text.Name = "textBoxCodingHuff_Text";
            this.textBoxCodingHuff_Text.Size = new System.Drawing.Size(164, 26);
            this.textBoxCodingHuff_Text.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDecodingHuff);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxDecodingHuff_Text);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxDecodingHuff_Code);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(451, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 273);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Декодирование";
            // 
            // buttonDecodingHuff
            // 
            this.buttonDecodingHuff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDecodingHuff.Location = new System.Drawing.Point(43, 222);
            this.buttonDecodingHuff.Name = "buttonDecodingHuff";
            this.buttonDecodingHuff.Size = new System.Drawing.Size(141, 32);
            this.buttonDecodingHuff.TabIndex = 7;
            this.buttonDecodingHuff.Text = "Декодировать";
            this.buttonDecodingHuff.UseVisualStyleBackColor = false;
            this.buttonDecodingHuff.Click += new System.EventHandler(this.buttonDecodingHuff_Click);
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
            // textBoxDecodingHuff_Text
            // 
            this.textBoxDecodingHuff_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDecodingHuff_Text.Location = new System.Drawing.Point(43, 170);
            this.textBoxDecodingHuff_Text.Name = "textBoxDecodingHuff_Text";
            this.textBoxDecodingHuff_Text.ReadOnly = true;
            this.textBoxDecodingHuff_Text.Size = new System.Drawing.Size(164, 26);
            this.textBoxDecodingHuff_Text.TabIndex = 5;
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
            // textBoxDecodingHuff_Code
            // 
            this.textBoxDecodingHuff_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDecodingHuff_Code.Location = new System.Drawing.Point(43, 82);
            this.textBoxDecodingHuff_Code.Name = "textBoxDecodingHuff_Code";
            this.textBoxDecodingHuff_Code.ReadOnly = true;
            this.textBoxDecodingHuff_Code.Size = new System.Drawing.Size(355, 26);
            this.textBoxDecodingHuff_Code.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(45, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Метод Хаффмана";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arithmeticToolStripMenu,
            this.lZ77ToolStrip,
            this.uTF8ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arithmeticToolStripMenu
            // 
            this.arithmeticToolStripMenu.Name = "arithmeticToolStripMenu";
            this.arithmeticToolStripMenu.Size = new System.Drawing.Size(190, 20);
            this.arithmeticToolStripMenu.Text = "Арифметическое кодирование";
            this.arithmeticToolStripMenu.Click += new System.EventHandler(this.arithmeticToolStripMenu_Click);
            // 
            // lZ77ToolStrip
            // 
            this.lZ77ToolStrip.Name = "lZ77ToolStrip";
            this.lZ77ToolStrip.Size = new System.Drawing.Size(49, 20);
            this.lZ77ToolStrip.Text = "LZ-78";
            this.lZ77ToolStrip.Click += new System.EventHandler(this.lZ77ToolStrip_Click);
            // 
            // uTF8ToolStripMenuItem
            // 
            this.uTF8ToolStripMenuItem.Name = "uTF8ToolStripMenuItem";
            this.uTF8ToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.uTF8ToolStripMenuItem.Text = "UTF-8";
            this.uTF8ToolStripMenuItem.Click += new System.EventHandler(this.uTF8ToolStripMenuItem_Click);
            // 
            // Huffman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 402);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Huffman";
            this.Text = "Кодирование текста";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCodingHuff_Text;
        private System.Windows.Forms.Button buttonCodingHuff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodingHuff_Code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDecodingHuff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDecodingHuff_Text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDecodingHuff_Code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arithmeticToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem lZ77ToolStrip;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.ToolStripMenuItem uTF8ToolStripMenuItem;
    }
}

