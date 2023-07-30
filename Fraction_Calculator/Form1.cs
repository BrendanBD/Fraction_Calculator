using Microsoft.VisualBasic.Devices;
using System.Diagnostics.Eventing.Reader;

namespace Fraction_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtFirstTop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) // check if the key pressed is a digit
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtFirstBottom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtSecondTop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtSecondBottom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtResultTop_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPerform_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstTop.Text) ||
                string.IsNullOrEmpty(txtFirstBottom.Text) ||
                string.IsNullOrEmpty(txtSecondTop.Text) ||
                string.IsNullOrEmpty(txtSecondBottom.Text)) //make sure all text boxes are filledto avoid error in operation later
            { MessageBox.Show("Please fill all the text boxes!", "Error!", MessageBoxButtons.OK); }
            else // if all text is filledin proceed to operation
            {
                int topFirst = int.Parse(txtFirstTop.Text); 
                int bottomFirst = int.Parse(txtFirstBottom.Text);
                int topSecond = int.Parse(txtSecondTop.Text);
                int bottomSecond = int.Parse(txtSecondBottom.Text);
                Fraction first = new Fraction(topFirst, bottomFirst);
                Fraction second = new Fraction(topSecond, bottomSecond);
                Fraction result = new Fraction();
                if (rbtnDivide.Checked) // check what operation to perform
                {
                    result = Fraction.Divide(first, second);
                }
                else if (rbtnMultiply.Checked)
                {
                    result = Fraction.Multiply(first, second);
                }
                else if (rbtnSubtract.Checked)
                {
                    result = Fraction.Subtract(first, second);
                }
                else if (rbtnPlus.Checked)
                {
                    result = Fraction.Add(first, second);
                }
                else // if no bvutton is checked then show error box
                {
                    MessageBox.Show("Please Select a operation!", "Error!", MessageBoxButtons.OK);
                }
                // fill the result boxes
                txtResultTop.Text = result.Numerator.ToString();
                txtResultBottom.Text = result.Denominator.ToString();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}