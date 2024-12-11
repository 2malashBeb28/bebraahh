using System;

class Bank
{
    private decimal bal = 0; 

    public void ShowBal()
    {
        Console.WriteLine("Ваш текущий баланс: " + bal + " рублей");
    }

    public void denigivotdenigi(decimal vlozh)
    {
        if (vlozh <= 0 || vlozh > bal)
        {
            Console.WriteLine("На Вашем счете недостаточно средств. Попробуйте позднее");
            return;
        }
        bal -= vlozh;
        Console.WriteLine("Вы сняли " + vlozh + " рублей. Ваш новый баланс: " + bal + " рублей.");
    }

    public void denindaidenigi(decimal vlozh)
    {
        bal += vlozh; 
        Console.WriteLine("Вы положили " + vlozh + " рублей. Ваш новый баланс: " + bal + " рублей.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank(); 

        while (true)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("Нажмите 1, если хотите увидеть баланс");
            Console.WriteLine("Нажмите 2, если хотите снять наличные");
            Console.WriteLine("Нажмите 3, если хотите положить наличные");
            Console.WriteLine("Нажмите 4, если хотите выйти из консоли");

            string vib = Console.ReadLine();

            if (vib == "1")
            {
                bank.ShowBal();
            }
            else if (vib == "2")
            {
                Console.Write("Введите сумму которую Вы хотите снять:");
                decimal denigivotvlozh = Convert.ToDecimal(Console.ReadLine());
                bank.denigivotdenigi(denigivotvlozh);
              
            }
               
            
            else if (vib == "3")
            {
                Console.Write("Введите сумму которую Вы хотите положить ");
                decimal denigidaivlozh = Convert.ToDecimal(Console.ReadLine());
                bank.denindaidenigi(denigidaivlozh);
            }
            else if (vib == "4")
            {
                Console.WriteLine("Выполняется действие выхода");
                break; 
            }
            
        }
    }
}
