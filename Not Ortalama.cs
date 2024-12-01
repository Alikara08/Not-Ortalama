// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lütfen birinci notu giriniz");
int birinci_not = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("lütfen ikinci notu giriniz");
int ikinci_not = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen ücüncü notu giriniz");
int ucuncu_not = Convert.ToInt32(Console.ReadLine());

int sonuc = (birinci_not + ikinci_not + ucuncu_not) / 3;

if (sonuc >=80 &&sonuc < 100)
{
    Console.WriteLine( "Not degeriniz : A+");
}
else if (sonuc >60 && sonuc < 80)
{
    Console.WriteLine("Not degeriniz : A");
}
else if (sonuc >40 &&sonuc < 60)
{
    Console.WriteLine("Not degeriniz : B");
}
else
{
    Console.WriteLine("Not degeriniz : F");
}
