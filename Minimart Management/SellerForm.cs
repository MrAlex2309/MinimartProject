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

namespace Minimart_Management
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }
        DBConnect dbConnect = DBConnect.getInstance();
        private void SellAdd_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Seller VALUES(" + SellId_Textbox.Text + ",'" + SellName_Textbox.Text + "','" + SellAge_Textbox.Text + "','"+SellPhone_Textbox.Text+"','"+SellPass_TextBox.Text+"')";
                SqlCommand command = new SqlCommand(insertQuery, dbConnect.Getcon());
                dbConnect.Opencon();
                command.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfully", "Add Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbConnect.Closecon();
                getTabel();
                Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
           
        }
        private void Clear()
        {
            SellId_Textbox.Clear();
            SellName_Textbox.Clear();
            SellAge_Textbox.Clear();
            SellPhone_Textbox.Clear();
            SellPass_TextBox.Clear();
        }
        private void getTabel()
        {
            string selectQuery = "SELECT * FROM Seller";
            SqlCommand command = new SqlCommand(selectQuery, dbConnect.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            guna2DataGridView_Seller.DataSource = dt;
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            getTabel();
        }

        private void SellUpdate_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if(SellId_Textbox.Text==""|| SellName_Textbox.Text == "" || SellAge_Textbox.Text == "" || SellPhone_Textbox.Text == "" || SellPass_TextBox.Text == "")
                {
                    MessageBox.Show("Information Missing", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Seller SET SellerName='" + SellName_Textbox.Text + "',SellerAge='" + SellAge_Textbox.Text + "', SellerPhone='"+ SellPhone_Textbox.Text+"',SellerPass='"+SellPass_TextBox.Text+"'WHERE SellerId=" + SellId_Textbox.Text + "";
                SqlCommand command = new SqlCommand(updateQuery, dbConnect.Getcon());
                dbConnect.Opencon();
                command.ExecuteNonQuery();
                MessageBox.Show("Seller Update Successfully", "Update Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbConnect.Closecon();
                getTabel();
                Clear();
                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void guna2DataGridView_Seller_Click(object sender, EventArgs e)
        {
            SellId_Textbox.Text = guna2DataGridView_Seller.SelectedRows[0].Cells[0].Value.ToString();
            SellName_Textbox.Text = guna2DataGridView_Seller.SelectedRows[0].Cells[1].Value.ToString();
            SellAge_Textbox.Text = guna2DataGridView_Seller.SelectedRows[0].Cells[2].Value.ToString();
            SellPhone_Textbox.Text = guna2DataGridView_Seller.SelectedRows[0].Cells[3].Value.ToString();
            SellPass_TextBox.Text = guna2DataGridView_Seller.SelectedRows[0].Cells[4].Value.ToString();
        }

       

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_exit_MouseEnter_1(object sender, EventArgs e)
        {
            //label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave_1(object sender, EventArgs e)
        {
            //label_exit.ForeColor = Color.Orange;
        }

        private void SellDelete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellId_Textbox.Text == "")
                {
                    MessageBox.Show("Miss Seller Id","Missing Information",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(MessageBox.Show("Are You sure to delete this Seller?","Delete Seller",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string deleteQuery = "DELETE FROM Seller WHERE SellerId=" + SellId_Textbox.Text + "";
                        SqlCommand command = new SqlCommand(deleteQuery, dbConnect.Getcon());
                        dbConnect.Opencon();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Seller Delete Successfully", "Update Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dbConnect.Closecon();
                        getTabel();
                        Clear();
                    }                  
                }
               
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            Product_label.ForeColor = Color.Orange;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            Product_label.ForeColor = Color.Black;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
            this.Hide();
        }

        private void labe_logout_MouseEnter(object sender, EventArgs e)
        {
            labe_logout.ForeColor = Color.Orange;
        }

        private void labe_logout_MouseLeave(object sender, EventArgs e)
        {
            labe_logout.ForeColor = Color.Black;
        }

        private void labe_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void category_label_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void category_label_MouseEnter(object sender, EventArgs e)
        {
            category_label.ForeColor = Color.Orange;
        }

        private void category_label_MouseLeave(object sender, EventArgs e)
        {
            category_label.ForeColor = Color.Black;
        }

        private void Seller_label_MouseEnter(object sender, EventArgs e)
        {
            Seller_label.ForeColor = Color.Orange;
        }

        private void Seller_label_MouseLeave(object sender, EventArgs e)
        {
            Seller_label.ForeColor = Color.Black;
        }
    }
}
