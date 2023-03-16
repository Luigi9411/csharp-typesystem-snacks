//snack1();
//snack2();
//snack3();
//snack4();
//snack5();
snack6();
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

void snack4()
{
    int somma = 0;
    double media = 0;

    for (int i = 2; i <= 10; i++)
    {
        somma += i;
    }

    media = (double)somma / 9;

    Console.WriteLine("La somma dei numeri da 2 a 10 è: " + somma);
    Console.WriteLine("La media dei numeri da 2 a 10 è: " + media);
}

void snack5()
{
    Console.WriteLine("Inserisci un numero per verificare che sia pari e ottenere come risposta lo stesso numero se pari o il successivo se dispari");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.WriteLine("Il numero inserito è pari: " + numero);
    }
    else
    {
        Console.WriteLine("Il numero inserito è dispari quindi il successivo ottenuto è: " + (numero + 1));
    }
}

void snack6()
{
        string[] guests = { "Marco", "Luca", "Giovanni", "Francesca", "Chiara", "Martina" };
        Console.WriteLine("Inserisci il tuo nome:");
        string name = Console.ReadLine().ToLower();

        bool presente = false;
        foreach (string guest in guests)
        {
            if (guest.ToLower() == name)
            {
                presente = true;
                break;
            }
        }

        if (presente)
        {
            Console.WriteLine("Benvenuto alla festa " + name);
        }
        else
        {
            Console.WriteLine("Mi dispiace, " + name + ", ma il tuo isee non raggiunge la fascia minima per partecipare. Contatta il caf per eventuali disguidi.");
        }
}




