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
    public partial class CategoryForm : Form
    {
        DBConnect dbConnect = DBConnect.getInstance();
        public CategoryForm()
        {
            InitializeComponent();
        }
        private void getTable()
        {
            string selectQuery = "SELECT * FROM category";
            SqlCommand command = new SqlCommand(selectQuery,dbConnect.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            guna2DataGridView_Cat.DataSource = dt;
        }
        private void CatAdd_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO category VALUES("+CatId_Textbox.Text+",'"+CatName_Textbox.Text+"','"+CatDescription_Textbox.Text+"')";
                SqlCommand command = new SqlCommand(insertQuery,dbConnect.Getcon());
                dbConnect.Opencon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully", "Add Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbConnect.Closecon();
                getTable();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
            CatId_Textbox.Clear();
            CatName_Textbox.Clear();
            CatDescription_Textbox.Clear();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void CatUpdate_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string updateQuery = "UPDATE category SET CatName='" + CatName_Textbox.Text + "',CatDes='" + CatDescription_Textbox.Text + "'WHERE CatId="+CatId_Textbox.Text+"";
                SqlCommand command = new SqlCommand(updateQuery, dbConnect.Getcon());
                dbConnect.Opencon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Update Successfully","Update Infomation",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dbConnect.Closecon();
                getTable();
                Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
           
        }

        private void guna2DataGridView_Cat_Click(object sender, EventArgs e)
        {
            CatId_Textbox.Text = guna2DataGridView_Cat.SelectedRows[0].Cells[0].Value.ToString();
            CatName_Textbox.Text = guna2DataGridView_Cat.SelectedRows[0].Cells[1].Value.ToString();
            CatDescription_Textbox.Text = guna2DataGridView_Cat.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void CatDelete_button_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery= "DELETE FROM category WHERE CatId=" + CatId_Textbox.Text + "";
                SqlCommand command = new SqlCommand(deleteQuery, dbConnect.Getcon());
                dbConnect.Opencon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Delete Successfully", "Delte Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbConnect.Closecon();
                getTable();
                Clear();
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Clear()
        {
            CatId_Textbox.Clear();
            CatName_Textbox.Clear();
            CatDescription_Textbox.Clear();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            //label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            //label_exit.ForeColor= Color.Orange;
        }

        private void label_logout_MouseEnter(object sender, EventArgs e)
        {
            label_logout.ForeColor= Color.Orange;
        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void label_logout_MouseLeave(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Black;
        }

        private void product_label_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void Seller_label_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();
        }

       

        private void product_label_MouseLeave(object sender, EventArgs e)
        {
            product_label.ForeColor = Color.Black;
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

        private void product_label_MouseEnter(object sender, EventArgs e)
        {
            product_label.ForeColor = Color.Orange;
        }
    }
}
