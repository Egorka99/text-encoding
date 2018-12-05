using System;
using System.Windows.Forms;
using ClassLibraryTextCoding;
 
namespace CourseWork
{
    public partial class Arithmetic : Form 
    {
        public Arithmetic() 
        {
            InitializeComponent();
        }


        private void lZ77ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide(); 
            LZ78 form = new LZ78();
            form.Show();
        }

        private void HuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Huffman form = new Huffman();
            form.Show();
        }

        private bool IsValidInputData(string input)
        {
            if (input.Length == 0 || input.Length > 16)
            {
                labelError.Text = "Ошибка. Длина текста должна быть от 1 до 16 символов";
                buttonDecodingArithm.Visible = false;
                return false; 
            }  
              
            return true; 
        } 

        private void buttonEncodingArithm_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            buttonDecodingArithm.Visible = true;

            string input = textBoxCodingArithm_Text.Text;

            if (IsValidInputData(input))
            {
                ArithmeticCoding text = new ArithmeticCoding();

                double code = text.Encode(input);

                textBoxCodingArithm_Code.Text = code.ToString();

                textBoxDecodingArithm_Code.Text = code.ToString(); 
            }

           
        } 

        private void buttonDecodingArithm_Click(object sender, EventArgs e)
        {
            string input = textBoxCodingArithm_Text.Text;

            ArithmeticCoding text = new ArithmeticCoding();

            double code = text.Encode(input);

            string txt = text.Decode(input); 

            textBoxDecodingArithm_Text.Text = txt;
        }
    }  
} 
 