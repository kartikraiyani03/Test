namespace MDI
{
    partial class ApiForm
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            txtId = new TextBox();
            txtUserId = new TextBox();
            txtTitle = new TextBox();
            txtBody = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAddToDatabase = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(86, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(516, 226);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // dataGridView2
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(688, 51);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(608, 226);
            dataGridView2.TabIndex = 1;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // txtId
            // 
            txtId.Location = new Point(84, 449);
            txtId.Name = "txtId";
            txtId.Size = new Size(110, 27);
            txtId.TabIndex = 2;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(247, 449);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(110, 27);
            txtUserId.TabIndex = 3;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(400, 449);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(245, 27);
            txtTitle.TabIndex = 4;
            // 
            // txtBody
            // 
            txtBody.Location = new Point(688, 449);
            txtBody.Name = "txtBody";
            txtBody.Size = new Size(227, 27);
            txtBody.TabIndex = 5;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(688, 331);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(121, 46);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(852, 331);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 46);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1020, 331);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 46);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(1175, 331);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(121, 46);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 407);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 10;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 407);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 11;
            label2.Text = "UserId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(400, 407);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 12;
            label3.Text = "Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(688, 407);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 13;
            label4.Text = "Body";
            // 
            // btnAddToDatabase
            // 
            btnAddToDatabase.Location = new Point(86, 319);
            btnAddToDatabase.Name = "btnAddToDatabase";
            btnAddToDatabase.Size = new Size(184, 46);
            btnAddToDatabase.TabIndex = 14;
            btnAddToDatabase.Text = "Add to Database";
            btnAddToDatabase.UseVisualStyleBackColor = true;
            btnAddToDatabase.Click += btnAddToDatabase_Click_1;
            // 
            // ApiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 632);
            Controls.Add(btnAddToDatabase);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtBody);
            Controls.Add(txtTitle);
            Controls.Add(txtUserId);
            Controls.Add(txtId);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "ApiForm";
            Text = "ApiForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox txtId;
        private TextBox txtUserId;
        private TextBox txtTitle;
        private TextBox txtBody;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAddToDatabase;
    }
}