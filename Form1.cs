namespace MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void OpenChildForm(Form childForm)
        {
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }

        private void aPIFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ApiForm());
        }

        private void rebexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RebexForm());
        }

        private void ynamicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DynamicControlForm());
        }
    }
}
