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
        T GetById(int id);
        void Add(T U);
        void Delete(int id);
        void Update(T U);   

    }
}
