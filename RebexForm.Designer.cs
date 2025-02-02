namespace MDI
{
    partial class RebexForm
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
            btnUpload = new Button();
            btnDownload = new Button();
            txtInput = new TextBox();
            txtDest = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            btnBrowse = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(349, 216);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(196, 63);
            btnUpload.TabIndex = 0;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(576, 216);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(196, 63);
            btnDownload.TabIndex = 1;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(115, 371);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(188, 27);
            txtInput.TabIndex = 2;
            // 
            // txtDest
            // 
            txtDest.Location = new Point(396, 371);
            txtDest.Name = "txtDest";
            txtDest.Size = new Size(188, 27);
            txtDest.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(115, 216);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(196, 63);
            btnBrowse.TabIndex = 4;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 331);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 5;
            label1.Text = "Browse File Path";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(396, 331);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 6;
            label2.Text = "Download File Path";
            // 
            // RebexForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1441, 709);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBrowse);
            Controls.Add(txtDest);
            Controls.Add(txtInput);
            Controls.Add(btnDownload);
            Controls.Add(btnUpload);
            Name = "RebexForm";
            Text = "RebexForm";
            Load += RebexForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpload;
        private Button btnDownload;
        private TextBox txtInput;
        private TextBox txtDest;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button btnBrowse;
        private Label label1;
        private Label label2;
    }
}