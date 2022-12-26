
class Program
{
    static void Main()
    {
       int[] numbers = {1, 4, 10, 42};

       var query = from number in numbers
                   where number < 10
                   select number; 

        var query2 = numbers.Where(number => number < 10);

        Console.WriteLine(query.Count());
    }
}

delegate int Calculate(int x, int y);




class BankAccount 
{
    private string name;
    private decimal balance;

    public decimal Balance 
    { 
        get { return balance; }  

    }

    public BankAccount(string name, decimal balance)
    {
        if(string.IsNullOrWhiteSpace(name))
        {
            throw new Exception("Nome inválido");
        }
        if (balance < 0)
        {
            throw new Exception("Saldo não pode ser negativo");
        }

        this.name = name;
        this.balance = balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            return;
        }
        balance += amount;
    }


}


 







