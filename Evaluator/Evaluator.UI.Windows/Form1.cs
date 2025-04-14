using Evaluator.Logic;

namespace Evaluator.UI.Windows
{
    public partial class FunctionsEvaluator : Form
    {
        public FunctionsEvaluator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void btnOpenParenthesis_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }

        private void btnCloseParenthesis_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            textBox1.Text += "^";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            textBox1.Text += $"= {FunctionEvaluator.Evalute(textBox1.Text)}";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Length > 0 ? textBox1.Text.Substring(0, textBox1.Text.Length - 1) : "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }
    }
}
