class Funcionario
{
    private List<Funcionario> funcionarios = new List<Funcionario>();
    public int Id { get; }

    public string Nome { get;  }

    public double Salario { get; set; }

    public string Cargo { get; }   
    
    public Funcionario(string nome, string cargo)
    {
        nome = Nome;
        cargo = Cargo;
    }

    public void AdicionarFuncionario(Funcionario funcionario)
    {
        funcionarios.Add(funcionario);
    }

    public void ExibirFuncionario()
    {
        Console.WriteLine($"O funcionário {Nome}\n:");
        foreach (Funcionario funcionario in this.funcionarios)
        {
            Console.WriteLine($"É {funcionario.Cargo} e recebe um salário de {funcionario.Salario}");
        }
        
    }

}