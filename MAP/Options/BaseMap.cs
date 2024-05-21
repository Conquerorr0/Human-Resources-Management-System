using Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP.Options
{
    public abstract class BaseMap<T>:EntityTypeConfiguration<T> where T: BaseEntity
    {   //x bizim yukarıda tanımladıgımız T yi temsil eder t de bu kodda BaseEntityi temsil eder 
        protected BaseMap() {
            //baseEntity sınıfında oluşturdugmuz ozelliklerin tablosunu oluşturuyoruz bizim BaseEntity de sadece tc oldugu içi tc nin tablosunu oluşturduk 

            Property(x => x.tc).HasColumnName("Kimlik Numarası ");
            Property(x => x.id).HasColumnName("id");
        }
    }
}
