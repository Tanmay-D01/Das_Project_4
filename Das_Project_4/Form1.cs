using System.Numerics;

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
            // variables need to declared with data type - string
            string customerName;
            //int numQuantity;
            //decimal taxRate;
            //decimal widgetPrice = 5;
           // decimal total, subtotal, amTax;

            //Read from the text box into the variable
            customerName = txtGameTitle.Text;

            //numQuantity = int.Parse(numQuantity.Text);
            //taxRate = decimal.Parse(txtTaxRate.Text)


            // Output of the Calc


            lstOut.Items.Add("The Game Title is: " + txtGameTitle);
            lstOut.Items.Add("The Number of Copies Bought is: " + txtQuantity);
            lstOut.Items.Add("Price of Each Game: " + txtGameTitle);

            ToString("")
            lstOut.Items.Add(ToString(""))

            btnReset.Focus();
        }

        private void txtnumwidgets_TextChanged(object sender, EventArgs e)
        {
            d
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtGameTitle.Clear();
            txtQuantity.Clear();
            lstOut.Items.Clear();
            txtGameTitle.Focus();
        }

        private void txtnumwidgets_Enter(object sender, EventArgs e)
        {
            txtQuantity.BackColor = Color.Beige;
        }

        private void txtnumwidgets_Leave(object sender, EventArgs e)
        {
            txtQuantity.BackColor = SystemColors.Window;
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
