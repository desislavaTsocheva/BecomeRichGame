using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milionerche
{
    public partial class Form1 : Form
    {
        string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\viole\\AppData\\Local\\Microsoft\\Microsoft SQL Server Local DB\\Instances\\MSSQLLocalDB\\QuestionsGame.mdf\";Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand command;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connection);
            conn.Open();
            MessageBox.Show("Open!");
            string query = "Select * from QuestionsGame";
            command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string correct = reader[6].ToString();
            lblQuestion.Text = reader[1].ToString();
            Answear1.Text = reader[2].ToString();
            Answear2.Text = reader[3].ToString();
            Answear3.Text = reader[4].ToString();
            Answear4.Text = reader[5].ToString();

            //if (Answear2.Checked==true&& Answear2.Text!= correct)
            //{
            //    Answear2.BackColor = Color.Red;
            //    MessageBox.Show("wrong");
            //}
            //else if(Answear2.Checked == true && Answear2.Text == correct)
            //{
            //    Answear2.BackColor = Color.Green;
            //}
            //if (Answear1.Checked == true && Answear1.Text != correct)
            //{
            //    Answear1.BackColor = Color.Red;
            //}
            //else if (Answear1.Checked == true && Answear1.Text == correct)
            //{
            //    Answear1.BackColor = Color.Green;
            //}
            //if (Answear3.Checked == true && Answear3.Text != correct)
            //{
            //    Answear3.BackColor = Color.Red;
            //}
            //else if (Answear3.Checked == true && Answear3.Text == correct)
            //{
            //    Answear3.BackColor = Color.Green;
            //}
            //if (Answear4.Checked == true && Answear4.Text != correct)
            //{
            //    Answear4.BackColor = Color.Red;
            //}
            //else if (Answear4.Checked == true && Answear4.Text == correct)
            //{
            //    Answear4.BackColor = Color.Green;
            //}

        }
    }
}
