namespace MDI
{
    partial class DynamicControlForm
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
            btnDynamiControl = new Button();
            SuspendLayout();
            // 
            // btnDynamiControl
            // 
            btnDynamiControl.Location = new Point(255, 172);
            btnDynamiControl.Name = "btnDynamiControl";
            btnDynamiControl.Size = new Size(172, 57);
            btnDynamiControl.TabIndex = 0;
            btnDynamiControl.Text = "Dynamic Control";
            btnDynamiControl.UseVisualStyleBackColor = true;
            btnDynamiControl.Click += btnDynamiControl_Click;
            // 
            // DynamicControlForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDynamiControl);
            Name = "DynamicControlForm";
            Text = "DynamicControlForm";
            Load += DynamicControlForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnDynamiControl;
    }
}