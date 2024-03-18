//  3- Generic type örneği yapınız.
//  Generic'ler interface, class,method yada parametrelerin sabit bir tip değil,
//   bir şablon yapısına uyan her tip için çalışmasını sağlayan bir yapıdır.

//Örneğin aşağıdaki list sınıfı bir generic sınıf'tır.
List<string> isimler = new List<string>();


//Generic sınıf oluşturma ise aşağıdaki gibi yapılabilir.
//Aşağıdaki örnekte MyGeneric adında generic bir sınıf oluşturulmuştur ve sınıf içerisine generic tipli bir property tanımlanmıştır.
//Bu sayede sınıfımıza verdiğimiz tip "Value" adlı değişkenede geçecektir.

MyGeneric<string> myGeneric = new MyGeneric<string>();
myGeneric.Value = "Generic Type Denemesi";
Console.WriteLine(myGeneric.Value);
public class MyGeneric<T>
{
    public T Value { get; set; }
}


