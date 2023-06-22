using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user
{
    public partial class Krish_qismi : Form
    {
        public Krish_qismi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            this.Hide();
            log.Show();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Form1 log = new Form1();
                this.Hide();
                log.Show();
            }
        }

        private void Krish_qismi_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}
