using System.Numerics;

namespace Das_Project_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // DECLARED Variables 
        string gameTitle = ""; //Added the quotes to remove warning for empty null value
        int quantity;
        decimal gamePrice = 20m; //default game price
        decimal total;
        //decimal taxRate; //NOT NEEDED 
        bool validQuantity = false;
        string genre = "";


        //Class Level Variables for Switch

        const string GENRE_PLATFORMER = "Platformer";
        const string GENRE_FPS = "FPS";
        const string GENRE_PUZZLE = "Puzzle";

        decimal PricePlatformer = 20m;
        decimal PriceFPS = 35m;
        decimal PricePuzzle = 45m;


        //QUIT BUTTION
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

            // Check for Numeric in Quantity with TryParse
            validQuantity = int.TryParse(txtQuantity.Text, out quantity);

            //checks for game title
            gameTitle = txtGameTitle.Text;

            // Switch Statement
            switch (genre)
            {
                case GENRE_PLATFORMER:
                    gamePrice = PricePlatformer;
                    break;

                case GENRE_FPS:
                    gamePrice = PriceFPS;
                    break;

                case GENRE_PUZZLE:
                    gamePrice = PricePuzzle;
                    break;
                default:
                    lstOut.Items.Add("Error in this switch - This should never happen");
                    break;

            }



            // if statement
            if (validQuantity)
            {
                //Read from the text box into the variable
                gameTitle = txtGameTitle.Text;


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

                //Adds error if there is no text in Game
                if (gameTitle == "")
                {
                    lstOut.Items.Add("Please enter a Game Title");
                }
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

            //defaults selection to platformer
            rdoPlatformer.Checked = true;
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
            rdoPlatformer.Checked = true;
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPlatformer.Checked)
            {
                genre = GENRE_PLATFORMER;
                gamePrice = PricePlatformer;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFPS.Checked)
            {
                genre = GENRE_FPS;
                gamePrice = PriceFPS;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPuzzle.Checked)
            {
                genre = GENRE_PUZZLE;
                gamePrice = PricePuzzle;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Optional action when clicking label1
        }
    }
}
