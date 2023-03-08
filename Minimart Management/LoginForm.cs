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
using System.Data.SqlClient;

namespace Minimart_Management
{
    public partial class LoginForm : Form
    {
        DBConnect db = DBConnect.getInstance();
        public static string sellerName;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Pink;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_Clear_Click(object sender, EventArgs e)
        {
            TextBox_username.Clear();
            TextBox_password.Clear();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            if (TextBox_username.Text == "" && TextBox_password.Text == ""){
                MessageBox.Show("Please fill Username and Password", "Fillin Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                if (comboBox1.SelectedIndex > -1)
                {
                    if (comboBox1.SelectedItem.ToString() == "ADMIN")
                    {
                        if (TextBox_username.Text == "Admin" || TextBox_password.Text == "admin")
                        {
                            ProductForm product = new ProductForm();
                            product.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are Admin, Please Enter the correct Id and Password", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        string selectQuery = "SELECT * FROM seller WHERE SellerName ='" + TextBox_username.Text + "' AND SellerPass='" + TextBox_password.Text + "'";

                        SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, db.Getcon());
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            sellerName = TextBox_username.Text;
                            SellingForm sell = new SellingForm();
                            sell.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username or password", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Role", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
