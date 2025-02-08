namespace CSharpEgitimKampi301.PresentationLayer
{
    partial class FrmCategory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCategoryId = new TextBox();
            btnlist = new Button();
            dataGridView1 = new DataGridView();
            txtCategoryName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            rdbActive = new RadioButton();
            rdbPassive = new RadioButton();
            btnadd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnId = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 41);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Kategoriy ID:";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(194, 41);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(186, 27);
            txtCategoryId.TabIndex = 1;
            // 
            // btnlist
            // 
            btnlist.Location = new Point(172, 210);
            btnlist.Name = "btnlist";
            btnlist.Size = new Size(189, 45);
            btnlist.TabIndex = 2;
            btnlist.Text = "Listele";
            btnlist.UseVisualStyleBackColor = true;
            btnlist.Click += btnlist_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(430, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(857, 490);
            dataGridView1.TabIndex = 3;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(194, 86);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(186, 27);
            txtCategoryName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 86);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 4;
            label2.Text = "Kategoriy Adi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 141);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 6;
            label3.Text = "Kategoriy Durum:";
            // 
            // rdbActive
            // 
            rdbActive.AutoSize = true;
            rdbActive.Location = new Point(194, 137);
            rdbActive.Name = "rdbActive";
            rdbActive.Size = new Size(61, 24);
            rdbActive.TabIndex = 7;
            rdbActive.TabStop = true;
            rdbActive.Text = "Aktif";
            rdbActive.UseVisualStyleBackColor = true;
            // 
            // rdbPassive
            // 
            rdbPassive.AutoSize = true;
            rdbPassive.Location = new Point(194, 169);
            rdbPassive.Name = "rdbPassive";
            rdbPassive.Size = new Size(60, 24);
            rdbPassive.TabIndex = 8;
            rdbPassive.TabStop = true;
            rdbPassive.Text = "Pasif";
            rdbPassive.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(172, 279);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(189, 45);
            btnadd.TabIndex = 9;
            btnadd.Text = "Ekle";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(172, 349);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(189, 45);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(172, 417);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(189, 45);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Guncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnId
            // 
            btnId.Location = new Point(172, 486);
            btnId.Name = "btnId";
            btnId.Size = new Size(189, 45);
            btnId.TabIndex = 12;
            btnId.Text = "Id`ye Gore Getir";
            btnId.UseVisualStyleBackColor = true;
            btnId.Click += btnId_Click;
            // 
            // FrmCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 591);
            Controls.Add(btnId);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnadd);
            Controls.Add(rdbPassive);
            Controls.Add(rdbActive);
            Controls.Add(label3);
            Controls.Add(txtCategoryName);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btnlist);
            Controls.Add(txtCategoryId);
            Controls.Add(label1);
            Name = "FrmCategory";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCategoryId;
        private Button btnlist;
        private DataGridView dataGridView1;
        private TextBox txtCategoryName;
        private Label label2;
        private Label label3;
        private RadioButton rdbActive;
        private RadioButton rdbPassive;
        private Button btnadd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnId;
    }
}
