using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Not:
Eğer başka bir katmanın sınıflarını vs kullanmak istiyorsan o katmanı referans olarak eklemen gerek
References-sağtık-add reference-projects-oradan kullanacağın katmanı seçiyorsun-ok
 -> About benim projemin içinde yer alan sınıfın ismi Abouts bizim sqlde veritabanımıza yansıyacak olan tablo ismi
 -> Bu context sınıfı buraya yazılmış olan propertyleri sql'e tablo olarak yansıtacak.
 
 */

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
