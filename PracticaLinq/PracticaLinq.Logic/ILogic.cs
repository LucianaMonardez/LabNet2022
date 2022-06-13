using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLinq.Logic
{
    public interface ILogic<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T U);
        void Delete(int id);
        void Update(T U);
    }
}
