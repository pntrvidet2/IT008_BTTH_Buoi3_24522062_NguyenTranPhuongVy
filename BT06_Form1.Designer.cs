namespace BT06
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            viewToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pastToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            standardToolStripMenuItem = new ToolStripMenuItem();
            scientificToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            txtDisplay = new TextBox();
            btnBackspace = new Button();
            btnCE = new Button();
            btnC = new Button();
            btnMC = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnDivide = new Button();
            btnSqrt = new Button();
            btnPercent = new Button();
            btnMultiply = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnMR = new Button();
            btnDivX = new Button();
            btnSubstract = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnMS = new Button();
            btnEqual = new Button();
            btnAdd = new Button();
            btnDot = new Button();
            btnPlusMinus = new Button();
            btn0 = new Button();
            btnMPlus = new Button();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { viewToolStripMenuItem, helpToolStripMenuItem, helpToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(332, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyToolStripMenuItem, pastToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(49, 24);
            viewToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(224, 26);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pastToolStripMenuItem
            // 
            pastToolStripMenuItem.Name = "pastToolStripMenuItem";
            pastToolStripMenuItem.Size = new Size(224, 26);
            pastToolStripMenuItem.Text = "Paste";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { standardToolStripMenuItem, scientificToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "View";
            // 
            // standardToolStripMenuItem
            // 
            standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            standardToolStripMenuItem.Size = new Size(224, 26);
            standardToolStripMenuItem.Text = "Standard";
            // 
            // scientificToolStripMenuItem
            // 
            scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            scientificToolStripMenuItem.Size = new Size(224, 26);
            scientificToolStripMenuItem.Text = "Scientific";
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(55, 24);
            helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(224, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font(".VnArial Narrow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(12, 31);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(308, 46);
            txtDisplay.TabIndex = 1;
            txtDisplay.Text = "0.";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btnBackspace
            // 
            btnBackspace.BackColor = SystemColors.ButtonFace;
            btnBackspace.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnBackspace.ForeColor = Color.Red;
            btnBackspace.Location = new Point(64, 107);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(90, 29);
            btnBackspace.TabIndex = 2;
            btnBackspace.Text = "Backspace";
            btnBackspace.UseVisualStyleBackColor = false;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // btnCE
            // 
            btnCE.BackColor = SystemColors.ButtonFace;
            btnCE.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCE.ForeColor = Color.Red;
            btnCE.Location = new Point(160, 107);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(70, 29);
            btnCE.TabIndex = 3;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            btnCE.Click += btnCE_Click;
            // 
            // btnC
            // 
            btnC.BackColor = SystemColors.ButtonFace;
            btnC.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnC.ForeColor = Color.Red;
            btnC.Location = new Point(236, 107);
            btnC.Name = "btnC";
            btnC.Size = new Size(80, 29);
            btnC.TabIndex = 4;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnMC
            // 
            btnMC.BackColor = SystemColors.ButtonFace;
            btnMC.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnMC.ForeColor = Color.Red;
            btnMC.Location = new Point(12, 142);
            btnMC.Name = "btnMC";
            btnMC.Size = new Size(45, 29);
            btnMC.TabIndex = 5;
            btnMC.Text = "MC";
            btnMC.UseVisualStyleBackColor = false;
            btnMC.Click += btnMC_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ButtonFace;
            btn7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn7.ForeColor = Color.Blue;
            btn7.Location = new Point(64, 142);
            btn7.Name = "btn7";
            btn7.Size = new Size(45, 29);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btnNumber_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ButtonFace;
            btn8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn8.ForeColor = Color.Blue;
            btn8.Location = new Point(118, 142);
            btn8.Name = "btn8";
            btn8.Size = new Size(45, 29);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btnNumber_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ButtonFace;
            btn9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn9.ForeColor = Color.Blue;
            btn9.Location = new Point(169, 142);
            btn9.Name = "btn9";
            btn9.Size = new Size(45, 29);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btnNumber_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.ButtonFace;
            btnDivide.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDivide.ForeColor = Color.Red;
            btnDivide.Location = new Point(220, 142);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(45, 29);
            btnDivide.TabIndex = 9;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnOperator_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = SystemColors.ButtonFace;
            btnSqrt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSqrt.ForeColor = Color.FromArgb(0, 0, 192);
            btnSqrt.Location = new Point(271, 142);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(45, 29);
            btnSqrt.TabIndex = 10;
            btnSqrt.Text = "sqrt";
            btnSqrt.UseVisualStyleBackColor = false;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnPercent
            // 
            btnPercent.BackColor = SystemColors.ButtonFace;
            btnPercent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnPercent.ForeColor = Color.FromArgb(0, 0, 192);
            btnPercent.Location = new Point(271, 177);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(45, 29);
            btnPercent.TabIndex = 16;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            btnPercent.Click += btnPercent_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = SystemColors.ButtonFace;
            btnMultiply.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnMultiply.ForeColor = Color.Red;
            btnMultiply.Location = new Point(220, 177);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(45, 29);
            btnMultiply.TabIndex = 15;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnOperator_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ButtonFace;
            btn6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn6.ForeColor = Color.Blue;
            btn6.Location = new Point(169, 177);
            btn6.Name = "btn6";
            btn6.Size = new Size(45, 29);
            btn6.TabIndex = 14;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btnNumber_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ButtonFace;
            btn5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn5.ForeColor = Color.Blue;
            btn5.Location = new Point(118, 177);
            btn5.Name = "btn5";
            btn5.Size = new Size(45, 29);
            btn5.TabIndex = 13;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btnNumber_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ButtonFace;
            btn4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn4.ForeColor = Color.Blue;
            btn4.Location = new Point(64, 177);
            btn4.Name = "btn4";
            btn4.Size = new Size(45, 29);
            btn4.TabIndex = 12;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btnNumber_Click;
            // 
            // btnMR
            // 
            btnMR.BackColor = SystemColors.ButtonFace;
            btnMR.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnMR.ForeColor = Color.Red;
            btnMR.Location = new Point(12, 177);
            btnMR.Name = "btnMR";
            btnMR.Size = new Size(45, 29);
            btnMR.TabIndex = 11;
            btnMR.Text = "MR";
            btnMR.UseVisualStyleBackColor = false;
            btnMR.Click += btnMR_Click;
            // 
            // btnDivX
            // 
            btnDivX.BackColor = SystemColors.ButtonFace;
            btnDivX.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDivX.ForeColor = Color.FromArgb(0, 0, 192);
            btnDivX.Location = new Point(273, 212);
            btnDivX.Name = "btnDivX";
            btnDivX.Size = new Size(45, 29);
            btnDivX.TabIndex = 22;
            btnDivX.Text = "1/x";
            btnDivX.UseVisualStyleBackColor = false;
            btnDivX.Click += btnReciprocal_Click;
            // 
            // btnSubstract
            // 
            btnSubstract.BackColor = SystemColors.ButtonFace;
            btnSubstract.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSubstract.ForeColor = Color.Red;
            btnSubstract.Location = new Point(222, 212);
            btnSubstract.Name = "btnSubstract";
            btnSubstract.Size = new Size(45, 29);
            btnSubstract.TabIndex = 21;
            btnSubstract.Text = "-";
            btnSubstract.UseVisualStyleBackColor = false;
            btnSubstract.Click += btnOperator_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ButtonFace;
            btn3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn3.ForeColor = Color.Blue;
            btn3.Location = new Point(171, 212);
            btn3.Name = "btn3";
            btn3.Size = new Size(45, 29);
            btn3.TabIndex = 20;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btnNumber_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ButtonFace;
            btn2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn2.ForeColor = Color.Blue;
            btn2.Location = new Point(120, 212);
            btn2.Name = "btn2";
            btn2.Size = new Size(45, 29);
            btn2.TabIndex = 19;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btnNumber_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ButtonFace;
            btn1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn1.ForeColor = Color.Blue;
            btn1.Location = new Point(66, 212);
            btn1.Name = "btn1";
            btn1.Size = new Size(45, 29);
            btn1.TabIndex = 18;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btnNumber_Click;
            // 
            // btnMS
            // 
            btnMS.BackColor = SystemColors.ButtonFace;
            btnMS.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnMS.ForeColor = Color.Red;
            btnMS.Location = new Point(14, 212);
            btnMS.Name = "btnMS";
            btnMS.Size = new Size(45, 29);
            btnMS.TabIndex = 17;
            btnMS.Text = "MS";
            btnMS.UseVisualStyleBackColor = false;
            btnMS.Click += btnMS_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = SystemColors.ButtonFace;
            btnEqual.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEqual.ForeColor = Color.Red;
            btnEqual.Location = new Point(273, 247);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(45, 29);
            btnEqual.TabIndex = 28;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ButtonFace;
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Red;
            btnAdd.Location = new Point(222, 247);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(45, 29);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnOperator_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = SystemColors.ButtonFace;
            btnDot.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDot.ForeColor = Color.Blue;
            btnDot.Location = new Point(171, 247);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(45, 29);
            btnDot.TabIndex = 26;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.BackColor = SystemColors.ButtonFace;
            btnPlusMinus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnPlusMinus.ForeColor = Color.Blue;
            btnPlusMinus.Location = new Point(120, 247);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(45, 29);
            btnPlusMinus.TabIndex = 25;
            btnPlusMinus.Text = "+/-";
            btnPlusMinus.UseVisualStyleBackColor = false;
            btnPlusMinus.ClientSizeChanged += btnPlusMinus_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ButtonFace;
            btn0.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn0.ForeColor = Color.Blue;
            btn0.Location = new Point(66, 247);
            btn0.Name = "btn0";
            btn0.Size = new Size(45, 29);
            btn0.TabIndex = 24;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btnNumber_Click;
            // 
            // btnMPlus
            // 
            btnMPlus.BackColor = SystemColors.ButtonFace;
            btnMPlus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnMPlus.ForeColor = Color.Red;
            btnMPlus.Location = new Point(14, 247);
            btnMPlus.Name = "btnMPlus";
            btnMPlus.Size = new Size(45, 29);
            btnMPlus.TabIndex = 23;
            btnMPlus.Text = "M+";
            btnMPlus.UseVisualStyleBackColor = false;
            btnMPlus.Click += btnMPlus_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            textBox1.Location = new Point(19, 109);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(29, 27);
            textBox1.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 303);
            Controls.Add(textBox1);
            Controls.Add(btnEqual);
            Controls.Add(btnAdd);
            Controls.Add(btnDot);
            Controls.Add(btnPlusMinus);
            Controls.Add(btn0);
            Controls.Add(btnMPlus);
            Controls.Add(btnDivX);
            Controls.Add(btnSubstract);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnMS);
            Controls.Add(btnPercent);
            Controls.Add(btnMultiply);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnMR);
            Controls.Add(btnSqrt);
            Controls.Add(btnDivide);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnMC);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(btnBackspace);
            Controls.Add(txtDisplay);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pastToolStripMenuItem;
        private ToolStripMenuItem standardToolStripMenuItem;
        private ToolStripMenuItem scientificToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TextBox txtDisplay;
        private Button btnBackspace;
        private Button btnCE;
        private Button btnC;
        private Button btnMC;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnDivide;
        private Button btnSqrt;
        private Button btnPercent;
        private Button btnMultiply;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnMR;
        private Button btnDivX;
        private Button btnSubstract;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnMS;
        private Button btnEqual;
        private Button btnAdd;
        private Button btnDot;
        private Button btnPlusMinus;
        private Button btn0;
        private Button btnMPlus;
        private TextBox textBox1;
    }
}
