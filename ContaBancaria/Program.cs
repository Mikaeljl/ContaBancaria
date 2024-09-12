

public class ContaBancaria
{
    private decimal saldo;

    public decimal Saldo { get { return saldo; }

        
    }

    private List<string> historicotransacoes = new List<string>();

    private decimal limitesaquediario;

   
    public void Depositar(decimal valor)
    {
        saldo += valor;
        historicotransacoes.Add("Deposito de {valor} realizado");
    }

    public void sacar(decimal valor)
    {
        if (valor < limitesaquediario)
        {
            saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso!" + valor);

        }

        else
        {
            Console.WriteLine("limite de saques diarios alcançado!");
        }

    }

    public void DefinirSaqueDiario(decimal limite)
    {
        limitesaquediario = limite;
    }

    public void exibirhistorico()
    {
        foreach (string h in historicotransacoes)
        {
            Console.WriteLine(h);
        }
    }
}