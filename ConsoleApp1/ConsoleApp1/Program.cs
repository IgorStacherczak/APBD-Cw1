// See https://aka.ms/new-console-template for more information

Console.WriteLine("Podaj Liczbę: ");

int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0){
    Console.WriteLine("Liczba jest parzysta " + a);
}
else
{
    Console.WriteLine("Liczba jest nie parzysta " + a);
}

