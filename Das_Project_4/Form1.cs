using System.Drawing.Text;
using System.Numerics;
using System.Security.Cryptography;

namespace Das_Project_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public decimal PricePlatformer
        {
            get { return pricePlatformer; }
            set
            {
                if (value >= 0)
                {
                    pricePlatformer = value;
                }
            }
        }
        public decimal PriceFPS
        {
            get { return priceFPS; }
            set
            {
                if (value >= 0)
                {
                    priceFPS = value;
                }
            }
        }
        public decimal PricePuzzle
        {
            get { return pricePuzzle; }
            set
            {
                if (value >= 0)
                {
                    pricePuzzle = value;
                }
            }
        }





        // DECLARED Variables 

        //decimal taxRate; //NOT NEEDED 
        string genre = ""; // Determines which Game Genere gets selected from Genere Box
        string GameTypeTransLog = "PurchasedGameTransactionLog.txt"; // String created which writes to the txt file
        internal string GenreConfig = "GenreConfig.txt"; // Searches for config file for Genere prices

        decimal pricePlatformer;
        decimal priceFPS;
        decimal pricePuzzle;

        decimal gamePrice = 0m; // Default game price without config file



        // Class level variables for Switch
        Form2 sf;
        const string GENRE_PLATFORMER = "Platformer";
        const string GENRE_FPS = "FPS";
        const string GENRE_PUZZLE = "Puzzle";

        const int LOGFILE = 2;
        const int BOTH = 3;
        const int LISTBOX = 1;



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

            //Other declared variables
            string gameTitle = ""; // Added the quotes to remove warning for empty null value
            int quantity;
            decimal total;
            bool validQuantity = false;

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
                outputMsg(" ---------- Transaction Summary At: " + DateTime.Now + " ---------- ", LOGFILE);
                outputMsg("PURCHASE SUMMARY: ", BOTH);
                outputMsg("      ", LISTBOX);
                outputMsg("Game Title: " + gameTitle, BOTH);
                outputMsg("Price of Each Game: " + gamePrice.ToString("C"), BOTH);
                outputMsg("Game Type: " + genre, BOTH);
                outputMsg("Number of Copies Ordered: " + quantity.ToString("N0"), BOTH);
                outputMsg("     ", LISTBOX);
                outputMsg("Your Total:" + total.ToString("C"), BOTH);



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
            sf = new Form2(this);
            //sf.ShowDialog();

            rdoPlatformer.Checked = true;

            bool fileValid = false;
            StreamReader sr;

            do
            {
                try
                {
                    sr = File.OpenText(GenreConfig);
                    fileValid = true;
                    PricePlatformer = decimal.Parse(sr.ReadLine()!); //Added ! to remove null refrence argument warning 
                    PriceFPS = decimal.Parse(sr.ReadLine()!);
                    PricePuzzle = decimal.Parse(sr.ReadLine()!);
                    sr.Close();
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("The configuration file is required. Please select the correct file.", "File Not Found");
                    openFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
                    openFileDialog1.ShowDialog();
                    GenreConfig = openFileDialog1.FileName;
                }
            } while (!fileValid);
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

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void mnuSettings_Click(object sender, EventArgs e)
        {

            setSettings();
            sf.ShowDialog();

        }

        internal void setSettings()
        {
            sf.txtPricePlatformer.Text = PricePlatformer.ToString();
            sf.txtPriceFPS.Text = PriceFPS.ToString();
            sf.txtPricePuzzle.Text = PricePuzzle.ToString();
        }

        private void displayLogFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set array size to = 1000
            const int MAX_SIZE = 1000;
            string[] logEntries;

            logEntries = new string[MAX_SIZE];

            StreamReader sr = File.OpenText(GameTypeTransLog);
            int numEntries = 0;

            while (!sr.EndOfStream)
            {
                logEntries[numEntries] = sr.ReadLine()!; //Added ! to remove warning
                numEntries++;
            }
            sr.Close();


            lstOut.Items.Clear();
            lstOut.Items.Add("Transactions for Genre: " + genre);
            lstOut.Items.Add("  ");
            lstOut.Items.Add("----------------------------------");

            int begTrans = 1;
            int endTrans = 5;

            // FOR LOOP – scan array
            for (int i = 0; i < numEntries; i++)
            {
                if (logEntries[i] == "Game Type: " + genre)
                {
                    for (int j = i - begTrans; j <= i + endTrans && j < numEntries; j++)
                    {

                        lstOut.Items.Add(logEntries[j]);

                    }
                    lstOut.Items.Add(" ");
                    i += endTrans;
                }
            }

        }

        private void outputMsg(string msg, int outputType)
        {
            StreamWriter sw;
            if (outputType == LISTBOX || outputType == BOTH)
            {
                lstOut.Items.Add(msg);
            }

            if (outputType == LOGFILE || outputType == BOTH)

            {
                sw = File.AppendText(GameTypeTransLog);
                sw.WriteLine(msg);

                sw.Close();
            }

        }
    }
}