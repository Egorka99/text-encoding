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
            LZ77 form = new LZ77();
            form.Show();
        }
    }  
}
