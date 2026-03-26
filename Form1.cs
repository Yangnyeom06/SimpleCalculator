using System.Data;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        string resultTempText = "";
        string resultText = "";
        string inputText = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNumInput(string value)
        {
            inputText += value;
            textInputBox.Text = inputText;

            resultText += value;
            resultTempText += value;
            textResultBox.Text = resultTempText;
        }

        private void buttonOprInput(string value)
        {
            if (string.IsNullOrWhiteSpace(resultText)) return;

            string displayOp = value;
            if (value == "*") displayOp = "¡¿";
            else if (value == "/") displayOp = "¡À";

            if (resultText.EndsWith(" + ") ||
                resultText.EndsWith(" - ") ||
                resultText.EndsWith(" * ") ||
                resultText.EndsWith(" / "))
            {
                resultText = resultText.Substring(0, resultText.Length - 3);
                resultTempText = resultTempText.Substring(0, resultTempText.Length - 3);
            }

            resultText += $" {value} ";
            resultTempText += $" {displayOp} ";

            textResultBox.Text = resultTempText;

            inputText = "";

            textInputBox.Text = displayOp;
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

                string display = $"{resultTempText} = {finalResult}";
                textResultBox.Text = display;
                textInputBox.Text = finalResult;

                resultText = finalResult;
                inputText = finalResult;
                resultTempText = display;
            }
            catch
            {
                textResultBox.Text = "Error";
                resultText = "";
                inputText = "";
                resultTempText = "";
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            resultText = "";
            resultTempText = "";
            inputText = "";

            textResultBox.Text = "";
            textInputBox.Text = "";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(resultText)) return;

            string[] operators = { " + ", " - ", " * ", " / " };
            string[] displayOperators = { " + ", " - ", " ¡¿ ", " ¡À " };

            for (int i = 0; i < operators.Length; i++)
            {
                if (resultText.EndsWith(operators[i]))
                {
                    resultText = resultText.Substring(0, resultText.Length - operators[i].Length);
                    resultTempText = resultTempText.Substring(0, resultTempText.Length - displayOperators[i].Length);

                    textResultBox.Text = resultTempText;
                    textInputBox.Text = inputText;
                    return;
                }
            }

            if (!string.IsNullOrEmpty(inputText))
            {
                resultText = resultText.Substring(0, resultText.Length - inputText.Length);
                resultTempText = resultTempText.Substring(0, resultTempText.Length - inputText.Length);

                inputText = "";
                textResultBox.Text = resultTempText;
                textInputBox.Text = inputText;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(resultText)) return;

            string[] operators = { " + ", " - ", " * ", " / " };
            string[] displayOperators = { " + ", " - ", " ¡¿ ", " ¡À " };

            bool opRemoved = false;

            for (int i = 0; i < operators.Length; i++)
            {
                if (resultText.EndsWith(operators[i]))
                {
                    resultText = resultText.Substring(0, resultText.Length - operators[i].Length);
                    resultTempText = resultTempText.Substring(0, resultTempText.Length - displayOperators[i].Length);
                    opRemoved = true;
                    break;
                }
            }

            if (!opRemoved && resultText.Length > 0)
            {
                resultText = resultText.Substring(0, resultText.Length - 1);
                resultTempText = resultTempText.Substring(0, resultTempText.Length - 1);
            }

            if (inputText.Length > 0)
                inputText = inputText.Substring(0, inputText.Length - 1);

            textResultBox.Text = resultTempText;
            textInputBox.Text = inputText;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (inputText.Contains(".")) return;

            if (string.IsNullOrEmpty(inputText))
            {
                inputText = "0.";
                resultText += "0.";
                resultTempText += "0.";
            }
            else
            {
                inputText += ".";
                resultText += ".";
                resultTempText += ".";
            }

            textInputBox.Text = inputText;
            textResultBox.Text = resultTempText;
        }

        private void buttonPM_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputText)) return;

            bool isNegative = inputText.StartsWith("-");
            if (isNegative)
            {
                inputText = inputText.Substring(1);
            }
            else
            {
                inputText = "-" + inputText;
            }

            string[] parts = resultText.Split(' ');
            for (int i = parts.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(parts[i]) && !"+-*/".Contains(parts[i]))
                {
                    parts[i] = inputText;
                    break;
                }
            }
            resultText = string.Join(" ", parts);

            string[] tempParts = resultTempText.Split(' ');
            for (int i = tempParts.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(tempParts[i]) && !"+-¡¿¡À".Contains(tempParts[i]))
                {
                    tempParts[i] = inputText;
                    break;
                }
            }
            resultTempText = string.Join(" ", tempParts);

            textInputBox.Text = inputText;
            textResultBox.Text = resultTempText;
        }
    }
}