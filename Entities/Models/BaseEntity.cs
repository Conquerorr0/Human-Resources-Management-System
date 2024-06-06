using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public abstract class BaseEntity
    {//her tabloda olmasını istedigimiz özellikleri tanımlıyoruz 
        public string  tc { get; set; }
      
       // public int id { get; set; } 
       
        //yaratılma güncellenem ve silnme tarıhlerini de alabiliriz veya verinni hangi durumda oldugunu da 
        protected BaseEntity()
        {
            // bu sınıf kalıtım olarak alındıgında gostermesini veya iletmesni 
            //istedigimiz şeyleri iletecek 
        }
    }
}
