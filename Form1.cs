namespace Calculadora
{
    public enum Operador
    { 
        Suma = 1,
        Resta = 2,
        Multiplicacion = 3,
        Division = 4
    }
    public partial class Form1 : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        bool valor = false;
        Operador opc = Operador.Suma;
        public Form1()
        {
            InitializeComponent();
        }

        private void Numero(string _n)
        {
            valor = true;
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = _n;
            }
            else
            {
                textBox1.Text += _n;
            }
        }

        private double Operacion()
        {
            double resultado = 0;
            switch (opc)
            {
                case Operador.Suma:
                    resultado = valor1 + valor2;
                    break;
                case Operador.Resta:
                    resultado = valor1 - valor2;
                    break;
                case Operador.Multiplicacion:
                    resultado = valor1 * valor2;
                    break;
                case Operador.Division:
                    if (valor2 == 0)
                    {
                        label1.Text = "ERROR, division por 0";
                    }
                    else 
                    {
                        resultado = valor1 / valor2;
                    }
                    break;
            }
            return resultado;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            valor = true;
            if (textBox1.Text == "0")
            {
                return;
            }
            else 
            { 
                textBox1.Text += "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Numero("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Numero("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Numero("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Numero("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Numero("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Numero("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Numero("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Numero("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Numero("9");
        }
       
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (valor2 == 0 && valor)
            {
                valor = false;
                valor2 = Convert.ToDouble(textBox1.Text);
                label1.Text += valor2 +"+";
                double resultado = Operacion();
                valor1 = 0;
                valor2 = 0;
                textBox1.Text = Convert.ToString(resultado);
            }


        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            opc = Operador.Suma;
            valor1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "+";
            textBox1.Text = "0";
        }
        private void btnResta_Click(object sender, EventArgs e)
        {
            opc = Operador.Resta;
            valor1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "-";
            textBox1.Text = "0";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            opc = Operador.Multiplicacion;
            valor1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "*";
            textBox1.Text = "0";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            opc = Operador.Division;
            valor1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "/";
            textBox1.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 1)
            {
                string r = textBox1.Text;
                r = r.Substring(0, r.Length - 1);
                
                if(r.Length == 1 && r.Contains("-"))
                {
                    textBox1.Text = "0";
                }
                else
                {
                    textBox1.Text = r; 
                }                
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

    
        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}