namespace BlueberryCalculator
{
    partial class CalcForm
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
            this.textBoxExpression = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonNegate = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonCloseParenthesis = new System.Windows.Forms.Button();
            this.buttonOpenParenthesis = new System.Windows.Forms.Button();
            this.buttonMemoryRecall = new System.Windows.Forms.Button();
            this.buttonMemoryAdd = new System.Windows.Forms.Button();
            this.buttonMemoryClear = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxExpression
            // 
            this.textBoxExpression.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxExpression.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExpression.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxExpression.Location = new System.Drawing.Point(29, 27);
            this.textBoxExpression.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxExpression.MaxLength = 66000;
            this.textBoxExpression.Multiline = true;
            this.textBoxExpression.Name = "textBoxExpression";
            this.textBoxExpression.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxExpression.Size = new System.Drawing.Size(314, 102);
            this.textBoxExpression.TabIndex = 0;
            this.textBoxExpression.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxResult
            // 
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Location = new System.Drawing.Point(29, 129);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxResult.MaxLength = 66000;
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(314, 70);
            this.textBoxResult.TabIndex = 1;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonZero
            // 
            this.buttonZero.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonZero.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZero.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonZero.Location = new System.Drawing.Point(109, 499);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(74, 49);
            this.buttonZero.TabIndex = 3;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = false;
            // 
            // buttonNegate
            // 
            this.buttonNegate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonNegate.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonNegate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNegate.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonNegate.Location = new System.Drawing.Point(29, 499);
            this.buttonNegate.Name = "buttonNegate";
            this.buttonNegate.Size = new System.Drawing.Size(74, 49);
            this.buttonNegate.TabIndex = 4;
            this.buttonNegate.Text = "±";
            this.buttonNegate.UseVisualStyleBackColor = false;
            this.buttonNegate.Click += new System.EventHandler(this.buttonNegate_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonMod.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMod.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.buttonMod.Location = new System.Drawing.Point(189, 500);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(74, 49);
            this.buttonMod.TabIndex = 5;
            this.buttonMod.Text = "mod";
            this.buttonMod.UseVisualStyleBackColor = false;
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.Indigo;
            this.buttonEqual.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEqual.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonEqual.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonEqual.Location = new System.Drawing.Point(269, 500);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(74, 49);
            this.buttonEqual.TabIndex = 6;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonOne.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOne.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonOne.Location = new System.Drawing.Point(29, 444);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(74, 49);
            this.buttonOne.TabIndex = 7;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            // 
            // buttonTwo
            // 
            this.buttonTwo.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonTwo.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTwo.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonTwo.Location = new System.Drawing.Point(109, 444);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(74, 49);
            this.buttonTwo.TabIndex = 8;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = false;
            // 
            // buttonThree
            // 
            this.buttonThree.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonThree.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThree.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonThree.Location = new System.Drawing.Point(189, 445);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(74, 49);
            this.buttonThree.TabIndex = 9;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = false;
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonPlus.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonPlus.Location = new System.Drawing.Point(269, 444);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(74, 49);
            this.buttonPlus.TabIndex = 10;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            // 
            // buttonFour
            // 
            this.buttonFour.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonFour.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFour.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonFour.Location = new System.Drawing.Point(29, 389);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(74, 49);
            this.buttonFour.TabIndex = 11;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            // 
            // buttonFive
            // 
            this.buttonFive.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonFive.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFive.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonFive.Location = new System.Drawing.Point(109, 389);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(74, 49);
            this.buttonFive.TabIndex = 12;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = false;
            // 
            // buttonSix
            // 
            this.buttonSix.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonSix.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSix.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonSix.Location = new System.Drawing.Point(189, 389);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(74, 49);
            this.buttonSix.TabIndex = 13;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonMinus.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonMinus.Location = new System.Drawing.Point(269, 389);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(74, 49);
            this.buttonMinus.TabIndex = 14;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            // 
            // buttonSeven
            // 
            this.buttonSeven.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonSeven.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeven.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonSeven.Location = new System.Drawing.Point(29, 334);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(74, 49);
            this.buttonSeven.TabIndex = 15;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            // 
            // buttonEight
            // 
            this.buttonEight.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonEight.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEight.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonEight.Location = new System.Drawing.Point(109, 334);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(74, 49);
            this.buttonEight.TabIndex = 16;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            // 
            // buttonNine
            // 
            this.buttonNine.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonNine.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNine.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonNine.Location = new System.Drawing.Point(189, 334);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(74, 49);
            this.buttonNine.TabIndex = 17;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = false;
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonMultiply.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiply.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonMultiply.Location = new System.Drawing.Point(269, 334);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(74, 49);
            this.buttonMultiply.TabIndex = 18;
            this.buttonMultiply.Text = "×";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonDivide.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivide.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonDivide.Location = new System.Drawing.Point(269, 279);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(74, 49);
            this.buttonDivide.TabIndex = 19;
            this.buttonDivide.Text = "÷";
            this.buttonDivide.UseVisualStyleBackColor = false;
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonBackspace.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackspace.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonBackspace.Location = new System.Drawing.Point(29, 278);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(74, 49);
            this.buttonBackspace.TabIndex = 20;
            this.buttonBackspace.Text = "⌫";
            this.buttonBackspace.UseVisualStyleBackColor = false;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // buttonCloseParenthesis
            // 
            this.buttonCloseParenthesis.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCloseParenthesis.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCloseParenthesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseParenthesis.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.buttonCloseParenthesis.Location = new System.Drawing.Point(189, 279);
            this.buttonCloseParenthesis.Name = "buttonCloseParenthesis";
            this.buttonCloseParenthesis.Size = new System.Drawing.Size(74, 49);
            this.buttonCloseParenthesis.TabIndex = 21;
            this.buttonCloseParenthesis.Text = ")";
            this.buttonCloseParenthesis.UseVisualStyleBackColor = false;
            // 
            // buttonOpenParenthesis
            // 
            this.buttonOpenParenthesis.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonOpenParenthesis.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonOpenParenthesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenParenthesis.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.buttonOpenParenthesis.Location = new System.Drawing.Point(109, 279);
            this.buttonOpenParenthesis.Name = "buttonOpenParenthesis";
            this.buttonOpenParenthesis.Size = new System.Drawing.Size(74, 49);
            this.buttonOpenParenthesis.TabIndex = 22;
            this.buttonOpenParenthesis.Text = "(";
            this.buttonOpenParenthesis.UseVisualStyleBackColor = false;
            // 
            // buttonMemoryRecall
            // 
            this.buttonMemoryRecall.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonMemoryRecall.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonMemoryRecall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMemoryRecall.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonMemoryRecall.Location = new System.Drawing.Point(109, 230);
            this.buttonMemoryRecall.Name = "buttonMemoryRecall";
            this.buttonMemoryRecall.Size = new System.Drawing.Size(74, 37);
            this.buttonMemoryRecall.TabIndex = 23;
            this.buttonMemoryRecall.Text = "MR";
            this.buttonMemoryRecall.UseVisualStyleBackColor = false;
            this.buttonMemoryRecall.Click += new System.EventHandler(this.buttonMemoryRecall_Click);
            // 
            // buttonMemoryAdd
            // 
            this.buttonMemoryAdd.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonMemoryAdd.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonMemoryAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMemoryAdd.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonMemoryAdd.Location = new System.Drawing.Point(189, 230);
            this.buttonMemoryAdd.Name = "buttonMemoryAdd";
            this.buttonMemoryAdd.Size = new System.Drawing.Size(74, 37);
            this.buttonMemoryAdd.TabIndex = 24;
            this.buttonMemoryAdd.Text = "M+";
            this.buttonMemoryAdd.UseVisualStyleBackColor = false;
            this.buttonMemoryAdd.Click += new System.EventHandler(this.buttonMemoryAdd_Click);
            // 
            // buttonMemoryClear
            // 
            this.buttonMemoryClear.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonMemoryClear.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonMemoryClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMemoryClear.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonMemoryClear.Location = new System.Drawing.Point(269, 230);
            this.buttonMemoryClear.Name = "buttonMemoryClear";
            this.buttonMemoryClear.Size = new System.Drawing.Size(74, 37);
            this.buttonMemoryClear.TabIndex = 25;
            this.buttonMemoryClear.Text = "MC";
            this.buttonMemoryClear.UseVisualStyleBackColor = false;
            this.buttonMemoryClear.Click += new System.EventHandler(this.buttonMemoryClear_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.buttonClear.Location = new System.Drawing.Point(29, 230);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(74, 37);
            this.buttonClear.TabIndex = 26;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(373, 577);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonMemoryClear);
            this.Controls.Add(this.buttonMemoryAdd);
            this.Controls.Add(this.buttonMemoryRecall);
            this.Controls.Add(this.buttonOpenParenthesis);
            this.Controls.Add(this.buttonCloseParenthesis);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.buttonNegate);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxExpression);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "CalcForm";
            this.Text = "BlueberriesCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxExpression;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonNegate;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonCloseParenthesis;
        private System.Windows.Forms.Button buttonOpenParenthesis;
        private System.Windows.Forms.Button buttonMemoryRecall;
        private System.Windows.Forms.Button buttonMemoryAdd;
        private System.Windows.Forms.Button buttonMemoryClear;
        private System.Windows.Forms.Button buttonClear;
    }
}