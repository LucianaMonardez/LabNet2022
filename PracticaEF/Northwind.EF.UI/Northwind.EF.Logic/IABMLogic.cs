using Northwind.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.EF.Logic
{
    public interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T U);
        void Delete(int id);
        void Update(int id);   

    }
}
