//snack1();
snack2();
//snack3();

void snack1()
{
    Console.WriteLine("Inserisci un numero ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Inserisci un numero ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (num1 == num2)
    {
        Console.WriteLine("Il numero è uguale");
    }
    else if (num1 > num2)
    {
        Console.WriteLine("Il numero maggiore è " + num1);
    }
    else 
    {
        Console.WriteLine("Il numero maggiore è " + num2);
    }
}

void snack2()
{
    Console.WriteLine("Inserisci una parola ");
    string str1 = Console.ReadLine() ?? "";
    Console.WriteLine("Inserisci una parola ");
    string str2 = Console.ReadLine() ?? "";

    if (str1.Length > str2.Length)
    {
        Console.WriteLine("La parola più corta è " + str2);
        Console.WriteLine("La parola più lunga è " + str1);
    }
    else if (str1.Length < str2.Length)
    {
        Console.WriteLine("La parola più corta è " + str1);
        Console.WriteLine("La parola più lunga è " + str2);
    }
    else
    {
        Console.WriteLine("La parole hanno la stessa lunghezza "+str1+" "+ str2);
    }
}

void snack3()
{
    int somma = 0;
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine("Inserisci il " + i + "° numero:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        somma += num1;
    }
    Console.WriteLine("La somma dei 10 numeri inseriti è: " + somma);
}

