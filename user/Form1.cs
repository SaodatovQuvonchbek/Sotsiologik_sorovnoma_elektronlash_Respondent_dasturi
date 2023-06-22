using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Security.Policy;
using System.Data.Entity;
using user.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace user
{
    public partial class Form1 : Form
    {
       
        DataTable dt = new DataTable();
        int current = 0;
        

        public Form1()
        {
            InitializeComponent();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            button1.Enabled = true;

            textBox2.BackColor = Color.Blue;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;

            textBox2.ForeColor = Color.White;
            textBox3.ForeColor = Color.Blue;
            textBox4.ForeColor = Color.Blue;
            textBox5.ForeColor = Color.Blue;
            textBox6.ForeColor = Color.Blue;

            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.Blue;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;

            textBox2.ForeColor = Color.Blue;
            textBox3.ForeColor = Color.White;
            textBox4.ForeColor = Color.Blue;
            textBox5.ForeColor = Color.Blue;
            textBox6.ForeColor = Color.Blue;



            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.Blue;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;


            textBox2.ForeColor = Color.Blue;
            textBox3.ForeColor = Color.Blue;
            textBox4.ForeColor = Color.White;
            textBox5.ForeColor = Color.Blue;
            textBox6.ForeColor = Color.Blue;


            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.Blue;
            textBox6.BackColor = Color.White;


            textBox2.ForeColor = Color.Blue;
            textBox3.ForeColor = Color.Blue;
            textBox4.ForeColor = Color.Blue;
            textBox5.ForeColor = Color.White;
            textBox6.ForeColor = Color.Blue;


            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.Blue;


            textBox2.ForeColor = Color.Blue;
            textBox3.ForeColor = Color.Blue;
            textBox4.ForeColor = Color.Blue;
            textBox5.ForeColor = Color.Blue;
            textBox6.ForeColor = Color.White;


            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void clearTxt() {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox13.Text = "";

        }
        private void sdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            // OpenFileDialogni yaratish
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                // Filters qo'shish
                Filter = "Test savollari  (*.db)|*.db",
                Title = "Test savollari",
                FilterIndex = 1
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog1.FileNames)
                {
                    // Ma'lumotlar bazasini ochish kodlari
                    string connectionString = $"Data Source={file};Version=3;";
                    SQLiteConnection connection = new SQLiteConnection(connectionString);
                    connection.Open();
                    // Bazani ishlatish
                    string query = "select * from QuesTab";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(query, connection);



                    da.Fill(dt);
                    textBox13.Text = dt.Rows[current]["Savol"].ToString();
                    textBox1.Text = dt.Rows[current]["Savol"].ToString();
                    textBox2.Text = dt.Rows[current]["Ajavob"].ToString();
                    textBox3.Text = dt.Rows[current]["Bjavob"].ToString();
                    textBox4.Text = dt.Rows[current]["Cjavob"].ToString();
                    textBox5.Text = dt.Rows[current]["Djavob"].ToString();
                    textBox6.Text = dt.Rows[current]["Ejavob"].ToString();
                    TxtEmpty();
                    // Uyga qaytish va ulanishni yopish
                    connection.Close();
                }
            }
            enableTxt();




            //sinv

            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Test savollari  (*.db)|*.db";
            //openFileDialog.Multiselect = true;
            //openFileDialog.Title = "Select SQLite Databases to Open";

            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    databasePaths = openFileDialog.FileNames;

            //    foreach (string databasePath in databasePaths)
            //    {
            //        SQLiteConnection connection = new SQLiteConnection($"Data Source={databasePath}");
            //        connection.Open();

            //        string query = "select * from QuesTab";
            //        SQLiteDataAdapter da = new SQLiteDataAdapter(query, connection);



            //        da.Fill(dt);
            //        textBox13.Text = dt.Rows[current]["Savol"].ToString();
            //        textBox1.Text = dt.Rows[current]["Savol"].ToString();
            //        textBox2.Text = dt.Rows[current]["Ajavob"].ToString();
            //        textBox3.Text = dt.Rows[current]["Bjavob"].ToString();
            //        textBox4.Text = dt.Rows[current]["Cjavob"].ToString();
            //        textBox5.Text = dt.Rows[current]["Djavob"].ToString();
            //        textBox6.Text = dt.Rows[current]["Ejavob"].ToString();
            //        TxtEmpty();
            //        //        // Uyga qaytish va ulanishni yopish


            //        connection.Close();
            //    }

            //    // Close the second database if it was opened
            //    if (databasePaths.Length > 1)
            //    {
            //        SQLiteConnection secondConnection = new SQLiteConnection($"Data Source={databasePaths[1]}");
            //        secondConnection.Open();
            //        secondConnection.Close();
            //    }
            //}
            //enableTxt();

            //sinov

           


        }


        private void dataBaseOpen()
        {
            enableTxt();
            dataBase.selectBase();
        }


        private void DisplayyDAta(int current)
        {
            textBox13.Text = dt.Rows[current]["Savol"].ToString();
            textBox1.Text = dt.Rows[current]["Savol"].ToString();
            textBox2.Text = dt.Rows[current]["Ajavob"].ToString();
            textBox3.Text = dt.Rows[current]["Bjavob"].ToString();
            textBox4.Text = dt.Rows[current]["Cjavob"].ToString();
            textBox5.Text = dt.Rows[current]["Djavob"].ToString();
            textBox6.Text = dt.Rows[current]["Ejavob"].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)


        {
           if( textBox7.Text=="")
            {
                savesot.Visible = false;    
            }
            if (textBox77.Text == "")
            {
                savetest.Visible = false;
            }

            textBox11.KeyDown += new KeyEventHandler(textBox11_KeyDown);
            this.KeyPreview = true;



            if (textBox13.Text != "")
            {
                sdfToolStripMenuItem3.Enabled = false;
                sdfToolStripMenuItem3.Visible = false;
            }
            else if (textBox13.Text == "")
            {
                sdfToolStripMenuItem3.Enabled = true;
                sdfToolStripMenuItem3.Visible = true;
            }
            txtemty1();
            TxtEmpty();
            tableLayoutPanel3.Visible = false;
            panel2.Visible = true;
            //ishlamiyapti
            //    if (radioButton1.Checked == false || radioButton2.Checked == false ||
            //radioButton3.Checked == false || radioButton4.Checked == false || radioButton5.Checked == false)
            //    {
            //        button1.Enabled = true;
            //        //   TxtEmpty();
            //    }
        }

        private void sdfToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            //textboda malumot yozish
            if (radioButton1.Checked == true)
            {
                textBox77.Text += "A";
            }
            else if (radioButton2.Checked == true)
            {
                textBox77.Text += "B";
            }
            else if (radioButton3.Checked == true)
            {
                textBox77.Text += "C";
            }
            else if (radioButton4.Checked == true)
            {
                textBox77.Text += "D";
            }
            else if (radioButton5.Checked == true)
            {
                textBox77.Text += "E";
            }
            //textboda malumot yozish tugadi


            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;

            //keyingisiga  utishi 
            current += 1;
            enableTxt();
            if (current > dt.Rows.Count - 1)
            {
                current = dt.Rows.Count - 1;
                MessageBox.Show("Test savollari tugadi!", "Test natijalari", MessageBoxButtons.OK, MessageBoxIcon.Information);

                savetest.Visible = true;
                savetest.Enabled = true;
                ///dastur tugagandan keyin variant ni belgilab bo'lmaydigaan qilish
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;

                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;

                // enableTxt();
            }
            DisplayyDAta(current);

            TxtEmpty();
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;

            textBox2.ForeColor = Color.Blue;
            textBox3.ForeColor = Color.Blue;
            textBox4.ForeColor = Color.Blue;
            textBox5.ForeColor = Color.Blue;
            textBox6.ForeColor = Color.Blue;



            if (radioButton1.Checked == false || radioButton2.Checked == false ||
        radioButton3.Checked == false || radioButton4.Checked == false || radioButton5.Checked == false)
            {
                button1.Enabled = false;

            }
        }

        private void enableTxt()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox6.Enabled = true;
            textBox5.Enabled = true;
            textBox11.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;


            textBox2.Visible = true;
            textBox3.Visible = true;

            //  radioButton2.Visible = true;

            textBox4.Visible = true;
            //radioButton3.Visible = true;

            textBox5.Visible = true;
            //   radioButton4.Visible = true;

            textBox6.Visible = true;
            //   radioButton5.Visible = true;





        }
        private void txtemty1()
        {
            {
                if (textBox1.Text != "")
                {

                    sdfToolStripMenuItem3.Enabled = false;
                }
                
            }
        }
        private void TxtEmpty()
        {
            if (textBox2.Text == "")
            {

                textBox2.Enabled = false;
                radioButton1.Enabled = false;
                textBox2.Visible = false;
                radioButton1.Visible = false;

            }
            if (textBox3.Text == "")
            {
                radioButton2.Enabled = false;
                textBox3.Enabled = false;

                textBox3.Visible = false;
                radioButton2.Visible = false;

            }
            if (textBox4.Text == "")
            {
                textBox4.Enabled = false;

                radioButton3.Enabled = false;

                textBox4.Visible = false;
                radioButton3.Visible = false;
            }
            if (textBox5.Text == "")
            {
                textBox5.Enabled = false;
                radioButton4.Enabled = false;

                textBox5.Visible = false;
                radioButton4.Visible = false;
            }
            if (textBox6.Text == "")
            {
                textBox6.Enabled = false;

                radioButton5.Enabled = false;
                textBox6.Visible = false;
                radioButton5.Visible = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //current -= 1;
            //if (current < 0)
            //{
            //    current = 0;
            //}
            //DisplayyDAta(current);

            // if(saveFileDialog1.ShowDialog()==DialogResult.OK)

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;


            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;

        }


 

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void sdfToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox13.Text = "";
            //  Stream myStream;

        
                            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "Test natijalari files (.bmm)|.bmm";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter new_file = new StreamWriter(saveFileDialog1.FileName);

                    new_file.WriteLine(textBox77.Text);



                    new_file.Dispose();
                    new_file.Close();

                }
            exitt log1 = new exitt();
            this.Hide();
            log1.Show();

            textBox77.Text = "";
                clearTxt();
            
           savetest.Visible=false;

           
        }
     
     
      

        private void sdfToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {

        }

        private void sptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            button2.Visible = false;
            button1.Visible = true;
            tableLayoutPanel3.Visible = false;
            
        }

        private void sorovnomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            button1.Visible = false;
            button2.Visible = true;
            tableLayoutPanel3.Visible = true;  
        }

        private void textBox2_Click_2(object sender, EventArgs e)
        {
            if (textBox2.Text != "") { 
                textBox2.BackColor = Color.Blue;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;

            textBox2.ForeColor = Color.White;
            textBox3.ForeColor = Color.Blue;
            textBox4.ForeColor = Color.Blue;
            textBox5.ForeColor = Color.Blue;
            textBox6.ForeColor = Color.Blue;


            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;

            radioButton1.Checked = true;
        }
        }

        private void textBox3_Click_3(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.Blue;
                textBox4.BackColor = Color.White;
                textBox5.BackColor = Color.White;
                textBox6.BackColor = Color.White;

                textBox2.ForeColor = Color.Blue;
                textBox3.ForeColor = Color.White;
                textBox4.ForeColor = Color.Blue;
                textBox5.ForeColor = Color.Blue;
                textBox6.ForeColor = Color.Blue;


                textBox1.BackColor = Color.White;
                textBox1.ForeColor = Color.Black;

                radioButton2.Checked = true;
            }
        }

        private void textBox4_Click_2(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                textBox4.BackColor = Color.Blue;
                textBox5.BackColor = Color.White;
                textBox6.BackColor = Color.White;

                textBox2.ForeColor = Color.Blue;
                textBox3.ForeColor = Color.Blue;
                textBox4.ForeColor = Color.White;
                textBox5.ForeColor = Color.Blue;
                textBox6.ForeColor = Color.Blue;


                textBox1.BackColor = Color.White;
                textBox1.ForeColor = Color.Black;

                radioButton3.Checked = true;
            }
        }
        private void textBox5_Click_2(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                textBox4.BackColor = Color.White;
                textBox5.BackColor = Color.Blue;
                textBox6.BackColor = Color.White;

                textBox2.ForeColor = Color.Blue;
                textBox3.ForeColor = Color.Blue;
                textBox4.ForeColor = Color.Blue;
                textBox5.ForeColor = Color.White;
                textBox6.ForeColor = Color.Blue;


                textBox1.BackColor = Color.White;
                textBox1.ForeColor = Color.Black;

                radioButton4.Checked = true;
            }
        }

        private void textBox6_Click_2(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                textBox4.BackColor = Color.White;
                textBox5.BackColor = Color.White;
                textBox6.BackColor = Color.Blue;

                textBox2.ForeColor = Color.Blue;
                textBox3.ForeColor = Color.Blue;
                textBox4.ForeColor = Color.Blue;
                textBox5.ForeColor = Color.Blue;
                textBox6.ForeColor = Color.White;


                textBox1.BackColor = Color.White;
                textBox1.ForeColor = Color.Black;

                radioButton5.Checked = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        
                current += 1;
                enableTxt();
                if (current > dt.Rows.Count - 1)
                {
                    current = dt.Rows.Count - 1;
                MessageBox.Show("Test savollari tugadi!", "Test natijalari", MessageBoxButtons.OK, MessageBoxIcon.Information);

                savesot.Visible = true;
                textBox11.Enabled = false;
                ///dastur tugagandan keyin variant ni belgilab bo'lmaydigaan qilish
                textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;

                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;
                    radioButton3.Enabled = false;
                    radioButton4.Enabled = false;
                    radioButton5.Enabled = false;

                    // enableTxt();
                }
                DisplayyDAta(current);




            //textboxga natijalarni yozish kodi

            textBox7.Text+=textBox11.Text + Environment.NewLine;
          //  textBox7.AppendText((textBox11.Text));
            //textboxga natijalarni yozish kodi





            if (textBox11.Text=="")
            {
                button2.Enabled = false;
            }

            textBox11.Text = "";
        }

      
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text != "")
            {
                button2.Enabled = true;
            }
           else if (textBox11.Text == "")
            {
                button2.Enabled = false;
            }

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

            if (textBox13.Text != "")
            {
                openmenu.Enabled = false;
                openmenu.Visible = false;
                sdfToolStripMenuItem3.Enabled = false;
                sdfToolStripMenuItem3.Visible = false;
            }
            else if (textBox13.Text == "")
            {
                openmenu.Visible = false;
                openmenu.Enabled = true;
                sdfToolStripMenuItem3.Enabled = true;
                sdfToolStripMenuItem3.Visible = true;
            }

        }

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if(textBox7.Text=="")
            { savesot.Visible = false; }
        }

        private void savesot_Click(object sender, EventArgs e)
        {
            for (int i = textBox7.Lines.Length - 1; i >= 0; i--)
            {
                if (string.IsNullOrWhiteSpace(textBox7.Lines[i]))
                {
                    textBox7.Lines = textBox7.Lines.Take(i).Concat(textBox7.Lines.Skip(i + 1)).ToArray();
                }

            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Test natijalari files (.ks)|.ks";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter new_file = new StreamWriter(saveFileDialog1.FileName);

                new_file.WriteLine(textBox7.Text);



                new_file.Dispose();
                new_file.Close();

            }
            exitt log1 = new exitt();
            this.Hide();
            log1.Show();


            textBox7.Text = "";
            clearTxt();
            savesot.Visible = false;



           
        }
    }
}
