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
        private void buttonSub_Click(object sender, EventArgs e)
        {
            buttonOprInput("-");
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            buttonOprInput("*");
        }
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            buttonOprInput("/");
        }

        private void buttonCal_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                var result = dt.Compute(resultText, "");

                double num = Convert.ToDouble(result);

                string finalResult = (num % 1 == 0) ? ((int)num).ToString() : num.ToString();

                textResultBox.Text = $"{resultText} = {finalResult}";
                textInputBox.Text = finalResult;

                resultText = finalResult;
                inputText = finalResult;


            }
            catch
            {
                textResultBox.Text = "Error";
                resultText = "";
                inputText = "";
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            resultText = "";
            textResultBox.Text = resultText;

            inputText = "";
            textInputBox.Text = inputText;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(resultText)) return;

            string[] operators = { " + ", " - ", " * ", " / " };

            foreach (var op in operators)
            {
                if (resultText.EndsWith(op))
                {
                    resultText = resultText.Substring(0, resultText.Length - op.Length);
                    textResultBox.Text = resultText;
                    return;
                }
            }

            int lastSpaceIndex = resultText.LastIndexOf(' ');
            if (lastSpaceIndex == -1)
            {
                resultText = "";
            }
            else
            {
                resultText = resultText.Substring(0, lastSpaceIndex + 1);
            }

            textResultBox.Text = resultText;

            inputText = "";
            textInputBox.Text = "";
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(resultText)) return;

            string[] operators = { " + ", " - ", " * ", " / " };

            bool opRemoved = false;
            foreach (var op in operators)
            {
                if (resultText.EndsWith(op))
                {
                    resultText = resultText.Substring(0, resultText.Length - op.Length);
                    opRemoved = true;
                    break;
                }
            }

            if (!opRemoved && resultText.Length > 0)
            {
                resultText = resultText.Substring(0, resultText.Length - 1);
            }

            if (inputText.Length > 0)
            {
                inputText = inputText.Substring(0, inputText.Length - 1);
            }

            textResultBox.Text = resultText;
            textInputBox.Text = inputText;
        }
    }
}