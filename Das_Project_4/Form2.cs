using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            //ff is a local ver but the code needs a Class lvl var
            // so the Transaction Form var was created to 
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
            bool platformerOK, fpsOK, PuzzleOK;
            platformerOK = decimal.TryParse(txtPlatformer.Text, out tempPrice);

            if (platformerOK)
            {
                transactionForm.platormer
            }
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
