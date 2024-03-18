
#region Onceki_Kodlar

//CreditManager creditManager = new CreditManager();
//creditManager.Calculate();
//creditManager.Save();


//Customer customer = new Customer(); // istance creation
//customer.Id = 1;
//customer.City = "Ankara";

//CustomerManager customerManager = new CustomerManager(customer);
//customerManager.Save();
//customerManager.Delete();

//Company company = new Company();
//company.TaxNumber = "100000";
//company.CompanyName = "Arçelik";

//CustomerManager customerManager2 = new CustomerManager(new Person());

//Person person = new Person();
//person.FirstName = "";
//person.NationalIdentity = "";

//Customer c1 = new Customer();
//Customer c2 = new Person();
//Customer c3 = new Company();

#endregion

//IoC Container
CustomerManager customerManager = new CustomerManager(new Customer(), new CarCreditManager());
customerManager.GiveCredit();

Console.ReadLine();

class CreditManager
{
    public void Calculate(int creditType)
    {
        //sonar qube
        if (creditType == 1) //esnaf
        {

        }

        if (creditType == 2) // öğretmen
        {

        }

        Console.WriteLine("Hesaplandı");
    }
    public void Save()
    {
        Console.WriteLine("Kredi verildi");
    }
}

interface ICreditManager
{
    void Calculate();
    void Save();
}

abstract class BaseCreditManager : ICreditManager
{
    public abstract void Calculate();
    public virtual void Save()
    {
        Console.WriteLine("Kaydedildi");
    }
}

class TeacherCreditManager : BaseCreditManager
{
    public override void Calculate()
    {
        //hesaplamalar
        Console.WriteLine("Öğretmen kredisi hesaplandı");
    }
    public override void Save()
    {
        //

        base.Save();
        //
    }

}

class MilitaryCreditManager : BaseCreditManager, ICreditManager
{
    public override void Calculate()
    {
        Console.WriteLine("Asker kredisi hesaplandı");
    }

    //DRY
}

class CarCreditManager : BaseCreditManager, ICreditManager
{
    public override void Calculate()
    {
        Console.WriteLine("Araba kredisi hesaplandı");
    }

}


//SOLID

public class Customer
{
    public Customer()
    {
        Console.WriteLine("Müşteri nesnesi başlatıldı!");
    }

    public int Id { get; set; }
    public string City { get; set; }
}

class Person : Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalIdentity { get; set; }
}
class Company : Customer
{
    public string CompanyName { get; set; }
    public string TaxNumber { get; set; }
}



//Katmanlı Mimariler
class CustomerManager
{
    private Customer _customer;
    private ICreditManager _creditManager;
    public CustomerManager(Customer customer,ICreditManager creditManager)
    {
        _customer = customer;
        _creditManager = creditManager;
    }
    public void Save()
    {
        Console.WriteLine("Müşteri kaydedildi :");
    }
    public void Delete()
    {
        Console.WriteLine("Müşteri silindi! :");
    }

    public void GiveCredit()
    {
        _creditManager.Calculate();
        Console.WriteLine("Müşteri silindi! :");
    }
}
