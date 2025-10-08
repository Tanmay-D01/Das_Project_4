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

            DialogResult buttonSelected = MessageBox.Show("Are you sure you want to Quit?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (buttonSelected == DialogResult.Yes)

            {
                this.Close();
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Decleared Variables 
            string gameTitle;
            int quantity;
            decimal gamePrice = 20m;
            decimal total;
            //decimal taxRate; //NOT NEEDED 
            bool validQuantity;

            // Check for Numeric in Quantity with TryParse
            validQuantity = int.TryParse(txtQuantity.Text, out quantity);

            // if statement
            if (validQuantity)
            {


                //Read from the text box into the variable
                gameTitle = txtGameTitle.Text;

                quantity = int.Parse(txtQuantity.Text);


                // CALCULATION: 
                total = gamePrice * quantity;


                // CLEAR LIST:
                lstOut.Items.Clear();


                // OUTPUT IN LISTBOX:
                lstOut.Items.Add("PURCHASE SUMMARY: ");
                lstOut.Items.Add("      ");
                lstOut.Items.Add("Game Title: " + gameTitle);
                lstOut.Items.Add("Price of Each Game: " + gamePrice.ToString("C"));
                lstOut.Items.Add("Number of Copies: " + quantity);
                lstOut.Items.Add("    ");
                lstOut.Items.Add("Your Total Cost: $" + total);

                btnReset.Focus();
            }
            else
            {
                lstOut.Items.Add("Please Input the Correct Values!");
            }
            if (!validQuantity)
            {
                lstOut.Items.Add("Numer of quantity is not a whole number");
            }
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
