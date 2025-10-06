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
            string gameTitle;
            int quantity;
            //decimal taxRate;
            decimal gamePrice = 20;
            decimal total;

            //Read from the text box into the variable
            gameTitle = txtGameTitle.Text;

            quantity = int.Parse(txtQuantity.Text);

            total = gamePrice * quantity;
            
            //taxRate = decimal.Parse(txtTaxRate.Text)


            // Output of the Calc

            
            ///TO BE USED in NEXT ICA
            
            ///lstOut.Items.Add("The Game Title is: " + txtGameTitle);
            ///lstOut.Items.Add("The Number of Copies Bought is: " + txtQuantity);
            ///lstOut.Items.Add("Price of Each Game: " + txtGameTitle);

            ///ToString("")
            ///lstOut.Items.Add(ToString(""))

            btnReset.Focus();
        }

        private void txtGameTitle_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtGameTitle.Clear();
            txtQuantity.Clear();
            lstOut.Items.Clear();
            txtGameTitle.Focus();
        }


        ///FOCUS COLOR CHANGES

        ///Changes the color based on focus on Game Title Field
        private void txtGameTitle_Enter(object sender, EventArgs e)
        {
            txtGameTitle.BackColor = Color.Beige;
        }

        private void txtGameTitle_Leave(object sender, EventArgs e)
        {
            txtGameTitle.BackColor = SystemColors.Window;
        }

        ///Changes the color based on focus on Quantity Field 
        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            txtQuantity.BackColor = Color.Beige;
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
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
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
