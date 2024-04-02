using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities
{
    public class Product : Entity
    {
        public Product()
        {

        }
        public Product(int id, string name, int categoryId, int quantity, double price, string description, int brandId)
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
            Quantity = quantity;
            Price = price;
            Description = description;
            BrandId = brandId;

        }
        [MaxLength(3)]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int Quantity { get; set; }

        //[Range(0, 2)]
        public double Price { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        [JsonIgnore]
        public virtual Category? Category { get; set; }
        [JsonIgnore]
        public virtual Brand? Brand { get; set; }
    }
}
