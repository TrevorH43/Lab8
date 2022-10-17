namespace Lab8
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vendingMachineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckIfFormCreated(typeof(VendingForm)))
            {
                VendingForm vendingForm = new VendingForm();
                vendingForm.MdiParent = this;
                vendingForm.WindowState = FormWindowState.Maximized;
                vendingForm.Show();
            }
        }
        private bool CheckIfFormCreated(Type formType)
        {
            bool formCreated = false;

            // Check all open forms to see if this form has already been instantiated
            foreach (Form form in Application.OpenForms)
            {
                // If the type matches, then activate the form instance
                if (form.GetType() == formType)
                {
                    formCreated = true;
                    form.Activate();
                    break;
                }
            }

            return formCreated;
        }

        private void courseInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckIfFormCreated(typeof(CourseForm)))
            {
                CourseForm courseForm = new CourseForm();
                courseForm.MdiParent = this;
                courseForm.WindowState = FormWindowState.Maximized;
                courseForm.Show();
            }
        }

        private void wordIndexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckIfFormCreated(typeof(WordForm)))
            {
                WordForm wordForm = new WordForm();
                wordForm.MdiParent = this;
                wordForm.WindowState = FormWindowState.Maximized;
                wordForm.Show();
            }
        }
    }
}