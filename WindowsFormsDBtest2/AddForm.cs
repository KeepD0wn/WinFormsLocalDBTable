using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDBtest2
{
    public partial class AddForm : Form
    {       
        private SqlConnection connect = null;
        public AddForm()
        {
            InitializeComponent();
            connect = new SqlConnection("Server=desktop-rr78npp; Database=ShopDATA866; Trusted_Connection=true;");
            connect.Open();
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 m = this.Owner as Form1;
            if (m != null)
            {
                string sql = string.Format("Insert into Customer (CustName, CustCity, CustPhone) values (@name1,@city1,@phone1)");

                using (SqlCommand cmd = new SqlCommand(sql,this.connect))
                {
                    cmd.Parameters.AddWithValue("@name1", tbName.Text);
                    cmd.Parameters.AddWithValue("@city1", tbCity.Text);
                    cmd.Parameters.AddWithValue("@phone1", tbPhone.Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch(System.Data.SqlClient.SqlException)
                    {
                        DialogResult dr = MessageBox.Show("Введите данные корректно", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);                        
                    }                    
                }

                tbName.Text = string.Empty;
                tbCity.Text = string.Empty;
                tbPhone.Text = string.Empty;
            }
            Form1Up();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
                
        void Form1Up()
        {
            Form1 m = this.Owner as Form1;
            if (m != null)
                m.customerTableAdapter.Fill(m.shopDATA866DataSet.Customer);
        }       
    }
}
