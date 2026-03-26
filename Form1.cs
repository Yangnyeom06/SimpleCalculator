using System.Data;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        string resultText = "";
        string inputText = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNumInput(string value)
        {
            inputText += $"{value}";
            textInputBox.Text = inputText;

            resultText += $"{value}";
            textResultBox.Text = resultText;
        }

        private void buttonOprInput(string value)
        {
            if (string.IsNullOrWhiteSpace(resultText)) return;

            if (resultText.EndsWith(" + ") ||
                resultText.EndsWith(" - ") ||
                resultText.EndsWith(" * ") ||
                resultText.EndsWith(" / "))
            {
                resultText = resultText.Substring(0, resultText.Length - 3);
            }

            resultText += $" {value} ";
            textResultBox.Text = resultText;

            inputText = "";
            textInputBox.Text = inputText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonNumInput("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonNumInput("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonNumInput("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonNumInput("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonNumInput("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonNumInput("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonNumInput("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonNumInput("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonNumInput("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            buttonNumInput("0");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            buttonOprInput("+");
        }

        private void buttonCal_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                var result = dt.Compute(resultText, "");

                resultText += $" = {result.ToString()}";
                textResultBox.Text = resultText;
                textInputBox.Text = result.ToString();
                resultText = result.ToString();
                inputText = result.ToString();
  
            }
            catch
            {
                textResultBox.Text = "Error";
                resultText = "";
  
            }
        }
    }
}