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
            txtnumwidgets = new TextBox();
            label1 = new Label();
            txtcustomername = new TextBox();
            label2 = new Label();
            btnCalc = new Button();
            btnReset = new Button();
            btnQuit = new Button();
            PriceOut = new ListBox();
            SuspendLayout();
            // 
            // txtnumwidgets
            // 
            txtnumwidgets.Location = new Point(158, 83);
            txtnumwidgets.Name = "txtnumwidgets";
            txtnumwidgets.Size = new Size(77, 31);
            txtnumwidgets.TabIndex = 0;
            txtnumwidgets.TextChanged += txtnumwidgets_TextChanged;
            txtnumwidgets.Enter += txtnumwidgets_Enter;
            txtnumwidgets.Leave += txtnumwidgets_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 40);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Game Title";
            label1.Click += label1_Click;
            // 
            // txtcustomername
            // 
            txtcustomername.Location = new Point(158, 37);
            txtcustomername.Name = "txtcustomername";
            txtcustomername.Size = new Size(336, 31);
            txtcustomername.TabIndex = 2;
            txtcustomername.TextChanged += txtcustomername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 89);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 2;
            label2.Text = "Quantity";
            label2.Click += label2_Click;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(39, 332);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(111, 70);
            btnCalc.TabIndex = 3;
            btnCalc.Text = "&Calculate Total Price";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(209, 332);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(111, 70);
            btnReset.TabIndex = 4;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(383, 332);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(111, 70);
            btnQuit.TabIndex = 5;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // PriceOut
            // 
            PriceOut.AccessibleName = "";
            PriceOut.FormattingEnabled = true;
            PriceOut.ItemHeight = 25;
            PriceOut.Location = new Point(39, 153);
            PriceOut.Name = "PriceOut";
            PriceOut.Size = new Size(457, 129);
            PriceOut.TabIndex = 7;
            PriceOut.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 450);
            Controls.Add(PriceOut);
            Controls.Add(btnQuit);
            Controls.Add(btnReset);
            Controls.Add(btnCalc);
            Controls.Add(label2);
            Controls.Add(txtcustomername);
            Controls.Add(label1);
            Controls.Add(txtnumwidgets);
            Name = "Form1";
            Text = "Tanmay-Das Video Game 4";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnumwidgets;
        private Label label1;
        private TextBox txtcustomername;
        private Label label2;
        private Button btnCalc;
        private Button btnReset;
        private Button btnQuit;
        private ListBox PriceOut;
    }
}
