using Ders5_OOP;

BrandManager brandManager = new BrandManager();
List<Brand> brands = brandManager.GetAll();

brandManager.Add(new Brand(1, "ASUS"));
brandManager.Add(new Brand(2, "RAZER"));
brandManager.Add(new Brand(3, "ASUS"));

foreach (Brand brand in brands)
{
    Console.WriteLine(brand.brandName);
}

