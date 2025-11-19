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
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(156, 278);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(77, 31);
            txtQuantity.TabIndex = 6;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            txtQuantity.Enter += txtQuantity_Enter;
            txtQuantity.Leave += txtQuantity_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 235);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Game Title";
            label1.Click += label1_Click;
            // 
            // txtGameTitle
            // 
            txtGameTitle.Location = new Point(156, 232);
            txtGameTitle.Name = "txtGameTitle";
            txtGameTitle.Size = new Size(335, 31);
            txtGameTitle.TabIndex = 5;
            txtGameTitle.TextChanged += txtGameTitle_TextChanged;
            txtGameTitle.Enter += txtGameTitle_Enter;
            txtGameTitle.Leave += txtGameTitle_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 283);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 2;
            label2.Text = "Quantity";
            label2.Click += label2_Click;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(37, 610);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(111, 70);
            btnCalc.TabIndex = 8;
            btnCalc.Text = "&Calculate Total Price";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(207, 610);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(111, 70);
            btnReset.TabIndex = 9;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(381, 610);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(111, 70);
            btnQuit.TabIndex = 10;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lstOut
            // 
            lstOut.AccessibleName = "";
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 25;
            lstOut.Location = new Point(37, 377);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(457, 204);
            lstOut.TabIndex = 7;
            lstOut.TabStop = false;
            // 
            // rdoPlatformer
            // 
            rdoPlatformer.AutoSize = true;
            rdoPlatformer.Location = new Point(19, 63);
            rdoPlatformer.Margin = new Padding(4, 5, 4, 5);
            rdoPlatformer.Name = "rdoPlatformer";
            rdoPlatformer.Size = new Size(120, 29);
            rdoPlatformer.TabIndex = 2;
            rdoPlatformer.TabStop = true;
            rdoPlatformer.Text = "Platformer\n";
            rdoPlatformer.UseVisualStyleBackColor = true;
            rdoPlatformer.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdoFPS
            // 
            rdoFPS.AutoSize = true;
            rdoFPS.Location = new Point(197, 63);
            rdoFPS.Margin = new Padding(4, 5, 4, 5);
            rdoFPS.Name = "rdoFPS";
            rdoFPS.Size = new Size(66, 29);
            rdoFPS.TabIndex = 3;
            rdoFPS.TabStop = true;
            rdoFPS.Text = "FPS";
            rdoFPS.UseVisualStyleBackColor = true;
            rdoFPS.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdoPuzzle
            // 
            rdoPuzzle.AutoSize = true;
            rdoPuzzle.Location = new Point(353, 63);
            rdoPuzzle.Margin = new Padding(4, 5, 4, 5);
            rdoPuzzle.Name = "rdoPuzzle";
            rdoPuzzle.Size = new Size(86, 29);
            rdoPuzzle.TabIndex = 4;
            rdoPuzzle.TabStop = true;
            rdoPuzzle.Text = "Puzzle";
            rdoPuzzle.UseVisualStyleBackColor = true;
            rdoPuzzle.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoPuzzle);
            groupBox1.Controls.Add(rdoPlatformer);
            groupBox1.Controls.Add(rdoFPS);
            groupBox1.Location = new Point(39, 43);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(454, 142);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generes";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "GameTransaction";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 725);
            Controls.Add(groupBox1);
            Controls.Add(lstOut);
            Controls.Add(btnQuit);
            Controls.Add(btnReset);
            Controls.Add(btnCalc);
            Controls.Add(label2);
            Controls.Add(txtGameTitle);
            Controls.Add(label1);
            Controls.Add(txtQuantity);
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
        private OpenFileDialog openFileDialog1;
    }
}
