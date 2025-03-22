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

    // Verifique se há um operador e então divide a string de acordo com o operador
    if (somar)
    {
        if (!txtDisplay.Text.Contains("+"))
            return; // Se não houver "+" na string, não faça nada

        List<string> aSomar = txtDisplay.Text.Split('+').ToList();
        if (aSomar.Count != 2) return; // Garante que há dois números

        double primeiroNumero = Convert.ToDouble(aSomar[0]);
        double segundoNumero = Convert.ToDouble(aSomar[1]);

        // Se for a primeira soma, apenas armazene o resultado
        if (resultadoAtual == 0)
        {
            resultadoAtual = primeiroNumero + segundoNumero;
        }
        else
        {
            // Se já houver resultado anterior, some o segundo número ao resultado anterior
            resultadoAtual += segundoNumero;
        }
    }
    else if (subtrair)
    {
        if (!txtDisplay.Text.Contains("-"))
            return;

        List<string> aSubtrair = txtDisplay.Text.Split('-').ToList();
        if (aSubtrair.Count != 2) return;

        double primeiroNumero = Convert.ToDouble(aSubtrair[0]);
        double segundoNumero = Convert.ToDouble(aSubtrair[1]);

        resultado = primeiroNumero - segundoNumero;
    }
    else if (dividir)
    {
        if (!txtDisplay.Text.Contains("/"))
            return;

        List<string> aDividir = txtDisplay.Text.Split('/').ToList();
        if (aDividir.Count != 2) return;

        double primeiroNumero = Convert.ToDouble(aDividir[0]);
        double segundoNumero = Convert.ToDouble(aDividir[1]);

        if (segundoNumero != 0)
        {
            resultado = primeiroNumero / segundoNumero;
        }
        else
        {
            MessageBox.Show("Erro: Divisão por zero.");
            txtDisplay.Text = "";
            return;
        }
    }
    else if (multiplicar)
    {
        if (!txtDisplay.Text.Contains("*"))
            return;

        List<string> aMultiplicar = txtDisplay.Text.Split('*').ToList();
        if (aMultiplicar.Count != 2) return;

        double primeiroNumero = Convert.ToDouble(aMultiplicar[0]);
        double segundoNumero = Convert.ToDouble(aMultiplicar[1]);

        resultado = primeiroNumero * segundoNumero;
    }

    // Exibe o resultado acumulado ou calculado
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
            operacao = '\0';
            novaEntrada = false;
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
    }
}







