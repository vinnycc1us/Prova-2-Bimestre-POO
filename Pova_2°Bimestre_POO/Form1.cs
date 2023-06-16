using System.ComponentModel.Design;
using System.Data.SqlTypes;

namespace Pova_2_Bimestre_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string nome = tx_nome.Text;
            int cpf = Convert.ToInt32(tx_cpf);
            int matricula = Convert.ToInt32(tx_matricula);
            double salario = Convert.ToDouble(tx_salario);
            Calculo calculo = new Calculo(nome, cpf, matricula, salario);
                  
            if (tx_funcao.Text == "Medico")
            {
                if (salario > 5000)
                {
                    salario - (salario * 0.17);
                }
                imprimir.Show($"{calculo.Medico())}");
            }
            else if (tx_funcao.Text == "TI")
            {
                if (salario > 5000)
                {
                    salario - (salario * 0.17);
                }
                imprimir.Show(calculo.TI());
            }
            else if (tx_funcao.Text == "ADM")
            {
                if(salario > 5000)
                {
                    salario - (salario * 0.17);
                }
                imprimir.Show(calculo.ADM);                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tx_nome.Text = "";
            tx_cpf.Text = "";
            tx_matricula.Text = "";
            tx_salario.Text = "";
        }
        private void tx_funcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}