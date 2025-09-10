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
            txtnumwidgets.Location = new Point(146, 56);
            txtnumwidgets.Margin = new Padding(2);
            txtnumwidgets.Name = "txtnumwidgets";
            txtnumwidgets.Size = new Size(137, 23);
            txtnumwidgets.TabIndex = 0;
            txtnumwidgets.TextChanged += txtnumwidgets_TextChanged;
            txtnumwidgets.Enter += txtnumwidgets_Enter;
            txtnumwidgets.Leave += txtnumwidgets_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            label1.Click += label1_Click;
            // 
            // txtcustomername
            // 
            txtcustomername.Location = new Point(146, 24);
            txtcustomername.Margin = new Padding(2);
            txtcustomername.Name = "txtcustomername";
            txtcustomername.Size = new Size(137, 23);
            txtcustomername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 59);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 2;
            label2.Text = "Number of Widgets";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(27, 199);
            btnCalc.Margin = new Padding(2);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(78, 42);
            btnCalc.TabIndex = 3;
            btnCalc.Text = "&Calculate Total";
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
            // lstOut
            // 
            lstOut.AccessibleName = "";
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(27, 92);
            lstOut.Margin = new Padding(2);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(321, 79);
            lstOut.TabIndex = 7;
            lstOut.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 270);
            Controls.Add(lstOut);
            Controls.Add(btnQuit);
            Controls.Add(btnReset);
            Controls.Add(btnCalc);
            Controls.Add(label2);
            Controls.Add(txtcustomername);
            Controls.Add(label1);
            Controls.Add(txtnumwidgets);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Tanmay-Das Form 1";
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
        private ListBox lstOut;
    }
}
