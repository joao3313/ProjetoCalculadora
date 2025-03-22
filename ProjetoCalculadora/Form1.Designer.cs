namespace ProjetoCalculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btnNumero7 = new Button();
            btnNumero8 = new Button();
            btnNumero9 = new Button();
            btnNumero4 = new Button();
            btnNumero5 = new Button();
            btnNumero6 = new Button();
            btnNumero1 = new Button();
            btnNumero2 = new Button();
            btnNumero3 = new Button();
            btnNumero0 = new Button();
            btnDivisao = new Button();
            btnMultiplicacao = new Button();
            btnSubtracao = new Button();
            btnAdicao = new Button();
            btnResultado = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(12, 47);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(220, 56);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btnNumero7
            // 
            btnNumero7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNumero7.Location = new Point(12, 109);
            btnNumero7.Name = "btnNumero7";
            btnNumero7.Size = new Size(75, 36);
            btnNumero7.TabIndex = 1;
            btnNumero7.Text = "7";
            btnNumero7.UseVisualStyleBackColor = true;
            btnNumero7.Click += btnNumero7_Click;
            // 
            // btnNumero8
            // 
            btnNumero8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNumero8.Location = new Point(93, 109);
            btnNumero8.Name = "btnNumero8";
            btnNumero8.Size = new Size(75, 36);
            btnNumero8.TabIndex = 1;
            btnNumero8.Text = "8";
            btnNumero8.UseVisualStyleBackColor = true;
            btnNumero8.Click += btnNumero8_Click;
            // 
            // btnNumero9
            // 
            btnNumero9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNumero9.Location = new Point(174, 109);
            btnNumero9.Name = "btnNumero9";
            btnNumero9.Size = new Size(75, 36);
            btnNumero9.TabIndex = 1;
            btnNumero9.Text = "9";
            btnNumero9.UseVisualStyleBackColor = true;
            btnNumero9.Click += btnNumero9_Click;
            // 
            // btnNumero4
            // 
            btnNumero4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNumero4.Location = new Point(12, 151);
            btnNumero4.Name = "btnNumero4";
            btnNumero4.Size = new Size(75, 40);
            btnNumero4.TabIndex = 1;
            btnNumero4.Text = "4";
            btnNumero4.UseVisualStyleBackColor = true;
            btnNumero4.Click += btnNumero4_Click;
            // 
            // btnNumero5
            // 
            btnNumero5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNumero5.Location = new Point(93, 151);
            btnNumero5.Name = "btnNumero5";
            btnNumero5.Size = new Size(75, 40);
            btnNumero5.TabIndex = 1;
            btnNumero5.Text = "5";
            btnNumero5.UseVisualStyleBackColor = true;
            btnNumero5.Click += btnNumero5_Click;
            // 
            // btnNumero6
            // 
            btnNumero6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNumero6.Location = new Point(174, 151);
            btnNumero6.Name = "btnNumero6";
            btnNumero6.Size = new Size(75, 40);
            btnNumero6.TabIndex = 1;
            btnNumero6.Text = "6";
            btnNumero6.UseVisualStyleBackColor = true;
            btnNumero6.Click += btnNumero6_Click;
            // 
            // btnNumero1
            // 
            btnNumero1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNumero1.Location = new Point(12, 197);
            btnNumero1.Name = "btnNumero1";
            btnNumero1.Size = new Size(75, 40);
            btnNumero1.TabIndex = 1;
            btnNumero1.Text = "1";
            btnNumero1.UseVisualStyleBackColor = true;
            btnNumero1.Click += btn1_Click;
            // 
            // btnNumero2
            // 
            btnNumero2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNumero2.Location = new Point(93, 197);
            btnNumero2.Name = "btnNumero2";
            btnNumero2.Size = new Size(75, 40);
            btnNumero2.TabIndex = 1;
            btnNumero2.Text = "2";
            btnNumero2.UseVisualStyleBackColor = true;
            btnNumero2.Click += btnNumero2_Click;
            // 
            // btnNumero3
            // 
            btnNumero3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNumero3.Location = new Point(174, 197);
            btnNumero3.Name = "btnNumero3";
            btnNumero3.Size = new Size(75, 40);
            btnNumero3.TabIndex = 1;
            btnNumero3.Text = "3";
            btnNumero3.UseVisualStyleBackColor = true;
            btnNumero3.Click += btnNumero3_Click;
            // 
            // btnNumero0
            // 
            btnNumero0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNumero0.Location = new Point(12, 243);
            btnNumero0.Name = "btnNumero0";
            btnNumero0.Size = new Size(75, 39);
            btnNumero0.TabIndex = 1;
            btnNumero0.Text = "0";
            btnNumero0.UseVisualStyleBackColor = true;
            btnNumero0.Click += btnNumero0_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivisao.Location = new Point(255, 69);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(75, 34);
            btnDivisao.TabIndex = 1;
            btnDivisao.Text = "/";
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiplicacao.Location = new Point(255, 109);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(75, 36);
            btnMultiplicacao.TabIndex = 1;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubtracao.Location = new Point(255, 151);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(75, 40);
            btnSubtracao.TabIndex = 1;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnAdicao
            // 
            btnAdicao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicao.Location = new Point(255, 197);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(75, 40);
            btnAdicao.TabIndex = 1;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = true;
            btnAdicao.Click += btnAdicao_Click;
            // 
            // btnResultado
            // 
            btnResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResultado.Location = new Point(174, 243);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(156, 39);
            btnResultado.TabIndex = 1;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click_11;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(93, 243);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 39);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 321);
            Controls.Add(btnSubtracao);
            Controls.Add(btnNumero3);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnNumero6);
            Controls.Add(btnDivisao);
            Controls.Add(btnNumero9);
            Controls.Add(btnLimpar);
            Controls.Add(btnNumero2);
            Controls.Add(btnNumero5);
            Controls.Add(btnNumero8);
            Controls.Add(btnResultado);
            Controls.Add(btnAdicao);
            Controls.Add(btnNumero0);
            Controls.Add(btnNumero1);
            Controls.Add(btnNumero4);
            Controls.Add(btnNumero7);
            Controls.Add(txtDisplay);
            Name = "frmCalculadora";
            StartPosition = FormStartPosition.Manual;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnNumero7;
        private Button btnNumero8;
        private Button btnNumero9;
        private Button btnNumero4;
        private Button btnNumero5;
        private Button btnNumero6;
        private Button btnNumero1;
        private Button btnNumero2;
        private Button btnNumero3;
        private Button btnNumero0;
        private Button btnDivisao;
        private Button btnMultiplicacao;
        private Button btnSubtracao;
        private Button btnAdicao;
        private Button btnResultado;
        private Button btnLimpar;
    }
}
