using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class DynamicControlForm : Form
    {
        public DynamicControlForm()
        {
            InitializeComponent();
        }

        private void DynamicControlForm_Load(object sender, EventArgs e) { }

        private void btnDynamiControl_Click(object sender, EventArgs e)
        {
            TextBox dynamicTextBox = new TextBox
            {
                Name = "txtDynamic",
                Location = new System.Drawing.Point(50, 50),
                Width = 200,
            };

            Button dynamicButton = new Button
            {
                Text = "Click Me",
                Location = new System.Drawing.Point(50, 80),
            };
            dynamicButton.Click += (s, args) => MessageBox.Show($"Dynamic Button Clicked! with Text {dynamicTextBox.Text}");

            this.Controls.Add(dynamicTextBox);
            this.Controls.Add(dynamicButton);
        }
    }
}
