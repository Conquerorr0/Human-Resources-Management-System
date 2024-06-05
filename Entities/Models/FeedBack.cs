using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public  class FeedBack
    {  // şikette bulunan bütün çalışanlar isteklerini  ve şikayetlerini isimizi olarak girebilecek 
        public int FeedbackId { get; set; }
        public string Message { get; set; }
        public DateTime SubmittedDate { get; set; }
    }
}
