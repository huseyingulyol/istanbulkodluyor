/*
    3) Do-While ve While döngüsü nedir? Bununla ilgili örnek yapınız.
*/

/*
    While nedir?--------------------------------------------------------------------------------------------
    Syntax (Sözdizimi): While(koşul){}    
    While if'in döngüsel halidir.
    Tek farkı while kullanılırsa döngü alanındaki kodlar bittikten sonra tekrardan koşulu kontrol eder.
    Eğer koşul yine başarılıysa tekrardan while alanının içine girer ve işler.
    Bu şekilde devam eder, önemli nokta şu ki; bir kez bile olsa koşul başarısız olursa while kodunun döngüsü kırılır ve işleyici yoluna devam eder.
    --------------------------------------------------------------------------------------------------------


    Do-While nedir?-----------------------------------------------------------------------------------------
    Syntax (Sözdizimi): Do{} While(Koşul);
    Do-While'ı while'dan ayıran tek şey şudur:
    While da koşul sonucu kodları while alanına yazarken Do-While'da "Do" alanının içine yazarız.
    Bu ne işe yarar diye sorarsanız, Do-while yapısının koda yazılmasıyla yazılış sırasındanda anlaşılacağı gibi ilk olarak "Do" alanı çalışır
    sonra while koşulu kontrol edilir. Yani işleyiş while'ın tersidir.
    Bu sayede kontrol olmadığı için Do daki alan hertürlü 1 kez çalışacaktır. Ondan sonra kontrole gidecektir.
    ---------------------------------------------------------------------------------------------------------

 */




/* While Örnek Kullanım (1'den 10 a kadar sayıları yazdıran uygulama) */

    //int number = 1;
    //while (number <= 10)
    //{
    //    Console.WriteLine(number++);
    //}





/* Do-While Örnek Kullanım (Sayı tahmin uygulaması) */

Random rnd = new Random();
int randomNumber = rnd.Next(1, 10);

int inputNumber = -1;
Console.Write("Bir sayı tuttum! bu sayıyı ");

do
{
    Console.Write("tahmin et: ");
    string? input = Console.ReadLine();
    if (!int.TryParse(input, out inputNumber))
    {
        Console.WriteLine("Hatalı giriş!");
    }
}
while (inputNumber != randomNumber);

Console.Write("Doğru sayıyı bildin!");