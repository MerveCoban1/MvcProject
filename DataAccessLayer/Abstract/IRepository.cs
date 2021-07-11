using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
/*
 T değerim benim türüm entity'yi karşılayacak. Dışarıdan gelicek bu değer tablo ismim
 Her tablo için ayrı ayrı interface tanımlamamak için bir tane tanımladık hangi tablo olduğunu
dışarıdan alıcaz
 */
namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        //CRUD operasyonlarını birer metot olarak tanımlayacağım
        List<T> List(); //listeleme işlemi için
        void Insert(T p);
        void Update(T p);
        void Delete(T p);
        List<T> List(Expression<Func<T,bool>> filter);  //bu da şartlı listeleme yapacak
    }
}
