
namespace CharpEgitimKampi501
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_CategoryCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_maxPriceProductCount = new System.Windows.Forms.Label();
            this.lbl_TotalBook = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Category = new System.Windows.Forms.TextBox();
            this.btnExit_Click = new System.Windows.Forms.Button();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_ProductPrice = new System.Windows.Forms.Label();
            this.txt_ProductPrice = new System.Windows.Forms.TextBox();
            this.lbl_UrunStock = new System.Windows.Forms.Label();
            this.txt_ProductStock = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_GetById = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_GetAll = new System.Windows.Forms.Button();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_productId = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_ProductId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CategoryCount
            // 
            this.lbl_CategoryCount.AutoSize = true;
            this.lbl_CategoryCount.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_CategoryCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_CategoryCount.Location = new System.Drawing.Point(600, 558);
            this.lbl_CategoryCount.Name = "lbl_CategoryCount";
            this.lbl_CategoryCount.Size = new System.Drawing.Size(25, 29);
            this.lbl_CategoryCount.TabIndex = 87;
            this.lbl_CategoryCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(413, 558);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 29);
            this.label5.TabIndex = 86;
            this.label5.Text = "Kategori Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(600, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 29);
            this.label2.TabIndex = 85;
            this.label2.Text = "0";
            // 
            // lbl_maxPriceProductCount
            // 
            this.lbl_maxPriceProductCount.AutoSize = true;
            this.lbl_maxPriceProductCount.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_maxPriceProductCount.Location = new System.Drawing.Point(413, 512);
            this.lbl_maxPriceProductCount.Name = "lbl_maxPriceProductCount";
            this.lbl_maxPriceProductCount.Size = new System.Drawing.Size(169, 29);
            this.lbl_maxPriceProductCount.TabIndex = 84;
            this.lbl_maxPriceProductCount.Text = "En Pahalı Kitap:";
            // 
            // lbl_TotalBook
            // 
            this.lbl_TotalBook.AutoSize = true;
            this.lbl_TotalBook.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_TotalBook.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_TotalBook.Location = new System.Drawing.Point(631, 463);
            this.lbl_TotalBook.Name = "lbl_TotalBook";
            this.lbl_TotalBook.Size = new System.Drawing.Size(25, 29);
            this.lbl_TotalBook.TabIndex = 83;
            this.lbl_TotalBook.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(413, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 82;
            this.label1.Text = "Toplam Kitap Sayısı:";
            // 
            // txt_Category
            // 
            this.txt_Category.Location = new System.Drawing.Point(131, 195);
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.Size = new System.Drawing.Size(237, 22);
            this.txt_Category.TabIndex = 81;
            // 
            // btnExit_Click
            // 
            this.btnExit_Click.Location = new System.Drawing.Point(214, 347);
            this.btnExit_Click.Name = "btnExit_Click";
            this.btnExit_Click.Size = new System.Drawing.Size(175, 42);
            this.btnExit_Click.TabIndex = 80;
            this.btnExit_Click.Text = "Çıkış";
            this.btnExit_Click.UseVisualStyleBackColor = true;
            this.btnExit_Click.Click += new System.EventHandler(this.btnExit_Click_Click_1);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(33, 347);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(175, 42);
            this.btn_Temizle.TabIndex = 79;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click_1);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Location = new System.Drawing.Point(40, 198);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(65, 17);
            this.lbl_Category.TabIndex = 78;
            this.lbl_Category.Text = "Kategori:";
            // 
            // lbl_ProductPrice
            // 
            this.lbl_ProductPrice.AutoSize = true;
            this.lbl_ProductPrice.Location = new System.Drawing.Point(28, 153);
            this.lbl_ProductPrice.Name = "lbl_ProductPrice";
            this.lbl_ProductPrice.Size = new System.Drawing.Size(77, 17);
            this.lbl_ProductPrice.TabIndex = 77;
            this.lbl_ProductPrice.Text = "Ürün Fiyat:";
            // 
            // txt_ProductPrice
            // 
            this.txt_ProductPrice.Location = new System.Drawing.Point(131, 153);
            this.txt_ProductPrice.Name = "txt_ProductPrice";
            this.txt_ProductPrice.Size = new System.Drawing.Size(237, 22);
            this.txt_ProductPrice.TabIndex = 76;
            // 
            // lbl_UrunStock
            // 
            this.lbl_UrunStock.AutoSize = true;
            this.lbl_UrunStock.Location = new System.Drawing.Point(30, 115);
            this.lbl_UrunStock.Name = "lbl_UrunStock";
            this.lbl_UrunStock.Size = new System.Drawing.Size(75, 17);
            this.lbl_UrunStock.TabIndex = 75;
            this.lbl_UrunStock.Text = "Ürün Stok:";
            // 
            // txt_ProductStock
            // 
            this.txt_ProductStock.Location = new System.Drawing.Point(131, 112);
            this.txt_ProductStock.Name = "txt_ProductStock";
            this.txt_ProductStock.Size = new System.Drawing.Size(237, 22);
            this.txt_ProductStock.TabIndex = 74;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(416, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1120, 407);
            this.dataGridView1.TabIndex = 73;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // btn_GetById
            // 
            this.btn_GetById.Enabled = false;
            this.btn_GetById.Location = new System.Drawing.Point(33, 251);
            this.btn_GetById.Name = "btn_GetById";
            this.btn_GetById.Size = new System.Drawing.Size(175, 42);
            this.btn_GetById.TabIndex = 72;
            this.btn_GetById.Text = "Id\'ye Göre Getir";
            this.btn_GetById.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(214, 299);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(175, 42);
            this.btn_Update.TabIndex = 71;
            this.btn_Update.Text = "Güncelle";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click_1);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(33, 299);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(175, 42);
            this.btn_Delete.TabIndex = 70;
            this.btn_Delete.Text = "Sil";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(214, 251);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(175, 42);
            this.btn_Add.TabIndex = 69;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click_1);
            // 
            // btn_GetAll
            // 
            this.btn_GetAll.Location = new System.Drawing.Point(33, 395);
            this.btn_GetAll.Name = "btn_GetAll";
            this.btn_GetAll.Size = new System.Drawing.Size(356, 42);
            this.btn_GetAll.TabIndex = 68;
            this.btn_GetAll.Text = "Listele";
            this.btn_GetAll.UseVisualStyleBackColor = true;
            this.btn_GetAll.Click += new System.EventHandler(this.btn_GetAll_Click_1);
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Location = new System.Drawing.Point(38, 74);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(67, 17);
            this.lbl_ProductName.TabIndex = 67;
            this.lbl_ProductName.Text = "Ürün Adı:";
            // 
            // lbl_productId
            // 
            this.lbl_productId.AutoSize = true;
            this.lbl_productId.Location = new System.Drawing.Point(42, 33);
            this.lbl_productId.Name = "lbl_productId";
            this.lbl_productId.Size = new System.Drawing.Size(63, 17);
            this.lbl_productId.TabIndex = 66;
            this.lbl_productId.Text = "Ürüm ID:";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(131, 71);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(237, 22);
            this.txt_ProductName.TabIndex = 65;
            // 
            // txt_ProductId
            // 
            this.txt_ProductId.Enabled = false;
            this.txt_ProductId.Location = new System.Drawing.Point(131, 33);
            this.txt_ProductId.Name = "txt_ProductId";
            this.txt_ProductId.Size = new System.Drawing.Size(237, 22);
            this.txt_ProductId.TabIndex = 64;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1630, 618);
            this.Controls.Add(this.lbl_CategoryCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_maxPriceProductCount);
            this.Controls.Add(this.lbl_TotalBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Category);
            this.Controls.Add(this.btnExit_Click);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.lbl_ProductPrice);
            this.Controls.Add(this.txt_ProductPrice);
            this.Controls.Add(this.lbl_UrunStock);
            this.Controls.Add(this.txt_ProductStock);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_GetById);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_GetAll);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.lbl_productId);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.txt_ProductId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CategoryCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_maxPriceProductCount;
        private System.Windows.Forms.Label lbl_TotalBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Category;
        private System.Windows.Forms.Button btnExit_Click;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_ProductPrice;
        private System.Windows.Forms.TextBox txt_ProductPrice;
        private System.Windows.Forms.Label lbl_UrunStock;
        private System.Windows.Forms.TextBox txt_ProductStock;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_GetById;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_GetAll;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_productId;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.TextBox txt_ProductId;
    }
}

