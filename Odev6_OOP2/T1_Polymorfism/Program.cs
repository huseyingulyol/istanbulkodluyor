//  1- polymorfizm ile ilgili 2 ayrı örnek yapınız.
//  Polymorfism (Çokbiçimlilik), bir türün bir başka tür gibi davranabilme ve bu tür gibi kullanılabilme özelliğidir.

using T1_Polymorfism;

#region Polymorfism 1.Örnek
//  Aşağıda database sınıfından türüyen sınıfların database tipinde de kullanılabildiği gösterilmektedir.

BaseDatabase db = new SQLite();
db.ConnectionString = AppDomain.CurrentDomain.BaseDirectory + "data.db";
Console.WriteLine($"Database Name: {db.Name}\nNoSQL: {db.NoSQL}\nConnectionString: {db.ConnectionString}");

db = new MongoDB();
db.ConnectionString = "sample mongodb connection string";
Console.WriteLine($"Database Name: {db.Name}\nNoSQL: {db.NoSQL}\nConnectionString: {db.ConnectionString}");
#endregion


#region Polymorfism 2.Örnek
//  Aşağıda logger sınıfından türüyen sınıfların logger tipinde de kullanılabildiği gösterilmektedir.

BaseLogger logger = new TextFileLogger();
logger.Log("sample log message");

logger = new ControlLogger() { control=new object()};
logger.Log("sample log message2");

#endregion