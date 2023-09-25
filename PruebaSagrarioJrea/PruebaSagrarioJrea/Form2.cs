using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaSagrarioJrea
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();  
            form4.Show();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Form5 form5 = new();
            form5.Show();
        }
    }
}
