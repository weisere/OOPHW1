namespace HW1part2
{
    public partial class Form1 : Form
    {
        public bool citzenStatBool;
        public int age;
        public int yearsInUSInt;
        public int termsInt;
        public bool rebelBool;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            citzenStatBool = citezenStatus.Checked;
        }

        private void birthYear_TextChanged(object sender, EventArgs e)
        {
            age = int.Parse(birthYear.Text);
        }

        private void yearsInUS_TextChanged(object sender, EventArgs e)
        {
            yearsInUSInt = int.Parse(yearsInUS.Text);
        }

        private void terms_TextChanged(object sender, EventArgs e)
        {
            termsInt = int.Parse(terms.Text);

        }

        private void rebelStatus_CheckedChanged(object sender, EventArgs e)
        {
            rebelBool = rebelStatus.Checked;
        }

        private void DisplayElgibility_Click(object sender, EventArgs e)
        {
            if (citzenStatBool & age < 1989 & termsInt < 2 & !rebelBool & yearsInUSInt > 13)
            {
                MessageBox.Show("You are eligible to run for El Presedante!");
            }
            else
            {
                MessageBox.Show("You are not eligible to run for El Presedante!");
            }
        }
    }
}