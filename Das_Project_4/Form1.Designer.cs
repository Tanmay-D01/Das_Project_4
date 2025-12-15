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
            menuStrip1 = new MenuStrip();
            mnuSettings = new ToolStripMenuItem();
            mnuDisplayLog_Click = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(129, 241);
            txtQuantity.Margin = new Padding(2, 3, 2, 3);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(62, 27);
            txtQuantity.TabIndex = 6;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            txtQuantity.Enter += txtQuantity_Enter;
            txtQuantity.Leave += txtQuantity_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 208);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Game Title";
            label1.Click += label1_Click;
            // 
            // txtGameTitle
            // 
            txtGameTitle.Location = new Point(129, 204);
            txtGameTitle.Margin = new Padding(2, 3, 2, 3);
            txtGameTitle.Name = "txtGameTitle";
            txtGameTitle.Size = new Size(267, 27);
            txtGameTitle.TabIndex = 5;
            txtGameTitle.TextChanged += txtGameTitle_TextChanged;
            txtGameTitle.Enter += txtGameTitle_Enter;
            txtGameTitle.Leave += txtGameTitle_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 245);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 2;
            label2.Text = "Quantity";
            label2.Click += label2_Click;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(33, 507);
            btnCalc.Margin = new Padding(2, 3, 2, 3);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(89, 56);
            btnCalc.TabIndex = 8;
            btnCalc.Text = "&Calculate Total Price";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(170, 507);
            btnReset.Margin = new Padding(2, 3, 2, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(89, 56);
            btnReset.TabIndex = 9;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(307, 507);
            btnQuit.Margin = new Padding(2, 3, 2, 3);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(89, 56);
            btnQuit.TabIndex = 10;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lstOut
            // 
            lstOut.AccessibleName = "";
            lstOut.FormattingEnabled = true;
            lstOut.Location = new Point(33, 320);
            lstOut.Margin = new Padding(2, 3, 2, 3);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(363, 164);
            lstOut.TabIndex = 7;
            lstOut.TabStop = false;
            // 
            // rdoPlatformer
            // 
            rdoPlatformer.AutoSize = true;
            rdoPlatformer.Location = new Point(15, 51);
            rdoPlatformer.Margin = new Padding(3, 4, 3, 4);
            rdoPlatformer.Name = "rdoPlatformer";
            rdoPlatformer.Size = new Size(100, 24);
            rdoPlatformer.TabIndex = 2;
            rdoPlatformer.TabStop = true;
            rdoPlatformer.Text = "Platformer\n";
            rdoPlatformer.UseVisualStyleBackColor = true;
            rdoPlatformer.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdoFPS
            // 
            rdoFPS.AutoSize = true;
            rdoFPS.Location = new Point(158, 51);
            rdoFPS.Margin = new Padding(3, 4, 3, 4);
            rdoFPS.Name = "rdoFPS";
            rdoFPS.Size = new Size(53, 24);
            rdoFPS.TabIndex = 3;
            rdoFPS.TabStop = true;
            rdoFPS.Text = "FPS";
            rdoFPS.UseVisualStyleBackColor = true;
            rdoFPS.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdoPuzzle
            // 
            rdoPuzzle.AutoSize = true;
            rdoPuzzle.Location = new Point(282, 51);
            rdoPuzzle.Margin = new Padding(3, 4, 3, 4);
            rdoPuzzle.Name = "rdoPuzzle";
            rdoPuzzle.Size = new Size(72, 24);
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
            groupBox1.Location = new Point(33, 53);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(363, 113);
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
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuSettings, mnuDisplayLog_Click });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(433, 30);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuSettings
            // 
            mnuSettings.Name = "mnuSettings";
            mnuSettings.Size = new Size(76, 24);
            mnuSettings.Text = "&Settings";
            mnuSettings.Click += mnuSettings_Click;
            // 
            // mnuDisplayLog_Click
            // 
            mnuDisplayLog_Click.Name = "mnuDisplayLog_Click";
            mnuDisplayLog_Click.Size = new Size(128, 24);
            mnuDisplayLog_Click.Text = "Display Log File";
            mnuDisplayLog_Click.ToolTipText = "This will display...";
            mnuDisplayLog_Click.Click += displayLogFileToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 597);
            Controls.Add(groupBox1);
            Controls.Add(lstOut);
            Controls.Add(btnQuit);
            Controls.Add(btnReset);
            Controls.Add(btnCalc);
            Controls.Add(label2);
            Controls.Add(txtGameTitle);
            Controls.Add(label1);
            Controls.Add(txtQuantity);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "Tanmay-Das Video Game 4";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuSettings;
        private ToolStripMenuItem mnuDisplayLog_Click;
    }
}
