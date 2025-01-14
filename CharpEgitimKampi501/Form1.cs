using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharpEgitimKampi501.Dtos;
using Dapper;

namespace CharpEgitimKampi501
{
    public partial class Form1 : Form
    {
        // DAPPER İşlemleri
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection connection = new SqlConnection(@"Server=DESKTOP-XXXXXXX\SQLEXPRESS; " +
                                                             "Initial Catalog=EgitimKampi501Db;" +
                                                             "Integrated Security=True");

        public async void Statistics()
        {
            try
            {
                string connectionString = @"Server=DESKTOP-XXXXXXX\SQLEXPRESS; Initial Catalog=EgitimKampi501Db; Integrated Security=True";

                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string query1 = "Select Count(*) From TblProduct";
                    var productTotalCount = await connection.QueryFirstOrDefaultAsync<int>(query1);
                    lbl_TotalBook.Text = productTotalCount.ToString();

                    string query2 = "Select ProductName From TblProduct Where ProductPrice=(Select Max(ProductPrice) From TblProduct)";
                    var maxPriceProductCount = await connection.QueryFirstOrDefaultAsync<string>(query2);
                    label2.Text = maxPriceProductCount.ToString();

                    string query3 = "Select Count(Distinct(ProductCategory)) From TblProduct";
                    var distinctProductCount = await connection.QueryFirstOrDefaultAsync<int>(query3);
                    lbl_CategoryCount.Text = distinctProductCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İstatistik verileri alınırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void GetAll()
        {
            try
            {
                string query = "Select * From TblProduct";
                var values = await connection.QueryAsync<ResultProductDto>(query);
                dataGridView1.DataSource = values;
                Statistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler getirilirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GetAll();
        }

        private async void btn_Add_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_ProductName.Text) ||
                    string.IsNullOrWhiteSpace(txt_ProductStock.Text) ||
                    string.IsNullOrWhiteSpace(txt_ProductPrice.Text) ||
                    string.IsNullOrWhiteSpace(txt_Category.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txt_ProductStock.Text, out _) || !decimal.TryParse(txt_ProductPrice.Text, out _))
                {
                    MessageBox.Show("Stok ve fiyat alanlarına geçerli sayısal değerler giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "insert into TblProduct(ProductName,ProductStock,ProductPrice,ProductCategory) values" +
                               "(@productName,@productStock,@productPrice,@productCategory)";
                var parameters = new DynamicParameters();
                parameters.Add("@productName", txt_ProductName.Text);
                parameters.Add("@productStock", txt_ProductStock.Text);
                parameters.Add("@productPrice", txt_ProductPrice.Text);
                parameters.Add("@productCategory", txt_Category.Text);

                await connection.ExecuteAsync(query, parameters);
                MessageBox.Show("Yeni Kitap Eklendi");
                GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ekleme işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_ProductId.Text))
                {
                    MessageBox.Show("Lütfen silinecek ürünün ID'sini giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "Delete From TblProduct Where ProductId=@productId";
                var parameters = new DynamicParameters();
                parameters.Add("@productId", txt_ProductId.Text);

                await connection.ExecuteAsync(query, parameters);
                MessageBox.Show("Silme İşlemi Başarılı");
                GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Silme işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_Update_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_ProductId.Text) ||
                    string.IsNullOrWhiteSpace(txt_ProductName.Text) ||
                    string.IsNullOrWhiteSpace(txt_ProductStock.Text) ||
                    string.IsNullOrWhiteSpace(txt_ProductPrice.Text) ||
                    string.IsNullOrWhiteSpace(txt_Category.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txt_ProductStock.Text, out _) || !decimal.TryParse(txt_ProductPrice.Text, out _))
                {
                    MessageBox.Show("Stok ve fiyat alanlarına geçerli sayısal değerler giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "Update TblProduct Set " +
                               "ProductName=@productName, " +
                               "ProductStock=@productStock, " +
                               "ProductPrice=@productPrice, " +
                               "ProductCategory=@productCategory " +
                               "where ProductId=@productId";

                var parameters = new DynamicParameters();
                parameters.Add("@productName", txt_ProductName.Text);
                parameters.Add("@productStock", txt_ProductStock.Text);
                parameters.Add("@productPrice", txt_ProductPrice.Text);
                parameters.Add("@productCategory", txt_Category.Text);
                parameters.Add("@productId", txt_ProductId.Text);

                await connection.ExecuteAsync(query, parameters);
                MessageBox.Show("Güncelleme işlemi yapıldı!", "Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Temizle_Click_1(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        private void btnExit_Click_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_ProductId.Text = row.Cells["ProductId"].Value.ToString();
                txt_ProductName.Text = row.Cells["ProductName"].Value.ToString();
                txt_ProductStock.Text = row.Cells["ProductStock"].Value.ToString();
                txt_ProductPrice.Text = row.Cells["ProductPrice"].Value.ToString();
                txt_Category.Text = row.Cells["ProductCategory"].Value.ToString();
            }
        }

        private async void btn_GetAll_Click_1(object sender, EventArgs e)
        {
            GetAll();
        }
    }
}
