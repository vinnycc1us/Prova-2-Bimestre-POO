namespace Pova_2_Bimestre_POO
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_funcao = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_matricula = new System.Windows.Forms.TextBox();
            this.tx_salario = new System.Windows.Forms.TextBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.cadastrar = new System.Windows.Forms.Button();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.imprimir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(271, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE FUNCIONARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(86, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(620, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(86, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Matricula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(86, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salário:";
            // 
            // tx_funcao
            // 
            this.tx_funcao.FormattingEnabled = true;
            this.tx_funcao.Items.AddRange(new object[] {
            "Medico",
            "TI",
            "ADM"});
            this.tx_funcao.Location = new System.Drawing.Point(717, 226);
            this.tx_funcao.Name = "tx_funcao";
            this.tx_funcao.Size = new System.Drawing.Size(151, 28);
            this.tx_funcao.TabIndex = 5;
            this.tx_funcao.SelectedIndexChanged += new System.EventHandler(this.tx_funcao_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(620, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Função:";
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(194, 143);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(391, 27);
            this.tx_nome.TabIndex = 7;
            // 
            // tx_matricula
            // 
            this.tx_matricula.Location = new System.Drawing.Point(194, 218);
            this.tx_matricula.Name = "tx_matricula";
            this.tx_matricula.Size = new System.Drawing.Size(203, 27);
            this.tx_matricula.TabIndex = 9;
            // 
            // tx_salario
            // 
            this.tx_salario.Location = new System.Drawing.Point(194, 365);
            this.tx_salario.Name = "tx_salario";
            this.tx_salario.Size = new System.Drawing.Size(171, 27);
            this.tx_salario.TabIndex = 10;
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(262, 473);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(94, 29);
            this.cancelar.TabIndex = 11;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(86, 473);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(94, 29);
            this.cadastrar.TabIndex = 12;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // tx_cpf
            // 
            this.tx_cpf.Location = new System.Drawing.Point(717, 146);
            this.tx_cpf.Mask = "___.___.___.__";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(151, 27);
            this.tx_cpf.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(433, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Salário Total:";
            // 
            // imprimir
            // 
            this.imprimir.AutoSize = true;
            this.imprimir.Location = new System.Drawing.Point(620, 373);
            this.imprimir.Name = "imprimir";
            this.imprimir.Size = new System.Drawing.Size(66, 20);
            this.imprimir.TabIndex = 15;
            this.imprimir.Text = "imprimir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 685);
            this.Controls.Add(this.imprimir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.tx_salario);
            this.Controls.Add(this.tx_matricula);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tx_funcao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox tx_funcao;
        private Label label6;
        private TextBox tx_nome;
        private TextBox tx_matricula;
        private TextBox tx_salario;
        private Button cancelar;
        private Button cadastrar;
        private MaskedTextBox tx_cpf;
        private Label label7;
        private Label imprimir;
    }
}