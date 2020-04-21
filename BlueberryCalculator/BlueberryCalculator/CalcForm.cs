using AnalaizerClass;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace BlueberryCalculator
{
    public partial class CalcForm : Form
    {
        Stopwatch clickTimeSpan = new Stopwatch();
        int buffer = new Int32();
        public CalcForm()
        {
            InitializeComponent();

            var buttons = new Control[17] {
                buttonZero, buttonOne, buttonTwo, buttonThree, buttonFour, buttonFive,
                buttonSix, buttonSeven, buttonEight, buttonNine, buttonOpenParenthesis,
                buttonCloseParenthesis, buttonDivide, buttonMultiply, buttonMinus,
                buttonPlus, buttonMod
            };


            foreach (Control c in buttons)
            {
                c.Click += InputClick;

            }
        }

        private void InputClick(object sender, EventArgs e)
        {
            if (textBoxExpression != null)
            {
                textBoxExpression.Text += ((Control)sender).Text;
            }
        }

        protected void deleteLastSymbol()
        {
            if (textBoxExpression.Text.EndsWith("mod"))
                textBoxExpression.Text = textBoxExpression.Text.Remove(textBoxExpression.Text.Length - 3, 3);
            else textBoxExpression.Text = textBoxExpression.Text.Remove(textBoxExpression.Text.Length - 1, 1);
            
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBoxExpression.TextLength != 0) deleteLastSymbol();
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls.OfType<TextBox>())
            {
                c.Text = null;
            }
        }

        private void buttonNegate_Click(object sender, EventArgs e)
        {
            if (clickTimeSpan.IsRunning)
            {
                clickTimeSpan.Stop();

                if (clickTimeSpan.ElapsedMilliseconds <= 3000)
                {
                    if (textBoxExpression.TextLength != 0 )
                    {
                        switch(textBoxExpression.Text[textBoxExpression.Text.Length - 1])
                        {
                            case 'm':
                                textBoxExpression.Text = textBoxExpression.Text.Substring(0, textBoxExpression.Text.Length - 1) + "p";
                                break;
                            case 'p':
                                textBoxExpression.Text = textBoxExpression.Text.Substring(0, textBoxExpression.Text.Length - 1) + "m";
                                break;
                            default:
                                textBoxExpression.Text += "m";
                                break;

                        }   
                        /*    
                            textBoxExpression.Text = textBoxExpression.Text.EndsWith("m") ?
                                textBoxExpression.Text.Substring(0, textBoxExpression.Text.Length - 1) + "p"
                                : textBoxExpression.Text.Substring(0, textBoxExpression.Text.Length - 1) + "m";
                        */                
                    }

                    clickTimeSpan = Stopwatch.StartNew();
                }
                else
                {
                    textBoxExpression.Text += "m";
                    clickTimeSpan = Stopwatch.StartNew();
                }
            }
            else
            {
                textBoxExpression.Text += "m";
                clickTimeSpan.Start();
            }
        }

    

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(":P");

            string expression = textBoxExpression.Text.Replace('÷', '/').Replace('×', '*');

            Brain.expression = expression;

            var result = Brain.Estimate();

            textBoxResult.Text = result;
        }
        
        protected override bool ProcessCmdKey(ref Message message, Keys keys)
        {
            switch (keys)
            {
                case Keys.Escape:
                    {
                        this.Close();
                        return true;
                    }
                case Keys.Enter:
                    {
                        buttonEqual_Click(this, null);
                        return true;
                    }
            }
            return base.ProcessCmdKey(ref message, keys);
        }

        private void buttonMemoryRecall_Click(object sender, EventArgs e)
        {
            if (buffer == 0)
                MessageBox.Show("Buffer is empty. Use M+ to add the result to memory");
            else
            {
                textBoxExpression.Text += buffer;
            }

        }

        private void buttonMemoryClear_Click(object sender, EventArgs e)
        {
            buffer = 0;
        }

        private void buttonMemoryAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxResult.Text))
            {
                if (textBoxResult.Text.Contains("Error"))
                    textBoxResult.Text = "Error: cannot be converted to a number";
                else
                {
                    long result;
                    if (long.TryParse(textBoxResult.Text, out result))
                    {
                        buffer = CalcClass.Math.Add(result, buffer);
                    }
                    //Lion's calculation
                    //buffer = MethodAddingTwoNumber(textBoxResult.Text + buffer)
                }
            }
            else
                MessageBox.Show("The field of result is empty. Nothing to add. Memory contained " + buffer);
            // залишати в буфері старе число? тобто якщо пусте поле результату, але
            // є число в буфері, то робити буфер + 0 ????
        }

    }
}
