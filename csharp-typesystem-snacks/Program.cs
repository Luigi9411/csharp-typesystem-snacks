snack1();
snack2();
snack3();
snack4();
snack5();
snack6();
snack8();
snack9();
snack10();
snack11();
snack12();
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

void snack7()
{
    int[] number = new int[6]; 
    int check = 0; 

    for (int i = 0; i < 6; i++)
    {
        Console.WriteLine("Inserisci un numero:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 != 0)
        { 
            number[check] = num; 
            check++; 
        }
    }

    Console.WriteLine("I numeri dispari inseriti sono:");
    foreach (int num in number)
    { 
        if (num != 0)
        {
            Console.WriteLine(num);
        }
    }
}

void snack8()
{
    int[] num = { 61, 22, 29, 38, 45, 3, 78, 8, 14, 10 };
    Console.WriteLine("I numeri nell'array sono: ");
    for (int i = 0; i <= 9; i++)
    {    
    Console.WriteLine(num[i]);
    }
    int oddSum = 0;

    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] % 2 != 0) 
        {
            oddSum += num[i];
        }
    }

    Console.WriteLine("La somma dispari è: " + oddSum);
}

void snack9()
{
    int[] num = new int[0];
    int sum = 0;

    while (sum < 50) 
    {
        Console.Write("Inserisci un numero: ");
        int n = Convert.ToInt32(Console.ReadLine());

      
        Array.Resize(ref num, num.Length + 1);
        num[num.Length - 1] = n;

    
        sum = num.Sum();
    }

    Console.WriteLine("La somma degli elementi nell'array è: " + sum + " maggiore o uguale a 50.");
}
void snack10()
{
    Console.WriteLine("Inserisci un numero per generare un uguale numero di array contenenti 10 numeri: ");
    int N = Convert.ToInt32(Console.ReadLine());
    var random = new Random();

        Console.WriteLine("Array generati: ");
    for (int i = 0; i < N; i++)
    {
        var ints = new int[10];

        for (int j = 0; j < 10; j++)
        {
            ints[j] = random.Next(1, 100);
        }

        foreach (var num in ints)
        {
            Console.Write($"{num},");
        }

        Console.WriteLine();
    }
}

void snack11()
{
   
        Console.Write("Inserisci la prima parola: ");
        string word1 = Console.ReadLine();

        Console.Write("Inserisci la seconda parola: ");
        string word2 = Console.ReadLine();

        if (Checklength(word1, word2))
        {
            Console.WriteLine($"Le due parole '{word1}' e '{word2}' hanno la stessa lunghezza.");
        }
        else
        {
            string longerWord = (word1.Length > word2.Length) ? word1 : word2;
            Console.WriteLine($"La parola più lunga è: '{longerWord}'.");
        }
    
    bool Checklength(string word1, string word2)
    {
        return word1.Length == word2.Length;
    }

}


void CheckEvenOrOdd(int num)
{
    if (num % 2 == 0)
    {
        Console.WriteLine(num + " è pari.");
    }
    else
    {
        Console.WriteLine(num + " è dispari.");
    }
}
void snack12()
{


    Console.Write("Inserisci un numero: ");
    int num = Convert.ToInt32(Console.ReadLine());
    CheckEvenOrOdd(num);
}

















