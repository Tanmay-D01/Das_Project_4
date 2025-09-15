namespace Das_Project_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

        }

        private void txtnumwidgets_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtcustomername.Clear();
            txtnumwidgets.Clear();
            PriceOut.Items.Clear();
        }

        private void txtnumwidgets_Enter(object sender, EventArgs e)
        {
            txtnumwidgets.BackColor = Color.Beige;
        }

        private void txtnumwidgets_Leave(object sender, EventArgs e)
        {
            txtnumwidgets.BackColor = SystemColors.Window;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtcustomername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
