using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5_OOP
{
    public class BrandManager
    {
        InMemoryBrandRepository repository = new InMemoryBrandRepository();
        public List<Brand> GetAll() // Tüm Brand'leri döndür.
        {
            return repository.GetAllRepo();
        }

        public void Add(Brand brand) { 
            
            if (brand.brandID <= 0) // Brand id'si negatif ise;
            {
                throw new Exception("Brand id'si negatif olamaz!");
            }
            else if (IfBrandIsExists(brand.brandName))
            {
                throw new Exception("Aynı adda birden fazla brand bulunamaz!");
            }
            else
            {
                repository.AddBrandToRepo(brand);
            }
        }

        public bool IfBrandIsExists(string name)
        {
            List<Brand> brands = repository.GetAllRepo();
            foreach (Brand brand in brands)
            {
                if (brand.brandName.ToLower() == name.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
