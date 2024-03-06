/*
    5) Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.
*/

Console.Write("Bir sayı giriniz: ");

int girilenSayi = Convert.ToInt16(Console.ReadLine());


int total = 0;
for (int i = 1; i < girilenSayi; i++)
{
    if (girilenSayi % i  == 0) // tam bölünürse;
    {
        total += i;
    }
}

if (total == girilenSayi)
{
    Console.WriteLine("Girdiğin " + girilenSayi + " sayısı bir mükemmel sayı!");
}
else
{
    Console.WriteLine("Girdiğn sayı mükemmel sayı değil!");
}