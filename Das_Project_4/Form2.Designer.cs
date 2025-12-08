namespace Das_Project_4
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnSaveReturn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPricePlatformer = new TextBox();
            txtPriceFPS = new TextBox();
            txtPricePuzzle = new TextBox();
            lblErrorMsg = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 27);
            label1.Name = "label1";
            label1.Size = new Size(260, 24);
            label1.TabIndex = 0;
            label1.Text = "Video Game Price Settings";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // btnSaveReturn
            // 
            btnSaveReturn.Location = new Point(80, 321);
            btnSaveReturn.Name = "btnSaveReturn";
            btnSaveReturn.Size = new Size(132, 48);
            btnSaveReturn.TabIndex = 1;
            btnSaveReturn.Text = "&Save && Return";
            btnSaveReturn.UseVisualStyleBackColor = true;
            btnSaveReturn.Click += btnSaveReturn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            label2.Location = new Point(37, 91);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 2;
            label2.Text = "Platformer";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            label3.Location = new Point(89, 146);
            label3.Name = "label3";
            label3.Size = new Size(37, 21);
            label3.TabIndex = 3;
            label3.Text = "FPS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            label4.Location = new Point(70, 201);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 4;
            label4.Text = "Puzzle";
            // 
            // txtPricePlatformer
            // 
            txtPricePlatformer.Location = new Point(131, 93);
            txtPricePlatformer.Name = "txtPricePlatformer";
            txtPricePlatformer.Size = new Size(112, 23);
            txtPricePlatformer.TabIndex = 5;
            // 
            // txtPriceFPS
            // 
            txtPriceFPS.Location = new Point(131, 148);
            txtPriceFPS.Name = "txtPriceFPS";
            txtPriceFPS.Size = new Size(112, 23);
            txtPriceFPS.TabIndex = 6;
            // 
            // txtPricePuzzle
            // 
            txtPricePuzzle.Location = new Point(131, 204);
            txtPricePuzzle.Name = "txtPricePuzzle";
            txtPricePuzzle.Size = new Size(112, 23);
            txtPricePuzzle.TabIndex = 7;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(12, 246);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(278, 59);
            lblErrorMsg.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 395);
            Controls.Add(lblErrorMsg);
            Controls.Add(txtPricePuzzle);
            Controls.Add(txtPriceFPS);
            Controls.Add(txtPricePlatformer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSaveReturn);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Tanmay-Das Video Game 4 Settings Form";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSaveReturn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblErrorMsg;
        internal TextBox txtPricePlatformer;
        internal TextBox txtPriceFPS;
        internal TextBox txtPricePuzzle;
    }
}