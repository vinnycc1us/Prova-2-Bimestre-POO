public class Calculo
{
    public string nome;
    public int cpf;
    public int matricula;
    public double salario;
    
    public Calculo (string nome, int cpf, int matricula, double salario)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.matricula = matricula;
        this.salario = salario;
    }
    
    public double Medico()
    {
        return this.salario + (this.salario * 0.20);      
    }

    public double TI()
    {
        return this.salario + 5000;      
    }

    public double ADM()
    {
        return this.salario + (this.salario * 0.15) + 200;      
    }
}