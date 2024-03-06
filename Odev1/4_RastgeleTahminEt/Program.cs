/*
    4) Kullanıcının 1 ile 10 arasında rastgele bir sayıyı tahmin etmesini isteyen ve doğru tahmin edene kadar devam eden bir program yazınız.
        (While döngüsü ile yapınız ve rastgele sayı üretmek için Random sınıfını kullanınız)
*/

Random rnd = new Random();
int number = rnd.Next(1, 10);

int tahmin = -1;
while (tahmin != number)
{

    Console.WriteLine("Bir sayı tuttum ve bu sayıyı tahmin et:");
    string? input = Console.ReadLine();
    if (!int.TryParse(input, out tahmin))
    {
        Console.WriteLine("Hatalı giriş!");
    }
}


Console.WriteLine("Doğru tahmin!");