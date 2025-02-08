namespace CSharpEgitimKampi301.PresentationLayer
{
    partial class FrmProduct
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
            btnId = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnadd = new Button();
            txtProductName = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            btnlist = new Button();
            txtProductId = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtDescription = new TextBox();
            label5 = new Label();
            textProductPrice = new TextBox();
            label6 = new Label();
            textProductStock = new TextBox();
            label7 = new Label();
            cmbCategory = new ComboBox();
            btnList2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnId
            // 
            btnId.Location = new Point(126, 675);
            btnId.Name = "btnId";
            btnId.Size = new Size(189, 45);
            btnId.TabIndex = 25;
            btnId.Text = "Id`ye Gore Getir";
            btnId.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(126, 606);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(189, 45);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Guncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(126, 538);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(189, 45);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(126, 468);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(189, 45);
            btnadd.TabIndex = 22;
            btnadd.Text = "Ekle";
            btnadd.UseVisualStyleBackColor = true;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(129, 87);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(186, 27);
            txtProductName.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 87);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 17;
            label2.Text = "Urun Adi:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.MediumTurquoise;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(360, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(964, 682);
            dataGridView1.TabIndex = 16;
            // 
            // btnlist
            // 
            btnlist.Location = new Point(126, 399);
            btnlist.Name = "btnlist";
            btnlist.Size = new Size(78, 45);
            btnlist.TabIndex = 15;
            btnlist.Text = "Listele";
            btnlist.UseVisualStyleBackColor = true;
            btnlist.Click += btnlist_Click;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(129, 42);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(186, 27);
            txtProductId.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 42);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 13;
            label1.Text = "Urun ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 263);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 28;
            label4.Text = "Urun Aciklamasi:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(129, 260);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(186, 116);
            txtDescription.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 219);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 26;
            label5.Text = "Kategori:";
            // 
            // textProductPrice
            // 
            textProductPrice.Location = new Point(129, 177);
            textProductPrice.Name = "textProductPrice";
            textProductPrice.Size = new Size(186, 27);
            textProductPrice.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 177);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 32;
            label6.Text = "Urun Fiyat:";
            // 
            // textProductStock
            // 
            textProductStock.Location = new Point(129, 132);
            textProductStock.Name = "textProductStock";
            textProductStock.Size = new Size(186, 27);
            textProductStock.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 132);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 30;
            label7.Text = "Urun Stok:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(129, 216);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(186, 28);
            cmbCategory.TabIndex = 34;
            // 
            // btnList2
            // 
            btnList2.Location = new Point(219, 399);
            btnList2.Name = "btnList2";
            btnList2.Size = new Size(78, 45);
            btnList2.TabIndex = 35;
            btnList2.Text = "Listele 2";
            btnList2.UseVisualStyleBackColor = true;
            btnList2.Click += btnList2_Click;
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 736);
            Controls.Add(btnList2);
            Controls.Add(cmbCategory);
            Controls.Add(textProductPrice);
            Controls.Add(label6);
            Controls.Add(textProductStock);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(txtDescription);
            Controls.Add(label5);
            Controls.Add(btnId);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnadd);
            Controls.Add(txtProductName);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btnlist);
            Controls.Add(txtProductId);
            Controls.Add(label1);
            Name = "FrmProduct";
            Text = "FrmProduct";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnId;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnadd;
        private TextBox txtProductName;
        private Label label2;
        private DataGridView dataGridView1;
        private Button btnlist;
        private TextBox txtProductId;
        private Label label1;
        private Label label4;
        private TextBox txtDescription;
        private Label label5;
        private TextBox textProductPrice;
        private Label label6;
        private TextBox textProductStock;
        private Label label7;
        private ComboBox cmbCategory;
        private Button btnList2;
    }
}