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
        string gameTitle = ""; // Added the quotes to remove warning for empty null value
        int quantity;
        decimal gamePrice = 20m; // Default game price
        decimal total;
        //decimal taxRate; //NOT NEEDED 
        bool validQuantity = false;
        string genre = ""; // Determines which Game Genere gets selected from Genere Box
        string GameTypeTransLog = "PurchasedGameTransactionLog.txt"; // String created which writes to the txt file


        // Class level variables for Switch

        const string GENRE_PLATFORMER = "Platformer";
        const string GENRE_FPS = "FPS";
        const string GENRE_PUZZLE = "Puzzle";

        // Prices for Games Generes
        decimal PricePlatformer = 20m;
        decimal PriceFPS = 35m;
        decimal PricePuzzle = 45m;


        // QUIT BUTTION
        private void btnQuit_Click(object sender, EventArgs e)
        {

            DialogResult buttonSelected = MessageBox.Show("Are you sure you want to Quit?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (buttonSelected == DialogResult.Yes)

            {
                this.Close();
            }
        }

        // CALCULATION BUTTON
        private void btnCalc_Click(object sender, EventArgs e)
        {

            // Check for Numeric in Quantity with TryParse
            validQuantity = int.TryParse(txtQuantity.Text, out quantity);

            // Checks for GameTitle in "Game Title" via if statement
            gameTitle = txtGameTitle.Text;


            // Switch Statement
            if (validQuantity && gameTitle != "")
            {
                // Switch Statement - sets price based on selected genre
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


                // Writes Transaction history to file named " PurchasedGameTransactionLog.txt "
                StreamWriter sw;
                sw = File.AppendText(GameTypeTransLog);
                sw.WriteLine(" ---------- Transaction Summary At: " + DateTime.Now + " ---------- ");
                sw.WriteLine("     ");
                sw.WriteLine("Game Type: " + genre);
                sw.WriteLine("Game Title: " + gameTitle);
                sw.WriteLine("Game Price: " + gamePrice);
                sw.WriteLine("Number of Copies Ordered: " + quantity);
                sw.WriteLine("     ");
                sw.WriteLine("Total Charged: " + total.ToString("C"));

                // Closes txt file
                sw.Close();

                btnReset.Focus();
            }
            else
            {
                // Listed error messages for invalid inputs 
                lstOut.Items.Clear();
                lstOut.Items.Add("Please refer to the following errors: ");

                if (!validQuantity)
                {
                    lstOut.Items.Add("Quantity must be a whole number!");
                }

                if (gameTitle == "")
                {
                    lstOut.Items.Add("Please enter a Game Title!");
                }
            }
        }

        private void txtGameTitle_TextChanged(object sender, EventArgs e)
        {

        }

        // RESET BUTTON
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtGameTitle.Clear();
            txtQuantity.Clear();
            lstOut.Items.Clear();
            txtGameTitle.Focus();

            //defaults selection to platformer
            rdoPlatformer.Checked = true;
        }


        // FOCUS COLOR CHANGES

        // Changes the color based on focus on Game Title Field
        private void txtGameTitle_Enter(object sender, EventArgs e)
        {
            txtGameTitle.BackColor = Color.Beige;
        }

        private void txtGameTitle_Leave(object sender, EventArgs e)
        {
            txtGameTitle.BackColor = SystemColors.Window;
        }

        // Changes the color based on focus on Quantity Field 
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
            // Added to remove error within the code
        }
    }
}
