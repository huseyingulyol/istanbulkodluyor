/*
    7) kullanıcıdan öğrenci sayısını isteyen her öğrenci için öğrenci adı,öğrenci soyadı,1.sınav notu,2.sınav notu,3.sınav notu isteyen ve daha sonra 
    not ortalamasını hesaplayıp ekrana yazdıran algoritma yapınız.(For döngüsü kullanınız)

*/


Console.Write("Kayıt edilecek öğrenci sayısını giriniz: ");
int count = Convert.ToInt16(Console.ReadLine());


for (int i = 0; i < count; i++)
{
    Console.WriteLine((i + 1) + ". öğrencinin adını giriniz: ");
    string? name = Console.ReadLine();
    Console.WriteLine((i + 1) + ". öğrencinin soyadını giriniz: ");
    string? surname = Console.ReadLine();
    Console.WriteLine((i + 1) + ". öğrencinin 1.notunu giriniz: ");
    int n1 = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine((i + 1) + ". öğrencinin 2.notunu giriniz: ");
    int n2 = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine((i + 1) + ". öğrencinin 3.notunu giriniz: ");
    int n3 = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("'" + (name + " "+ surname) + "' Adlı Öğrencinin Not Ortalaması: " + (n1 + n2 + n3) / 3);
}
