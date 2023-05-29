using Telinha_de_IMC;

public class Pessoa
{
    private string nome;
    private string cpf;
    private int idade;
    private string sexo;
    private double peso;
    private double altura;

    public Pessoa(string nome, string cpf, int idade, string sexo, double peso, double altura)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.idade = idade;
        this.sexo = sexo;
        this.peso = peso;
        this.altura = altura;
    }

    public double CalcularIMC(double altura, double peso) // so retorna 1
    {
        return peso / Math.Pow(altura, 2);  
    }
    public (double,string,string) CalcularIMC() // retorna 3 valores ou mais...
    {
        double imc = CalcularIMC(altura, peso);

        string classificacao = "Magreza" + "Normal" + "SobrePeso " + "Obesidade" + "Obesidade Grave";
        string grau = "0" + "0" + "I" + "II" + "III";

        if (imc <= 18.5) 
        {
            classificacao = "Magreza";
            grau = "0";
        }
        else if (imc >= 18.5 &&  imc <= 24.9)
        {
            classificacao = "Normal";
            grau = "0";
        }
        else if (imc >= 25.0 && imc <= 29.9)
        {
            classificacao = "SobrePeso";
            grau = "I";
        }
        else if (imc >= 30.0 && imc <= 39.9)
        {
            classificacao = "Obesidade";
            grau = "II";
        }
        else if (imc >= 40.0)
        {
            classificacao = "Obesidade Grave";
            grau = "III";
        }
  
        return (imc, classificacao, grau);
    }
    public string ClikeInva(string invalidado)
    {
         invalidado = "\n Inválido";
        return invalidado;
    }

    public double GetPessoa()
    {
        return peso;
    }
    public void SetPessoa(double peso)
    {
        this.peso = peso;
    }
    public double PesoPessoa()
    {
        return peso;
    }
    public void PesoPessoa(double peso)
    {
        this.peso = peso;
    }


}