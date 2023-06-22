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
    public partial class exitt : Form
    {
        public exitt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Krish_qismi log = new Krish_qismi();
            this.Hide();
            log.Show();
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                Krish_qismi log = new Krish_qismi();
                this.Hide();
                log.Show();
            }
        }

        private void exitt_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}
