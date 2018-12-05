using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryTextCoding;

namespace CourseWork
{
    public partial class LZ78 : Form
    {  
        public LZ78()
        {
            InitializeComponent();
        }

        private void HuffmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Huffman form = new Huffman();
            form.Show();
        }
        private void arithmeticToolStripMenu_Click(object sender, EventArgs e)
        {
            Hide();
            Arithmetic form = new Arithmetic();
            form.Show();  
        }


        private bool IsValidInputData(string input)
        {
            if (input.Length == 0 || input.Length > 16)
            {
                labelError.Text = "Ошибка. Длина текста должна быть от 1 до 16 символов";
                buttonLZDecoding.Visible = false;
                return false;
            }

            return true; 
        }

        private void buttonLZCoding_Click(object sender, EventArgs e)
        {
            textBoxDecodingLZ_Text.Text = "";
            listBox.Items.Clear();
            buttonLZDecoding.Visible = true;
            labelError.Text = ""; 

            string input = textBoxCodingLZ_Text.Text;

            if( IsValidInputData(input) )
            {
                LZCoding lz = new LZCoding(input);

                List<LZCoding.Struct> list = lz.EncodeLZ78();
                 
                foreach (var item in list)
                {
                    listBox.Items.Add("(" + item.pos + ";" + item.next + ")"); ;
                }
            }
           
             
              
        } 

        private void buttonLZDecoding_Click(object sender, EventArgs e)
        {
            string input = textBoxCodingLZ_Text.Text;

            LZCoding lz = new LZCoding(input);

            List<LZCoding.Struct> list = lz.EncodeLZ78(); 

            string decode = lz.DecodeLZ78(list);

            textBoxDecodingLZ_Text.Text = decode;
        }
    }  
}  
  