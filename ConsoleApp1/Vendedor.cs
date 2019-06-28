namespace ConsoleApp1
{
    class Vendedor
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Vendedor(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public Vendedor()
        {

        }

        public void AumentaSalario(Vendedor vendedor, double percentual)
        {
            double acrecimo = vendedor.Salario * (percentual/100.00);
            vendedor.Salario += acrecimo;
        }

        public override string ToString()
        {
            return $"{Id}, {Nome}, {Salario}";
        }
    }
}
