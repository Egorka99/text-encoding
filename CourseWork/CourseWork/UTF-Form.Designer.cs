namespace CourseWork
{
    partial class UTF_Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HuffmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arithmeticToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lZ78ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTextError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCountBytes = new System.Windows.Forms.TextBox();
            this.textBoxCodingUTF_Code = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.textBoxDecodingUTF_Text = new System.Windows.Forms.TextBox();
            this.buttonUTFDecoding = new System.Windows.Forms.Button();
            this.buttonUTFCoding = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodingUtf_Text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HuffmanToolStripMenuItem,
            this.arithmeticToolStripMenu,
            this.uTF8ToolStripMenuItem,
            this.lZ78ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
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
            this.uTF8ToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // lZ78ToolStripMenuItem
            // 
            this.lZ78ToolStripMenuItem.Name = "lZ78ToolStripMenuItem";
            this.lZ78ToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.lZ78ToolStripMenuItem.Text = "LZ-78";
            this.lZ78ToolStripMenuItem.Click += new System.EventHandler(this.lZ78ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTextError);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxCountBytes);
            this.groupBox1.Controls.Add(this.textBoxCodingUTF_Code);
            this.groupBox1.Controls.Add(this.labelError);
            this.groupBox1.Controls.Add(this.textBoxDecodingUTF_Text);
            this.groupBox1.Controls.Add(this.buttonUTFDecoding);
            this.groupBox1.Controls.Add(this.buttonUTFCoding);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCodingUtf_Text);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(26, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 282);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Кодирование";
            // 
            // labelTextError
            // 
            this.labelTextError.AutoSize = true;
            this.labelTextError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextError.ForeColor = System.Drawing.Color.Red;
            this.labelTextError.Location = new System.Drawing.Point(41, 118);
            this.labelTextError.Name = "labelTextError";
            this.labelTextError.Size = new System.Drawing.Size(0, 13);
            this.labelTextError.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(315, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Количество байт";
            // 
            // textBoxCountBytes
            // 
            this.textBoxCountBytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCountBytes.Location = new System.Drawing.Point(364, 174);
            this.textBoxCountBytes.Name = "textBoxCountBytes";
            this.textBoxCountBytes.ReadOnly = true;
            this.textBoxCountBytes.Size = new System.Drawing.Size(34, 26);
            this.textBoxCountBytes.TabIndex = 13;
            // 
            // textBoxCodingUTF_Code
            // 
            this.textBoxCodingUTF_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCodingUTF_Code.Location = new System.Drawing.Point(263, 82);
            this.textBoxCodingUTF_Code.Name = "textBoxCodingUTF_Code";
            this.textBoxCodingUTF_Code.ReadOnly = true;
            this.textBoxCodingUTF_Code.Size = new System.Drawing.Size(254, 26);
            this.textBoxCodingUTF_Code.TabIndex = 11;
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
            // textBoxDecodingUTF_Text
            // 
            this.textBoxDecodingUTF_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDecodingUTF_Text.Location = new System.Drawing.Point(550, 165);
            this.textBoxDecodingUTF_Text.Name = "textBoxDecodingUTF_Text";
            this.textBoxDecodingUTF_Text.ReadOnly = true;
            this.textBoxDecodingUTF_Text.Size = new System.Drawing.Size(164, 26);
            this.textBoxDecodingUTF_Text.TabIndex = 9;
            // 
            // buttonUTFDecoding
            // 
            this.buttonUTFDecoding.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUTFDecoding.Location = new System.Drawing.Point(559, 107);
            this.buttonUTFDecoding.Name = "buttonUTFDecoding";
            this.buttonUTFDecoding.Size = new System.Drawing.Size(141, 32);
            this.buttonUTFDecoding.TabIndex = 7;
            this.buttonUTFDecoding.Text = "Декодировать";
            this.buttonUTFDecoding.UseVisualStyleBackColor = false;
            this.buttonUTFDecoding.Click += new System.EventHandler(this.buttonUTFDecoding_Click);
            // 
            // buttonUTFCoding
            // 
            this.buttonUTFCoding.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUTFCoding.Location = new System.Drawing.Point(62, 159);
            this.buttonUTFCoding.Name = "buttonUTFCoding";
            this.buttonUTFCoding.Size = new System.Drawing.Size(128, 32);
            this.buttonUTFCoding.TabIndex = 7;
            this.buttonUTFCoding.Text = "Кодировать";
            this.buttonUTFCoding.UseVisualStyleBackColor = false;
            this.buttonUTFCoding.Click += new System.EventHandler(this.buttonUTFCoding_Click);
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
            // textBoxCodingUtf_Text
            // 
            this.textBoxCodingUtf_Text.CausesValidation = false;
            this.textBoxCodingUtf_Text.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxCodingUtf_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCodingUtf_Text.Location = new System.Drawing.Point(43, 82);
            this.textBoxCodingUtf_Text.Name = "textBoxCodingUtf_Text";
            this.textBoxCodingUtf_Text.Size = new System.Drawing.Size(164, 26);
            this.textBoxCodingUtf_Text.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(55, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "UTF-8";
            // 
            // UTF_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UTF_Form";
            this.Text = "Кодирование текста";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HuffmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arithmeticToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem uTF8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lZ78ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCodingUTF_Code;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox textBoxDecodingUTF_Text;
        private System.Windows.Forms.Button buttonUTFDecoding;
        private System.Windows.Forms.Button buttonUTFCoding;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodingUtf_Text;
        private System.Windows.Forms.TextBox textBoxCountBytes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTextError;
        private System.Windows.Forms.Label label5;
    }
}