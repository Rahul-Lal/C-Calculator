namespace Calculator
{
    partial class frmMain
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.gbxNumerals = new System.Windows.Forms.GroupBox();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.gbxFunctions = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnModulo = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnExponent = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.gbxTrigonometry = new System.Windows.Forms.GroupBox();
            this.btnTangent = new System.Windows.Forms.Button();
            this.btnCosine = new System.Windows.Forms.Button();
            this.btnSine = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxNumerals.SuspendLayout();
            this.gbxFunctions.SuspendLayout();
            this.gbxTrigonometry.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.ControlText;
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutput.Font = new System.Drawing.Font("Nirmala UI Semilight", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtOutput.Location = new System.Drawing.Point(12, 21);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(782, 57);
            this.txtOutput.TabIndex = 0;
            // 
            // gbxNumerals
            // 
            this.gbxNumerals.Controls.Add(this.btnDecimal);
            this.gbxNumerals.Controls.Add(this.btnFour);
            this.gbxNumerals.Controls.Add(this.btnFive);
            this.gbxNumerals.Controls.Add(this.btnSix);
            this.gbxNumerals.Controls.Add(this.btnSeven);
            this.gbxNumerals.Controls.Add(this.btnEight);
            this.gbxNumerals.Controls.Add(this.btnNine);
            this.gbxNumerals.Controls.Add(this.btnThree);
            this.gbxNumerals.Controls.Add(this.btnTwo);
            this.gbxNumerals.Controls.Add(this.btnOne);
            this.gbxNumerals.Controls.Add(this.btnZero);
            this.gbxNumerals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNumerals.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbxNumerals.Location = new System.Drawing.Point(12, 93);
            this.gbxNumerals.Name = "gbxNumerals";
            this.gbxNumerals.Size = new System.Drawing.Size(334, 251);
            this.gbxNumerals.TabIndex = 1;
            this.gbxNumerals.TabStop = false;
            this.gbxNumerals.Text = "Numerals";
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDecimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDecimal.FlatAppearance.BorderSize = 0;
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(114, 187);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(100, 50);
            this.btnDecimal.TabIndex = 12;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFour.FlatAppearance.BorderSize = 0;
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(8, 75);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(100, 50);
            this.btnFour.TabIndex = 11;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFive.FlatAppearance.BorderSize = 0;
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(114, 75);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(100, 50);
            this.btnFive.TabIndex = 10;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSix.FlatAppearance.BorderSize = 0;
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(220, 75);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(100, 50);
            this.btnSix.TabIndex = 9;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSeven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSeven.FlatAppearance.BorderSize = 0;
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(8, 19);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(100, 50);
            this.btnSeven.TabIndex = 8;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEight.FlatAppearance.BorderSize = 0;
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(114, 19);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(100, 50);
            this.btnEight.TabIndex = 7;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNine.FlatAppearance.BorderSize = 0;
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(220, 19);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(100, 50);
            this.btnNine.TabIndex = 6;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThree.FlatAppearance.BorderSize = 0;
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(220, 131);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(100, 50);
            this.btnThree.TabIndex = 5;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTwo.FlatAppearance.BorderSize = 0;
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(114, 131);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(100, 50);
            this.btnTwo.TabIndex = 4;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOne.FlatAppearance.BorderSize = 0;
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(8, 131);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(100, 50);
            this.btnOne.TabIndex = 3;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(8, 187);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(100, 50);
            this.btnZero.TabIndex = 0;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClearEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearEntry.FlatAppearance.BorderSize = 0;
            this.btnClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEntry.ForeColor = System.Drawing.Color.Firebrick;
            this.btnClearEntry.Location = new System.Drawing.Point(332, 185);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(100, 50);
            this.btnClearEntry.TabIndex = 2;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = false;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClearAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.Firebrick;
            this.btnClearAll.Location = new System.Drawing.Point(226, 185);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(100, 50);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "C";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // gbxFunctions
            // 
            this.gbxFunctions.Controls.Add(this.button1);
            this.gbxFunctions.Controls.Add(this.button2);
            this.gbxFunctions.Controls.Add(this.btnModulo);
            this.gbxFunctions.Controls.Add(this.btnPercent);
            this.gbxFunctions.Controls.Add(this.btnReciprocal);
            this.gbxFunctions.Controls.Add(this.btnExponent);
            this.gbxFunctions.Controls.Add(this.btnSquareRoot);
            this.gbxFunctions.Controls.Add(this.btnPi);
            this.gbxFunctions.Controls.Add(this.btnMultiply);
            this.gbxFunctions.Controls.Add(this.btnDivide);
            this.gbxFunctions.Controls.Add(this.btnSubtract);
            this.gbxFunctions.Controls.Add(this.btnAddition);
            this.gbxFunctions.Controls.Add(this.btnEquals);
            this.gbxFunctions.Controls.Add(this.btnClearAll);
            this.gbxFunctions.Controls.Add(this.btnClearEntry);
            this.gbxFunctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFunctions.ForeColor = System.Drawing.Color.Firebrick;
            this.gbxFunctions.Location = new System.Drawing.Point(352, 93);
            this.gbxFunctions.Name = "gbxFunctions";
            this.gbxFunctions.Size = new System.Drawing.Size(442, 251);
            this.gbxFunctions.TabIndex = 12;
            this.gbxFunctions.TabStop = false;
            this.gbxFunctions.Text = "Functions";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Firebrick;
            this.button1.Location = new System.Drawing.Point(226, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Firebrick;
            this.button2.Location = new System.Drawing.Point(332, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnModulo
            // 
            this.btnModulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModulo.FlatAppearance.BorderSize = 0;
            this.btnModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModulo.ForeColor = System.Drawing.Color.Firebrick;
            this.btnModulo.Location = new System.Drawing.Point(119, 19);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(100, 50);
            this.btnModulo.TabIndex = 17;
            this.btnModulo.Text = "mod";
            this.btnModulo.UseVisualStyleBackColor = false;
            // 
            // btnPercent
            // 
            this.btnPercent.AllowDrop = true;
            this.btnPercent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPercent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPercent.FlatAppearance.BorderSize = 0;
            this.btnPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercent.ForeColor = System.Drawing.Color.Firebrick;
            this.btnPercent.Location = new System.Drawing.Point(13, 19);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(100, 50);
            this.btnPercent.TabIndex = 16;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReciprocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReciprocal.FlatAppearance.BorderSize = 0;
            this.btnReciprocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReciprocal.ForeColor = System.Drawing.Color.Firebrick;
            this.btnReciprocal.Location = new System.Drawing.Point(226, 73);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(100, 50);
            this.btnReciprocal.TabIndex = 15;
            this.btnReciprocal.Text = "1/x";
            this.btnReciprocal.UseVisualStyleBackColor = false;
            this.btnReciprocal.Click += new System.EventHandler(this.btnReciprocal_Click);
            // 
            // btnExponent
            // 
            this.btnExponent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExponent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExponent.FlatAppearance.BorderSize = 0;
            this.btnExponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExponent.Location = new System.Drawing.Point(332, 73);
            this.btnExponent.Name = "btnExponent";
            this.btnExponent.Size = new System.Drawing.Size(100, 50);
            this.btnExponent.TabIndex = 14;
            this.btnExponent.Text = "a^b";
            this.btnExponent.UseVisualStyleBackColor = false;
            this.btnExponent.Click += new System.EventHandler(this.btnExponent_Click);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSquareRoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSquareRoot.FlatAppearance.BorderSize = 0;
            this.btnSquareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquareRoot.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSquareRoot.Location = new System.Drawing.Point(119, 73);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(100, 50);
            this.btnSquareRoot.TabIndex = 13;
            this.btnSquareRoot.Text = "√a";
            this.btnSquareRoot.UseVisualStyleBackColor = false;
            this.btnSquareRoot.Click += new System.EventHandler(this.btnSquareRoot_Click);
            // 
            // btnPi
            // 
            this.btnPi.AllowDrop = true;
            this.btnPi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPi.FlatAppearance.BorderSize = 0;
            this.btnPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPi.ForeColor = System.Drawing.Color.Firebrick;
            this.btnPi.Location = new System.Drawing.Point(13, 73);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(100, 50);
            this.btnPi.TabIndex = 12;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMultiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMultiply.FlatAppearance.BorderSize = 0;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.Color.Firebrick;
            this.btnMultiply.Location = new System.Drawing.Point(226, 129);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(100, 50);
            this.btnMultiply.TabIndex = 11;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDivide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.Color.Firebrick;
            this.btnDivide.Location = new System.Drawing.Point(332, 129);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(100, 50);
            this.btnDivide.TabIndex = 10;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubtract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubtract.FlatAppearance.BorderSize = 0;
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSubtract.Location = new System.Drawing.Point(119, 129);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(100, 50);
            this.btnSubtract.TabIndex = 4;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddition.FlatAppearance.BorderSize = 0;
            this.btnAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddition.ForeColor = System.Drawing.Color.Firebrick;
            this.btnAddition.Location = new System.Drawing.Point(13, 129);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(100, 50);
            this.btnAddition.TabIndex = 3;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = false;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEquals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEquals.FlatAppearance.BorderSize = 0;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.Color.Firebrick;
            this.btnEquals.Location = new System.Drawing.Point(13, 185);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(206, 50);
            this.btnEquals.TabIndex = 0;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // gbxTrigonometry
            // 
            this.gbxTrigonometry.Controls.Add(this.btnTangent);
            this.gbxTrigonometry.Controls.Add(this.btnCosine);
            this.gbxTrigonometry.Controls.Add(this.btnSine);
            this.gbxTrigonometry.Controls.Add(this.button6);
            this.gbxTrigonometry.Controls.Add(this.button7);
            this.gbxTrigonometry.Controls.Add(this.button8);
            this.gbxTrigonometry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTrigonometry.ForeColor = System.Drawing.Color.LimeGreen;
            this.gbxTrigonometry.Location = new System.Drawing.Point(237, 350);
            this.gbxTrigonometry.Name = "gbxTrigonometry";
            this.gbxTrigonometry.Size = new System.Drawing.Size(334, 135);
            this.gbxTrigonometry.TabIndex = 13;
            this.gbxTrigonometry.TabStop = false;
            this.gbxTrigonometry.Text = "Trigonometry";
            // 
            // btnTangent
            // 
            this.btnTangent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTangent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTangent.FlatAppearance.BorderSize = 0;
            this.btnTangent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTangent.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnTangent.Location = new System.Drawing.Point(221, 19);
            this.btnTangent.Name = "btnTangent";
            this.btnTangent.Size = new System.Drawing.Size(100, 50);
            this.btnTangent.TabIndex = 25;
            this.btnTangent.Text = "Tan";
            this.btnTangent.UseVisualStyleBackColor = false;
            // 
            // btnCosine
            // 
            this.btnCosine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCosine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCosine.FlatAppearance.BorderSize = 0;
            this.btnCosine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosine.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnCosine.Location = new System.Drawing.Point(114, 19);
            this.btnCosine.Name = "btnCosine";
            this.btnCosine.Size = new System.Drawing.Size(100, 50);
            this.btnCosine.TabIndex = 24;
            this.btnCosine.Text = "Cos";
            this.btnCosine.UseVisualStyleBackColor = false;
            // 
            // btnSine
            // 
            this.btnSine.AllowDrop = true;
            this.btnSine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSine.FlatAppearance.BorderSize = 0;
            this.btnSine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSine.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSine.Location = new System.Drawing.Point(8, 19);
            this.btnSine.Name = "btnSine";
            this.btnSine.Size = new System.Drawing.Size(100, 50);
            this.btnSine.TabIndex = 23;
            this.btnSine.Text = "Sin";
            this.btnSine.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.LimeGreen;
            this.button6.Location = new System.Drawing.Point(221, 73);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 50);
            this.button6.TabIndex = 22;
            this.button6.Text = "aTan";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.LimeGreen;
            this.button7.Location = new System.Drawing.Point(114, 73);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 50);
            this.button7.TabIndex = 21;
            this.button7.Text = "aCos";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.AllowDrop = true;
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.LimeGreen;
            this.button8.Location = new System.Drawing.Point(8, 73);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 50);
            this.button8.TabIndex = 20;
            this.button8.Text = "aSin";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(808, 498);
            this.Controls.Add(this.gbxTrigonometry);
            this.Controls.Add(this.gbxFunctions);
            this.Controls.Add(this.gbxNumerals);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "C# Calculator";
            this.gbxNumerals.ResumeLayout(false);
            this.gbxFunctions.ResumeLayout(false);
            this.gbxTrigonometry.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.GroupBox gbxNumerals;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.GroupBox gbxFunctions;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnExponent;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbxTrigonometry;
        private System.Windows.Forms.Button btnTangent;
        private System.Windows.Forms.Button btnCosine;
        private System.Windows.Forms.Button btnSine;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    }
}

