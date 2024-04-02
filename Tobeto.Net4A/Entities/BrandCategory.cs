using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BrandCategory
    {
        #region Many_To_Many_Relationship
        /*  Default Conversation------------
            İki entity arasındaki ilişkiyi navigation propertyler üzerinden çoğul olarak kurmalıyız. (ICollection<T>, List<T>)
            EntityFramework otomatik olarak cross table'ı oluşturup içerisindeki composite primary key tanımlamasınıda yapacaktır.
        */

        /*  Data Annotations------------
            Cross table manuel bir şekilde entity olarak oluşturulur.
            Çoka çok ilişki kurulması istenilen herbir entity için, oluşturulan cross table entity'si ile bire çok ilişki kurulur.
            Cross table'da composite primary key'i data annotations(attributes) ile manuel olarak kuramıyoruz. (Fluent API ile yapılmak zorunda!)
                Örn:
                    modelBuilder.Entity<BrandCategory>().HasKey(bc => new {bc.BrandId, bc.CategoryId});
            Not1: Cross table entity'sini Context içerisinde DbSet property'si ile bildirmek şart değil.
            Not2: Cross table entity'sindeki Foreign Key'lerin ismini özel olarak değiştidiğimizde hangi entity'e karşılık geldiğini belirtmek için;
                    [ForeignKey(nameof(Category))]
                  Attribute'ünü eklemeliyiz.

         */

        /*  Fluent API------------
            Cross table manuel bir şekilde entity olarak oluşturulur.
            Composite Primary Key, HasKey methodu ile kurulmalı!
            Not1: Cross table entity'sini Context içerisinde DbSet property'si ile bildirmek şart değil.

            Kullanım:
                        modelBuilder.Entity<BrandCategory>()
                            .HasOne(bc => bc.Brand)
                            .WitMany(b => b.Category)
                            .HasForeignKey(bc => bc.BrandId);

                         modelBuilder.Entity<BrandCategory>()
                            .HasOne(bc => bc.Category)
                            .WitMany(c => c.Brand)         
                            .HasForeignKey(bc => bc.CategoryId);

        */
        #endregion
        public BrandCategory(int brandId, int categoryId)
        {
            BrandId = brandId;
            CategoryId = categoryId;
        }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }

    }
}
