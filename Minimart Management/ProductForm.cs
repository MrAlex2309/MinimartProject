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
    public partial class ProductForm : Form
    {
        DBConnect dbConnect = DBConnect.getInstance();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }
        private void getCategory()
        {
            string selectQuery = "SELECT * FROM category";
            SqlCommand command = new SqlCommand(selectQuery, dbConnect.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ProdCategory_Combobox.DataSource = dt;
            ProdCategory_Combobox.ValueMember = "CatName";
            CategorySearch_Combobox.DataSource = dt;
            CategorySearch_Combobox.ValueMember = "CatName";
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();
        }
        private void getTable()
        {
            string selectQuery = "SELECT * FROM product";
            SqlCommand command = new SqlCommand(selectQuery, dbConnect.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            guna2DataGridView_Pro.DataSource = dt;
        }
        private void clear()
        {
            ProdId_Textbox.Clear();
            ProdName_Textbox.Clear();
            ProdPrcie_Textbox.Clear();
            ProdQty_Textbox.Clear();
            ProdCategory_Combobox.SelectedIndex = 0;
        }
        private void ProAdd_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO product VALUES (" + ProdId_Textbox.Text + ",'" + ProdName_Textbox.Text + "'," + ProdPrcie_Textbox.Text + "," + ProdQty_Textbox.Text + ",'" + ProdCategory_Combobox.Text + "') ";
                SqlCommand command = new SqlCommand(insertQuery, dbConnect.Getcon());
                dbConnect.Opencon();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully", "Add Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbConnect.Closecon();
                getTable();
                clear();
            } catch(Exception ex) { MessageBox.Show(ex.Message); }          
        }

        private void ProUpdate_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId_Textbox.Text == "" || ProdName_Textbox.Text == "" || ProdPrcie_Textbox.Text == "" || ProdQty_Textbox.Text == "")
                {
                    MessageBox.Show("Information Missing", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE product SET ProdName='" + ProdName_Textbox.Text + "',ProdPrice=" + ProdPrcie_Textbox.Text + ",ProdQty=" + ProdQty_Textbox.Text+ ",ProdCat='"+ ProdCategory_Combobox.Text + "'WHERE ProdId=" + ProdId_Textbox.Text;
                    SqlCommand command = new SqlCommand(updateQuery, dbConnect.Getcon());
                    dbConnect.Opencon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Update Successfully", "Add Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbConnect.Closecon();
                    getTable();
                    clear();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void guna2DataGridView_Pro_Click(object sender, EventArgs e)
        {
            ProdId_Textbox.Text = guna2DataGridView_Pro.SelectedRows[0].Cells[0].Value.ToString();
            ProdName_Textbox.Text = guna2DataGridView_Pro.SelectedRows[0].Cells[1].Value.ToString();
            ProdPrcie_Textbox.Text = guna2DataGridView_Pro.SelectedRows[0].Cells[2].Value.ToString();
            ProdQty_Textbox.Text = guna2DataGridView_Pro.SelectedRows[0].Cells[3].Value.ToString();
            ProdCategory_Combobox.Text = guna2DataGridView_Pro.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void ProDelete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId_Textbox.Text == "" || ProdName_Textbox.Text == "" || ProdPrcie_Textbox.Text == "" || ProdQty_Textbox.Text == "")
                {
                    MessageBox.Show("Information Missing", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string deleteQuery = "DELETE FROM product WHERE ProdId=" + ProdId_Textbox.Text + "";
                    SqlCommand command = new SqlCommand(deleteQuery, dbConnect.Getcon());
                    dbConnect.Opencon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Delete Successfully", "Delte Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbConnect.Closecon();
                    getTable();
                    clear();
                }
                
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void CategorySearch_Combobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM product WHERE ProdCat='"+ CategorySearch_Combobox.SelectedValue.ToString()+"'";
            SqlCommand command = new SqlCommand(selectQuery, dbConnect.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            guna2DataGridView_Pro.DataSource = dt;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void labe_logout_MouseEnter(object sender, EventArgs e)
        {
            labe_logout.ForeColor=Color.Gold;
        }

        private void labe_logout_MouseLeave(object sender, EventArgs e)
        {
            labe_logout.ForeColor = Color.Black;
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            //label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            //label_exit.ForeColor=Color.Orange;
        }

        private void Seller_label_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();
        }

        private void Product_label_Click(object sender, EventArgs e)
        {
            ProductForm pro = new ProductForm();
            pro.Show();
            this.Hide();
        }

        private void Selling_label_Click(object sender, EventArgs e)
        {

        }

        private void Product_label_MouseEnter(object sender, EventArgs e)
        {
            Product_label.ForeColor = Color.Orange;
        }

        private void Product_label_MouseLeave(object sender, EventArgs e)
        {
            Product_label.ForeColor = Color.Black;
        }

        private void Category_label_MouseEnter(object sender, EventArgs e)
        {
            Category_label.ForeColor = Color.Orange;
        }

        private void Category_label_MouseLeave(object sender, EventArgs e)
        {
            Category_label.ForeColor = Color.Black;
        }

        private void Seller_label_MouseEnter(object sender, EventArgs e)
        {
            Seller_label.ForeColor = Color.Orange;
        }

        private void Seller_label_MouseLeave(object sender, EventArgs e)
        {
            Seller_label.ForeColor = Color.Black;
        }

        private void ProAdd_Button_MouseEnter(object sender, EventArgs e)
        {
            ProAdd_Button.ForeColor = Color.Orange;
        }

        private void ProAdd_Button_MouseLeave(object sender, EventArgs e)
        {
            ProAdd_Button.ForeColor = Color.Black;
        }

        private void ProUpdate_Button_MouseEnter(object sender, EventArgs e)
        {
            ProUpdate_Button.ForeColor = Color.Orange;
        }

        private void ProUpdate_Button_MouseLeave(object sender, EventArgs e)
        {
            ProUpdate_Button.ForeColor = Color.Black;
        }

        private void ProDelete_Button_MouseEnter(object sender, EventArgs e)
        {
            ProDelete_Button.ForeColor = Color.Orange;
        }

        private void ProDelete_Button_MouseLeave(object sender, EventArgs e)
        {
            ProDelete_Button.ForeColor = Color.Black;
        }
    }
}
