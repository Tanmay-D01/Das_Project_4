namespace Das_Project_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtQuantity = new TextBox();
            label1 = new Label();
            txtGameTitle = new TextBox();
            label2 = new Label();
            btnCalc = new Button();
            btnReset = new Button();
            btnQuit = new Button();
            PriceOut = new ListBox();
            SuspendLayout();
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(111, 50);
            txtQuantity.Margin = new Padding(2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(55, 23);
            txtQuantity.TabIndex = 2;
            txtQuantity.TextChanged += txtnumwidgets_TextChanged;
            txtQuantity.Enter += txtnumwidgets_Enter;
            txtQuantity.Leave += txtnumwidgets_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Game Title";
            label1.Click += label1_Click;
            // 
            // txtGameTitle
            // 
            txtGameTitle.Location = new Point(111, 22);
            txtGameTitle.Margin = new Padding(2);
            txtGameTitle.Name = "txtGameTitle";
            txtGameTitle.Size = new Size(236, 23);
            txtGameTitle.TabIndex = 1;
            txtGameTitle.TextChanged += txtcustomername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 53);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Quantity";
            label2.Click += label2_Click;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(27, 199);
            btnCalc.Margin = new Padding(2);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(78, 42);
            btnCalc.TabIndex = 3;
            btnCalc.Text = "&Calculate Total Price";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(146, 199);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(78, 42);
            btnReset.TabIndex = 4;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(268, 199);
            btnQuit.Margin = new Padding(2);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(78, 42);
            btnQuit.TabIndex = 5;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // PriceOut
            // 
            PriceOut.AccessibleName = "";
            PriceOut.FormattingEnabled = true;
            PriceOut.ItemHeight = 15;
            PriceOut.Location = new Point(27, 92);
            PriceOut.Margin = new Padding(2);
            PriceOut.Name = "PriceOut";
            PriceOut.Size = new Size(321, 79);
            PriceOut.TabIndex = 7;
            PriceOut.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 270);
            Controls.Add(PriceOut);
            Controls.Add(btnQuit);
            Controls.Add(btnReset);
            Controls.Add(btnCalc);
            Controls.Add(label2);
            Controls.Add(txtGameTitle);
            Controls.Add(label1);
            Controls.Add(txtQuantity);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Tanmay-Das Video Game 4";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuantity;
        private Label label1;
        private TextBox txtGameTitle;
        private Label label2;
        private Button btnCalc;
        private Button btnReset;
        private Button btnQuit;
        private ListBox PriceOut;
    }
}
