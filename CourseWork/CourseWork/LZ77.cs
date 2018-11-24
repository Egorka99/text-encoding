using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class LZ77 : Form
    { 
        public LZ77()
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
    } 
}  
 