using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5_OOP
{
    public class InMemoryBrandRepository
    {
        List<Brand> brands; 
        public InMemoryBrandRepository() { // Constructor method
            brands = new List<Brand>();
        }

        public void AddBrandToRepo(Brand brand) {
            brands.Add(brand);
        }
        
        public List<Brand> GetAllRepo() //SQL'den veriler alındı.
        {
            return brands;
        }

    }
}
