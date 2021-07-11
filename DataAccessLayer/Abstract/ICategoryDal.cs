using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //IRepository interfaceimin içinde ne varsa artık bu interfaceler içinde de var
    public interface ICategoryDal:IRepository<Category>
    {
    }
}
