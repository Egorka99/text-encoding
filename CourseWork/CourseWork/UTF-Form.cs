using System;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class UTF_Form : Form
    {
        public UTF_Form()
        {
            InitializeComponent();
        }
   
        bool IsValidInput(string input)
        {
            if (input.Length == 0 || input.Length > 16)
            {
                labelTextError.Text = "Ошибка. Длина текста должна быть от 1 до 16 символов";
                buttonUTFDecoding.Visible = false;
                return false;
            }
             
            return true;     
        }

        private void buttonUTFCoding_Click(object sender, EventArgs e)
        {
            labelError.Text = string.Empty;
            buttonUTFDecoding.Visible = true; 

            string input = textBoxCodingUtf_Text.Text;
             
            if ( IsValidInput(input) )
            { 
                 
                string code = ""; 

                int CountBytes = Encoding.UTF8.GetByteCount(input);

                byte[] bytes = Encoding.UTF8.GetBytes(input);

                for (int i = 0; i < bytes.Length; i++)
                {
                     code += bytes[i].ToString() + " "; 
                } 
                 
                textBoxCodingUTF_Code.Text = code;
                textBoxCountBytes.Text = CountBytes.ToString();
            } 
        }
         
        private void buttonUTFDecoding_Click(object sender, EventArgs e)
        {

            string input = textBoxCodingUtf_Text.Text;

            if (IsValidInput(input))
            { 
                byte[] bytes = Encoding.UTF8.GetBytes(input);

                char[] symbols = Encoding.UTF8.GetChars(bytes);

                string output = "";
                 
                for (int i = 0; i < symbols.Length; i++)
                {
                    output += symbols[i]; 
                } 
                 
                textBoxDecodingUTF_Text.Text = output;
            }  
        } 

        private void HuffmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new Huffman().Show();
        }

        private void arithmeticToolStripMenu_Click(object sender, EventArgs e)
        {
            Hide(); 
            new Arithmetic().Show();
        }

        private void lZ78ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new LZ78().Show();
        }
    }
}
