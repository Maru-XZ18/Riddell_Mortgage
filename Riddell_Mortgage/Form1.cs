using System;
using System.Drawing;
using System.Windows.Forms;

namespace MortgageCalculator
{

    public partial class Form1 : Form
    {
        private Control textBoxPrincipal;
        private Control textBoxOtherYears;
        private Control buttonReset;
        private Control buttonCalculate;
        private Control labelMonthlyPayment;
        private Control radioButton15Years;
        private Control radioButton30Years;
        private Control radioButtonOther;
        private ComboBox comboBoxInterestRate;
        private bool radioButton;

        public Form1(Control textBoxPrincipal, Control textBoxOtherYears, Control buttonReset, Control buttonCalculate, Control labelMonthlyPayment, Control radioButton15Years, Control radioButton30Years, Control radioButtonOther, Control v)
        {
            InitializeComponent();
            this.Text = "Dan Hagen : Mortgage Calculator";

            textBoxPrincipal = new TextBox() { Location = new Point(12, 12) };
            textBoxOtherYears = new TextBox() { Location = new Point(12, 62), Visible = false };

            buttonReset = new Button() { Text = "Reset", Location = new Point(12, 112), Width = 75 };
            buttonCalculate = new Button() { Text = "Calculate", Location = new Point(112, 112), Width = 75 };

            labelMonthlyPayment = new Label() { Location = new Point(12, 162) };

            radioButton15Years = new RadioButton() { Text = "15 Years", Location = new Point(12, 212), AutoSize = true };
            radioButton30Years = new RadioButton() { Text = "30 Years", Location = new Point(112, 212), AutoSize = true };
            radioButtonOther = new RadioButton() { Text = "Other", Location = new Point(212, 212), AutoSize = true };

            comboBoxInterestRate = new ComboBox() { Location = new Point(12, 262), Width = 100 };
            for (decimal i = 3.0m; i <= 4.5m; i += 0.1m)
            {
                comboBoxInterestRate.Items.Add(i);
            }

            this.Controls.Add(textBoxPrincipal);
            this.Controls.Add(textBoxOtherYears);
            this.Controls.Add(buttonReset);
            this.Controls.Add(buttonCalculate);
            this.Controls.Add(labelMonthlyPayment);
            this.Controls.Add(radioButton15Years);
            this.Controls.Add(radioButton30Years);
            this.Controls.Add(radioButtonOther);
            this.Controls.Add(comboBoxInterestRate);

            radioButton30Years = v;
            textBoxPrincipal.Focus();
            this.textBoxPrincipal = textBoxPrincipal;
            this.textBoxOtherYears = textBoxOtherYears;
            this.buttonReset = buttonReset;
            this.buttonCalculate = buttonCalculate;
            this.labelMonthlyPayment = labelMonthlyPayment;
            this.radioButton15Years = radioButton15Years;
            this.radioButton30Years = radioButton30Years;
            this.radioButtonOther = radioButtonOther;
        }

        public Form1()
        {
        }

        private bool GetRadioButtonOther()
        {
            return radioButton;
        }

        private bool GetRadioButtonOther(bool radioButtonOther)
        {
            return radioButtonOther;
        }

        // Calculate logic

        private void radioButtonOther_CheckedChanged(object sender, EventArgs e, bool radioButtonOther)
        {
            textBoxOtherYears.Visible = radioButtonOther
                ;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Reset logic
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}