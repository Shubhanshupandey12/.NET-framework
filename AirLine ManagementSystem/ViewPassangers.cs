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

namespace AirLine_ManagementSystem
{
    public partial class ViewPassangers : Form
    {
        public ViewPassangers()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pande\OneDrive\Documents\AirlLineDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select *from PassengerTbl";
            SqlDataAdapter sda=new SqlDataAdapter(query,Con);
            SqlCommandBuilder builder=new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PassengerDGV.DataSource= ds.Tables[0];
            Con.Close();
        }
        private void ViewPassangers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPassenger addPassenger = new AddPassenger();
            addPassenger.Show();
            this.Hide();
        }
    }
}
