using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Das_Project_4
{
    public partial class Form2 : Form
    {
        Form1 transactionForm; 
        public Form2(Form1 ff) //given parameter for Form 1 
        {
            InitializeComponent();
            // ff is a local var but the code needs a Class lvl var
            // so the Transaction Form var was created on the class lvl
            // and set to ff
            transactionForm = ff;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveReturn_Click(object sender, EventArgs e)
        {
            // the temp var is needed since the tryparse does not allow properties in our parameter
            decimal tempPrice;
            bool platformerOK, fpsOK, puzzleOK;


            // PLATFORMER
            platformerOK = decimal.TryParse(txtPricePlatformer.Text, out tempPrice);

            if (platformerOK)
            {
                transactionForm.PricePlatformer = tempPrice;
            }

            // FPS
            fpsOK = decimal.TryParse(txtPriceFPS.Text, out tempPrice);
            if (fpsOK)
            {
                transactionForm.PriceFPS = tempPrice;
            }

            // PUZZLE
            puzzleOK = decimal.TryParse(txtPricePuzzle.Text, out tempPrice);
            if (puzzleOK)
            {
                transactionForm.PricePuzzle = tempPrice;
            }
            

            if (platformerOK && fpsOK && puzzleOK)
            {
                lblErrorMsg.Text = "";
                // part of optional code - need btncalc button to be internal
                StreamWriter sw;
                sw = File.CreateText(transactionForm.GenreConfig);
                sw.WriteLine(transactionForm.PricePlatformer.ToString());
                sw.WriteLine(transactionForm.PriceFPS.ToString());
                sw.WriteLine(transactionForm.PricePuzzle.ToString());
                sw.Close();


                this.Hide();
            }
            else
            {
                transactionForm.setSettings();
                lblErrorMsg.Text = "One or more settings entered is invalid, please input the correct values";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
