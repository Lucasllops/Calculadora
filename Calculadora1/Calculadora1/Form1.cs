namespace Calculadora1
{
    public partial class Form1 : Form
    {
        public double valor1 { get; set; }
        public double valor2 { get; set; }
        public string operacao { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textResultado.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textResultado.Text += "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textResultado.Text += "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textResultado.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textResultado.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textResultado.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textResultado.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textResultado.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textResultado.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textResultado.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textResultado.Text.Contains('.'))
            {
                textResultado.Text = textResultado.Text;
            }
            else
            {
                textResultado.Text += ".";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = Convert.ToDouble(textResultado.Text);
                textResultado.Text = "";
                label1.Text = "+";
                operacao = "soma";
            }
            else
            {
                MessageBox.Show("digite um valor!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = Convert.ToDouble(textResultado.Text);
                textResultado.Text = "";
                label1.Text = "-";
                operacao = "sub";
            }
            else
            {
                MessageBox.Show("digite um valor!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = Convert.ToDouble(textResultado.Text);
                textResultado.Text = "";
                label1.Text = "*";
                operacao = "mult";
            }
            else
            {
                MessageBox.Show("digite um valor!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = Convert.ToDouble(textResultado.Text);
                textResultado.Text = "";
                label1.Text = "/";
                operacao = "div";
            }
            else
            {
                MessageBox.Show("digite um valor!");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(textResultado.Text);
            switch (operacao)
            {
                case "soma": textResultado.Text = (valor1 + valor2).ToString(); break;
                case "sub": textResultado.Text = (valor1 - valor2).ToString(); break;
                case "mult": textResultado.Text = (valor1 * valor2).ToString(); break;
                case "div": textResultado.Text = (valor1 / valor2).ToString(); break;
                default:MessageBox.Show("erro"); break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
        }
    }
}