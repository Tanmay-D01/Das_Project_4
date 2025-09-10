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
            lstOut = new ListBox();
            SuspendLayout();
            // 
            // txtnumwidgets
            // 
            txtnumwidgets.Location = new Point(209, 40);
            txtnumwidgets.Name = "txtnumwidgets";
            txtnumwidgets.Size = new Size(150, 31);
            txtnumwidgets.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 40);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 1;
            label1.Text = "Text 1";
            label1.Click += label1_Click;
            // 
            // txtcustomername
            // 
            txtcustomername.Location = new Point(209, 86);
            txtcustomername.Name = "txtcustomername";
            txtcustomername.Size = new Size(150, 31);
            txtcustomername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 86);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 3;
            label2.Text = "Text 2";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(38, 332);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(112, 70);
            btnCalc.TabIndex = 4;
            btnCalc.Text = "Calculate Total";
            btnCalc.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(209, 332);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 70);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(383, 332);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(112, 70);
            btnQuit.TabIndex = 6;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lstOut
            // 
            lstOut.AccessibleName = "";
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 25;
            lstOut.Location = new Point(38, 154);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(457, 129);
            lstOut.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 450);
            Controls.Add(lstOut);
            Controls.Add(btnQuit);
            Controls.Add(btnReset);
            Controls.Add(btnCalc);
            Controls.Add(label2);
            Controls.Add(txtcustomername);
            Controls.Add(label1);
            Controls.Add(txtnumwidgets);
            Name = "Form1";
            Text = "Form1";
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
        private ListBox lstOut;
    }
}
