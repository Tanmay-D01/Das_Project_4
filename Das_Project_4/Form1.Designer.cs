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
            lstOut = new ListBox();
            rdoPlatformer = new RadioButton();
            rdoFPS = new RadioButton();
            rdoPuzzle = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(109, 167);
            txtQuantity.Margin = new Padding(2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(55, 23);
            txtQuantity.TabIndex = 2;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            txtQuantity.Enter += txtQuantity_Enter;
            txtQuantity.Leave += txtQuantity_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 141);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Game Title";
            label1.Click += label1_Click;
            // 
            // txtGameTitle
            // 
            txtGameTitle.Location = new Point(109, 139);
            txtGameTitle.Margin = new Padding(2);
            txtGameTitle.Name = "txtGameTitle";
            txtGameTitle.Size = new Size(236, 23);
            txtGameTitle.TabIndex = 1;
            txtGameTitle.TextChanged += txtGameTitle_TextChanged;
            txtGameTitle.Enter += txtGameTitle_Enter;
            txtGameTitle.Leave += txtGameTitle_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 170);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Quantity";
            label2.Click += label2_Click;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(26, 366);
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
            btnReset.Location = new Point(145, 366);
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
            btnQuit.Location = new Point(267, 366);
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
            lstOut.Location = new Point(26, 226);
            lstOut.Margin = new Padding(2);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(321, 124);
            lstOut.TabIndex = 7;
            lstOut.TabStop = false;
            // 
            // rdoPlatformer
            // 
            rdoPlatformer.AutoSize = true;
            rdoPlatformer.Location = new Point(13, 38);
            rdoPlatformer.Name = "rdoPlatformer";
            rdoPlatformer.Size = new Size(81, 19);
            rdoPlatformer.TabIndex = 8;
            rdoPlatformer.TabStop = true;
            rdoPlatformer.Text = "Platformer\n";
            rdoPlatformer.UseVisualStyleBackColor = true;
            rdoPlatformer.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdoFPS
            // 
            rdoFPS.AutoSize = true;
            rdoFPS.Location = new Point(138, 38);
            rdoFPS.Name = "rdoFPS";
            rdoFPS.Size = new Size(44, 19);
            rdoFPS.TabIndex = 9;
            rdoFPS.TabStop = true;
            rdoFPS.Text = "FPS";
            rdoFPS.UseVisualStyleBackColor = true;
            rdoFPS.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdoPuzzle
            // 
            rdoPuzzle.AutoSize = true;
            rdoPuzzle.Location = new Point(247, 38);
            rdoPuzzle.Name = "rdoPuzzle";
            rdoPuzzle.Size = new Size(58, 19);
            rdoPuzzle.TabIndex = 10;
            rdoPuzzle.TabStop = true;
            rdoPuzzle.Text = "Puzzle";
            rdoPuzzle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoPuzzle);
            groupBox1.Controls.Add(rdoPlatformer);
            groupBox1.Controls.Add(rdoFPS);
            groupBox1.Location = new Point(27, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 85);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generes";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 435);
            Controls.Add(groupBox1);
            Controls.Add(lstOut);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private ListBox lstOut;
        private RadioButton rdoPlatformer;
        private RadioButton rdoFPS;
        private RadioButton rdoPuzzle;
        private GroupBox groupBox1;
    }
}
