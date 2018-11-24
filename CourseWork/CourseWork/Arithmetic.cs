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
    public partial class Arithmetic : Form
    {
        public Arithmetic()
        {
            InitializeComponent();
        }


        private void lZ77ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide(); 
            LZ77 form = new LZ77();
            form.Show();
        }

        private void HuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Huffman form = new Huffman();
            form.Show();
        }
    }
}
