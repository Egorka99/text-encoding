using System;
using System.Windows.Forms;
using ClassLibraryTextCoding;
using System.Collections;

namespace CourseWork
{
    public partial class Huffman : Form  
    {
        public Huffman()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void arithmeticToolStripMenu_Click(object sender, EventArgs e)
        {
            Hide();
            Arithmetic form = new Arithmetic();
            form.Show();
        }

        private void lZ77ToolStrip_Click(object sender, EventArgs e)
        {
            Hide();
            LZ78 form = new LZ78();
            form.Show();
        }

        private bool IsValidInputData(string input)
        {
            if (input.Length == 0 || input.Length > 16)
            {
                labelError.Text = "Ошибка. Длина текста должна быть от 1 до 16 символов";
                buttonDecodingHuff.Visible = false;
                return false;
            }
            SourceProp text = new SourceProp(input);

            if(text.Symbols.Length == 1)
            {
                labelError.Text = "Ошибка. Текст не должен состоять из одинаковых символов";
                buttonDecodingHuff.Visible = false;
                return false;
            } 

            return true;
                
        }  

        private void buttonCodingHuff_Click(object sender, EventArgs e)
        {
            labelError.Text = String.Empty; 

            buttonDecodingHuff.Visible = true;

            string input = textBoxCodingHuff_Text.Text;

            if (IsValidInputData(input))
            {
                HuffmanTree huffmanTree = new HuffmanTree();

                huffmanTree.Build(input);
                BitArray encoded = huffmanTree.Encode(input);

                textBoxCodingHuff_Code.Text = HuffmanTree.ToString(encoded);

                textBoxDecodingHuff_Code.Text = HuffmanTree.ToString(encoded);
            }
            
        }

        private void buttonDecodingHuff_Click(object sender, EventArgs e)
        {
            string input = textBoxCodingHuff_Text.Text;
               
                HuffmanTree huffmanTree = new HuffmanTree(); 

                // Build the Huffman tree
                huffmanTree.Build(input);

                // Encode  
                BitArray encoded = huffmanTree.Encode(input);

                // Decode
                string decoded = huffmanTree.Decode(encoded);

                textBoxDecodingHuff_Text.Text = decoded; 
                   
        }
    }  
}
