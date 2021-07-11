using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*NOT:
 Attributeler [] içine yazılır. Projene Entity framework paketi yükle önce
-EntityLayer-sağ tuş-manage nuget packages-browse-entity framework 6-install


 */
namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]  //bunu primary key olarak belirttik
        public int AboutID { get; set; }

        [StringLength(1000)]
        public string AboutDetails1 { get; set; }

        [StringLength(1000)]
        public string AboutDetails2 { get; set; }

        [StringLength(100)]
        public string AboutImage1 { get; set; }

        [StringLength(100)]
        public string AboutImage2 { get; set; }
    }
}
