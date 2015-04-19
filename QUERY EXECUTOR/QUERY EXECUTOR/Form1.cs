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
using System.IO;

namespace QUERY_EXECUTOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.ShowDialog();
            label1.Text = openFileDialog2.FileName;            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "";
            using (SqlConnection connect = new SqlConnection("Data Source=localhost;Initial Catalog=FullAsteroids;Integrated Security=True"))
            {
                using (FileStream fs = File.Open(label1.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (BufferedStream bs = new BufferedStream(fs))
                using (StreamReader sr = new StreamReader(bs))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Length > 20)
                        {
                            query = line;
                            SqlCommand CMD = new SqlCommand(query, connect);
                            CMD.CommandTimeout = 15000;
                            connect.Open();
                            CMD.ExecuteNonQuery();
                            connect.Close();
                        }
                        
                    }
                }

            }
        }
    }
}
