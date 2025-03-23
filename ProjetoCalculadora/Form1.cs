namespace ProjetoCalculadora
{
    public partial class frmCalculadora : Form
    {
        private bool dividir;
        private bool subtrair;
        private bool multiplicar;
        private bool somar;
        private int resultado;
        private char operacao;
        private bool novaEntrada;
        private string ultimaOperacao = "";
        private bool novoCalculo = false;

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void btnResultado_Click(object sender, EventArgs e)

        {
            dividir = false;
            subtrair = false;
            multiplicar = false;
            somar = true;

            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '-'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '*'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '/')
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }
            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '+')
                return;

            txtDisplay.Text += "+";
        }

        private void btnResultado_Click_1(object sender, EventArgs e)
        {



            if (somar)
            {
                List<string> aSomar = txtDisplay.Text.Split("+").ToList();

                double primeiroNumero = Convert.ToDouble(aSomar[0]);
                double segundoNumero = Convert.ToDouble(aSomar[1]);

                double resultado = primeiroNumero + segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
            else if (subtrair)
            {
                // Realiza a subtração
                List<string> aSubtrair = txtDisplay.Text.Split("-").ToList();

                double primeiroNumero = Convert.ToDouble(aSubtrair[0]);
                double segundoNumero = Convert.ToDouble(aSubtrair[1]);

                double resultado = primeiroNumero - segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
            else if (dividir)
            {
                // Realiza a divisão
                List<string> aDividir = txtDisplay.Text.Split("/").ToList();

                double primeiroNumero = Convert.ToDouble(aDividir[0]);
                double segundoNumero = Convert.ToDouble(aDividir[1]);

                if (segundoNumero != 0)
                {
                    double resultado = primeiroNumero / segundoNumero;
                    txtDisplay.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Erro: Divisão por zero.");
                    txtDisplay.Text = "";
                }
            }
            else if (multiplicar)
            {
                // Realiza a multiplicação
                List<string> aMultiplicar = txtDisplay.Text.Split("*").ToList();

                double primeiroNumero = Convert.ToDouble(aMultiplicar[0]);
                double segundoNumero = Convert.ToDouble(aMultiplicar[1]);

                double resultado = primeiroNumero * segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }



        }

        private void btnNumero2_Click(object sender, EventArgs e)
        {

            txtDisplay.Text += "2";

        }

        private void btnResultado_Click_2(object sender, EventArgs e)
        {
            {
                dividir = false;
                subtrair = false;
                multiplicar = false;
                somar = true;

                if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '-'
                    || txtDisplay.Text[txtDisplay.Text.Length - 1] == '*'
                    || txtDisplay.Text[txtDisplay.Text.Length - 1] == '/')
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                }
                if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '+')
                    return;
                txtDisplay.Text += "+";
            }
        }
        private void btnResultado_Click_3(object sender, EventArgs e)
        {


            if (somar)
            {
                List<string> aSomar = txtDisplay.Text.Split("+").ToList();

                double primeiroNumero = Convert.ToDouble(aSomar[0]);
                double segundoNumero = Convert.ToDouble(aSomar[1]);

                double resultado = primeiroNumero + segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
            else if (subtrair)
            {
                // Realiza a subtração
                List<string> aSubtrair = txtDisplay.Text.Split("-").ToList();

                double primeiroNumero = Convert.ToDouble(aSubtrair[0]);
                double segundoNumero = Convert.ToDouble(aSubtrair[1]);

                double resultado = primeiroNumero - segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
            else if (dividir)
            {
                // Realiza a divisão
                List<string> aDividir = txtDisplay.Text.Split("/").ToList();

                double primeiroNumero = Convert.ToDouble(aDividir[0]);
                double segundoNumero = Convert.ToDouble(aDividir[1]);

                if (segundoNumero != 0)
                {
                    double resultado = primeiroNumero / segundoNumero;
                    txtDisplay.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Erro: Divisão por zero.");
                    txtDisplay.Text = "";
                }
            }
            else if (multiplicar)
            {
                // Realiza a multiplicação
                List<string> aMultiplicar = txtDisplay.Text.Split("*").ToList();

                double primeiroNumero = Convert.ToDouble(aMultiplicar[0]);
                double segundoNumero = Convert.ToDouble(aMultiplicar[1]);

                double resultado = primeiroNumero * segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }

            dividir = false;
            subtrair = false;
            multiplicar = false;
            somar = false;
        }


        private void btnNumero3_Click(object sender, EventArgs e)
        {

            txtDisplay.Text += "3";
        }

        private void btnResultado_Click4(object sender, EventArgs e)

        {
            dividir = false;
            subtrair = false;
            multiplicar = false;
            somar = true;

            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '-'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '*'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '/')
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }
            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '+')
                return;
            txtDisplay.Text += "+";
        }

        private void btnResultado_Click_4(object sender, EventArgs e)
        {

            if (somar)
            {
                List<string> aSomar = txtDisplay.Text.Split("+").ToList();

                double primeiroNumero = Convert.ToDouble(aSomar[0]);
                double segundoNumero = Convert.ToDouble(aSomar[1]);

                double resultado = primeiroNumero + segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
            else if (subtrair)
            {
                // Realiza a subtração
                List<string> aSubtrair = txtDisplay.Text.Split("-").ToList();

                double primeiroNumero = Convert.ToDouble(aSubtrair[0]);
                double segundoNumero = Convert.ToDouble(aSubtrair[1]);

                double resultado = primeiroNumero - segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
            else if (dividir)
            {
                // Realiza a divisão
                List<string> aDividir = txtDisplay.Text.Split("/").ToList();

                double primeiroNumero = Convert.ToDouble(aDividir[0]);
                double segundoNumero = Convert.ToDouble(aDividir[1]);

                if (segundoNumero != 0)
                {
                    double resultado = primeiroNumero / segundoNumero;
                    txtDisplay.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Erro: Divisão por zero.");
                    txtDisplay.Text = "";
                }
            }
            else if (multiplicar)
            {
                // Realiza a multiplicação
                List<string> aMultiplicar = txtDisplay.Text.Split("*").ToList();

                double primeiroNumero = Convert.ToDouble(aMultiplicar[0]);
                double segundoNumero = Convert.ToDouble(aMultiplicar[1]);

                double resultado = primeiroNumero * segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
        }

        private void btnNumero4_Click(object sender, EventArgs e)

        {
            txtDisplay.Text += "4";
        }

        private void btnResultado_Click5(object sender, EventArgs e)

        {
            dividir = false;
            subtrair = false;
            multiplicar = false;
            somar = true;

            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '-'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '*'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '/')
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }
            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '+')
                return;
            txtDisplay.Text += "+";
        }

        private void btnResultado_Click_5(object sender, EventArgs e)
        {

            if (somar)
            {
                List<string> aSomar = txtDisplay.Text.Split("+").ToList();

                double primeiroNumero = Convert.ToDouble(aSomar[0]);
                double segundoNumero = Convert.ToDouble(aSomar[1]);

                double resultado = primeiroNumero + segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
            else if (subtrair)
            {
                // Realiza a subtração
                List<string> aSubtrair = txtDisplay.Text.Split("-").ToList();

                double primeiroNumero = Convert.ToDouble(aSubtrair[0]);
                double segundoNumero = Convert.ToDouble(aSubtrair[1]);

                double resultado = primeiroNumero - segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
            else if (dividir)
            {
                // Realiza a divisão
                List<string> aDividir = txtDisplay.Text.Split("/").ToList();

                double primeiroNumero = Convert.ToDouble(aDividir[0]);
                double segundoNumero = Convert.ToDouble(aDividir[1]);

                if (segundoNumero != 0)
                {
                    double resultado = primeiroNumero / segundoNumero;
                    txtDisplay.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Erro: Divisão por zero.");
                    txtDisplay.Text = "";
                }
            }
            else if (multiplicar)
            {
                // Realiza a multiplicação
                List<string> aMultiplicar = txtDisplay.Text.Split("*").ToList();

                double primeiroNumero = Convert.ToDouble(aMultiplicar[0]);
                double segundoNumero = Convert.ToDouble(aMultiplicar[1]);

                double resultado = primeiroNumero * segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
        }

        private void btnNumero5_Click(object sender, EventArgs e)

        {
            txtDisplay.Text += "5";
        }

        private void btnResultado_Click6(object sender, EventArgs e)

        {
            dividir = false;
            subtrair = false;
            multiplicar = false;
            somar = true;

            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '-'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '*'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '/')
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }
            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '+')
                return;
            txtDisplay.Text += "+";
        }

        private void btnResultado_Click_6(object sender, EventArgs e)
        {

            if (somar)
            {
                List<string> aSomar = txtDisplay.Text.Split("+").ToList();

                double primeiroNumero = Convert.ToDouble(aSomar[0]);
                double segundoNumero = Convert.ToDouble(aSomar[1]);

                double resultado = primeiroNumero + segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
            else if (subtrair)
            {
                // Realiza a subtração
                List<string> aSubtrair = txtDisplay.Text.Split("-").ToList();

                double primeiroNumero = Convert.ToDouble(aSubtrair[0]);
                double segundoNumero = Convert.ToDouble(aSubtrair[1]);

                double resultado = primeiroNumero - segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
            else if (dividir)
            {
                // Realiza a divisão
                List<string> aDividir = txtDisplay.Text.Split("/").ToList();

                double primeiroNumero = Convert.ToDouble(aDividir[0]);
                double segundoNumero = Convert.ToDouble(aDividir[1]);

                if (segundoNumero != 0)
                {
                    double resultado = primeiroNumero / segundoNumero;
                    txtDisplay.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Erro: Divisão por zero.");
                    txtDisplay.Text = "";
                }
            }
            else if (multiplicar)
            {
                // Realiza a multiplicação
                List<string> aMultiplicar = txtDisplay.Text.Split("*").ToList();

                double primeiroNumero = Convert.ToDouble(aMultiplicar[0]);
                double segundoNumero = Convert.ToDouble(aMultiplicar[1]);

                double resultado = primeiroNumero * segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
        }

        private void btnNumero6_Click(object sender, EventArgs e)

        {
            txtDisplay.Text += "6";
        }

        private void btnResultado_Click7(object sender, EventArgs e)

        {
            dividir = false;
            subtrair = false;
            multiplicar = false;
            somar = true;

            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '-'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '*'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '/')
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }
            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '+')
                return;
            txtDisplay.Text += "+";
        }

        private void btnResultado_Click_7(object sender, EventArgs e)
        {

            if (somar)
            {
                List<string> aSomar = txtDisplay.Text.Split("+").ToList();

                double primeiroNumero = Convert.ToDouble(aSomar[0]);
                double segundoNumero = Convert.ToDouble(aSomar[1]);

                double resultado = primeiroNumero + segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
            else if (subtrair)
            {
                // Realiza a subtração
                List<string> aSubtrair = txtDisplay.Text.Split("-").ToList();

                double primeiroNumero = Convert.ToDouble(aSubtrair[0]);
                double segundoNumero = Convert.ToDouble(aSubtrair[1]);

                double resultado = primeiroNumero - segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
            else if (dividir)
            {
                // Realiza a divisão
                List<string> aDividir = txtDisplay.Text.Split("/").ToList();

                double primeiroNumero = Convert.ToDouble(aDividir[0]);
                double segundoNumero = Convert.ToDouble(aDividir[1]);

                if (segundoNumero != 0)
                {
                    double resultado = primeiroNumero / segundoNumero;
                    txtDisplay.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Erro: Divisão por zero.");
                    txtDisplay.Text = "";
                }
            }
            else if (multiplicar)
            {
                // Realiza a multiplicação
                List<string> aMultiplicar = txtDisplay.Text.Split("*").ToList();

                double primeiroNumero = Convert.ToDouble(aMultiplicar[0]);
                double segundoNumero = Convert.ToDouble(aMultiplicar[1]);

                double resultado = primeiroNumero * segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
        }

        private void btnNumero7_Click(object sender, EventArgs e)

        {
            txtDisplay.Text += "7";
        }

        private void btnResultado_Click8(object sender, EventArgs e)

        {
            dividir = false;
            subtrair = false;
            multiplicar = false;
            somar = true;

            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '-'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '*'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '/')
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }
            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '+')
                return;
            txtDisplay.Text += "+";
        }

        private void btnResultado_Click_8(object sender, EventArgs e)
        {

            if (somar)
            {
                List<string> aSomar = txtDisplay.Text.Split("+").ToList();

                double primeiroNumero = Convert.ToDouble(aSomar[0]);
                double segundoNumero = Convert.ToDouble(aSomar[1]);

                double resultado = primeiroNumero + segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
            else if (subtrair)
            {
                // Realiza a subtração
                List<string> aSubtrair = txtDisplay.Text.Split("-").ToList();

                double primeiroNumero = Convert.ToDouble(aSubtrair[0]);
                double segundoNumero = Convert.ToDouble(aSubtrair[1]);

                double resultado = primeiroNumero - segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
            else if (dividir)
            {
                // Realiza a divisão
                List<string> aDividir = txtDisplay.Text.Split("/").ToList();

                double primeiroNumero = Convert.ToDouble(aDividir[0]);
                double segundoNumero = Convert.ToDouble(aDividir[1]);

                if (segundoNumero != 0)
                {
                    double resultado = primeiroNumero / segundoNumero;
                    txtDisplay.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Erro: Divisão por zero.");
                    txtDisplay.Text = "";
                }
            }
            else if (multiplicar)
            {
                // Realiza a multiplicação
                List<string> aMultiplicar = txtDisplay.Text.Split("*").ToList();

                double primeiroNumero = Convert.ToDouble(aMultiplicar[0]);
                double segundoNumero = Convert.ToDouble(aMultiplicar[1]);

                double resultado = primeiroNumero * segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
        }

        private void btnNumero8_Click(object sender, EventArgs e)

        {
            txtDisplay.Text += "8";
        }

        private void btnResultado_Click9(object sender, EventArgs e)

        {
            dividir = false;
            subtrair = false;
            multiplicar = false;
            somar = true;

            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '-'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '*'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '/')
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }
            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '+')
                return;
            txtDisplay.Text += "+";
        }

        private void btnResultado_Click_9(object sender, EventArgs e)
        {

            if (somar)
            {
                List<string> aSomar = txtDisplay.Text.Split("+").ToList();

                double primeiroNumero = Convert.ToDouble(aSomar[0]);
                double segundoNumero = Convert.ToDouble(aSomar[1]);

                double resultado = primeiroNumero + segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
            else if (subtrair)
            {
                // Realiza a subtração
                List<string> aSubtrair = txtDisplay.Text.Split("-").ToList();

                double primeiroNumero = Convert.ToDouble(aSubtrair[0]);
                double segundoNumero = Convert.ToDouble(aSubtrair[1]);

                double resultado = primeiroNumero - segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
            else if (dividir)
            {
                // Realiza a divisão
                List<string> aDividir = txtDisplay.Text.Split("/").ToList();

                double primeiroNumero = Convert.ToDouble(aDividir[0]);
                double segundoNumero = Convert.ToDouble(aDividir[1]);

                if (segundoNumero != 0)
                {
                    double resultado = primeiroNumero / segundoNumero;
                    txtDisplay.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Erro: Divisão por zero.");
                    txtDisplay.Text = "";
                }
            }
            else if (multiplicar)
            {
                // Realiza a multiplicação
                List<string> aMultiplicar = txtDisplay.Text.Split("*").ToList();

                double primeiroNumero = Convert.ToDouble(aMultiplicar[0]);
                double segundoNumero = Convert.ToDouble(aMultiplicar[1]);

                double resultado = primeiroNumero * segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
        }

        private void btnNumero9_Click(object sender, EventArgs e)

        {
            txtDisplay.Text += "9";
        }

        private void btnResultado_Click10(object sender, EventArgs e)

        {
            dividir = false;
            subtrair = false;
            multiplicar = false;
            somar = true;

            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '-'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '*'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '/')
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }
            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '+')
                return;
            txtDisplay.Text += "+";
        }

        private void btnResultado_Click_10(object sender, EventArgs e)
        {

            if (somar)
            {
                List<string> aSomar = txtDisplay.Text.Split("+").ToList();

                double primeiroNumero = Convert.ToDouble(aSomar[0]);
                double segundoNumero = Convert.ToDouble(aSomar[1]);

                double resultado = primeiroNumero + segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
            else if (subtrair)
            {
                // Realiza a subtração
                List<string> aSubtrair = txtDisplay.Text.Split("-").ToList();

                double primeiroNumero = Convert.ToDouble(aSubtrair[0]);
                double segundoNumero = Convert.ToDouble(aSubtrair[1]);

                double resultado = primeiroNumero - segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
            else if (dividir)
            {
                // Realiza a divisão
                List<string> aDividir = txtDisplay.Text.Split("/").ToList();

                double primeiroNumero = Convert.ToDouble(aDividir[0]);
                double segundoNumero = Convert.ToDouble(aDividir[1]);

                if (segundoNumero != 0)
                {
                    double resultado = primeiroNumero / segundoNumero;
                    txtDisplay.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Erro: Divisão por zero.");
                    txtDisplay.Text = "";
                }
            }
            else if (multiplicar)
            {
                // Realiza a multiplicação
                List<string> aMultiplicar = txtDisplay.Text.Split("*").ToList();

                double primeiroNumero = Convert.ToDouble(aMultiplicar[0]);
                double segundoNumero = Convert.ToDouble(aMultiplicar[1]);

                double resultado = primeiroNumero * segundoNumero;
                txtDisplay.Text = resultado.ToString();
            }
        }

        private void btnNumero0_Click(object sender, EventArgs e)

        {
            txtDisplay.Text += "0";
        }

        private void btnAdicao_Click(object sender, EventArgs e)

        {
            dividir = false;
            subtrair = false;
            multiplicar = false;
            somar = true;

            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '-'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '*'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '/')
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }
            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '+')
                return;
            txtDisplay.Text += "+";
        }

        private double resultadoAtual = 0;  // Armazenar o resultado acumulado

        private void btnResultado_Click_11(object sender, EventArgs e)
        {
            if (!somar && !subtrair && !dividir && !multiplicar)
                return;

            double resultado = 0;

            if (somar)
            {
                if (!txtDisplay.Text.Contains("+"))
                    return;

                string[] aSomar = txtDisplay.Text.Split('+');
                if (aSomar.Length != 2) return;

                double primeiroNumero, segundoNumero;
                if (!double.TryParse(aSomar[0], out primeiroNumero) || !double.TryParse(aSomar[1], out segundoNumero))
                    return;

                resultadoAtual = primeiroNumero + segundoNumero;
            }
            else if (subtrair)
            {
                if (!txtDisplay.Text.Contains("-"))
                    return;

                string[] aSubtrair = txtDisplay.Text.Split('-');
                if (aSubtrair.Length != 2) return;

                double primeiroNumero, segundoNumero;
                if (!double.TryParse(aSubtrair[0], out primeiroNumero) || !double.TryParse(aSubtrair[1], out segundoNumero))
                    return;

                resultadoAtual = primeiroNumero - segundoNumero;
            }
            else if (dividir)
            {
                if (!txtDisplay.Text.Contains("/"))
                    return;

                string[] aDividir = txtDisplay.Text.Split('/');
                if (aDividir.Length != 2) return;

                double primeiroNumero, segundoNumero;
                if (!double.TryParse(aDividir[0], out primeiroNumero) || !double.TryParse(aDividir[1], out segundoNumero))
                    return;

                if (segundoNumero == 0)
                {
                    MessageBox.Show("Erro: Divisão por zero.");
                    txtDisplay.Text = "";
                    return;
                }

                resultadoAtual = primeiroNumero / segundoNumero;

                // Exibir resultado com duas casas decimais
                txtDisplay.Text = resultadoAtual.ToString("F2");
                return;
            }
            else if (multiplicar)
            {
                if (!txtDisplay.Text.Contains("*"))
                    return;

                string[] aMultiplicar = txtDisplay.Text.Split('*');
                if (aMultiplicar.Length != 2) return;

                double primeiroNumero, segundoNumero;
                if (!double.TryParse(aMultiplicar[0], out primeiroNumero) || !double.TryParse(aMultiplicar[1], out segundoNumero))
                    return;

                resultadoAtual = primeiroNumero * segundoNumero;
            }

            // Exibir resultado sem formatação específica (exceto para divisão)
            txtDisplay.Text = resultadoAtual.ToString();
            // Após o cálculo, desativa todas as operações
            dividir = false;
            subtrair = false;
            multiplicar = false;
            somar = false;
        }




        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ResetarCalculadora();
        }

        private void ResetarCalculadora()
        {
            txtDisplay.Text = "";
            resultado = 0;
           
        }

        private void btnSubtracao_Click(object sender, EventArgs e)

        {
            dividir = false;
            subtrair = true;
            multiplicar = false;
            somar = false;

            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '-'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '*'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '/')
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }
            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '+')
                return;
            txtDisplay.Text += "-";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)


        {
            dividir = false;
            subtrair = false;
            multiplicar = true;
            somar = false;

            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '-'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '*'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '/')
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }
            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '+')
                return;
            txtDisplay.Text += "*";
        }

        private void btnDivisao_Click(object sender, EventArgs e)


        {
            dividir = true;
            subtrair = false;
            multiplicar = false;
            somar = false;

            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '-'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '*'
                || txtDisplay.Text[txtDisplay.Text.Length - 1] == '/')
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }
            if (txtDisplay.Text[txtDisplay.Text.Length - 1] == '+')
                return;
            txtDisplay.Text += "/";

            
        }


        // Adicionando virgula 
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains(","))
            txtDisplay.Text += ",";
        }
    }
}







