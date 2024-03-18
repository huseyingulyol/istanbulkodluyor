//  5- Encapsulation nedir ? araştırınız. Bununla ilgili örnek yapınız.
//  Kapsülleme, bir nesnenin iç durumunun dışarıdan erişilebilir olmamasını
//   ve bu durumun sadece belirlenmiş yöntemler aracılığıyla değiştirilebilmesini sağlar.

// Aşağıdaki kod örneğinde Student sınıfı tanımlanmıştır ve kendi içinde private ve public propertylere ayrılmıştır.
// private fieldlar ile kendi iç kısmını yönetirken public ile dışarıya açılım sağlamıştır.

using T5_Encapsulation;

Student student = new Student();
student.FullName = "Hasan Hüseyin GÜLYOL";
student.Gender = true;
student.DateOfBirth = new DateTime(2001,08,08);

Console.WriteLine($"Adı Soyadı: {student.FullName}");
Console.WriteLine($"Cinsiyeti: {student.GenderValue()}");
Console.WriteLine($"Doğum Tarihi: {student.DateOfBirth}");
Console.WriteLine($"Yaşı: {student.Age()}");