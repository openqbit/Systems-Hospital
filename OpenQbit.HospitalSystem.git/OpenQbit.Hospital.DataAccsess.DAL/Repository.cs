using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using OpenQbit.Hospital.DataAccess.DAL.Contracts;

namespace OpenQbit.Hospital.DataAccsess.DAL
{
    public class Repository : IRepository
    {
        private PharmacyContext _db = new PharmacyContext();
        public bool Create<T>(T obj) where T : class
        {
            throw new NotImplementedException();
        }

        public bool Delete<T>(T obj) where T : class
        {
            throw new NotImplementedException();
        }

        public T Find<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            throw new NotImplementedException();
        }

        public List<T> FindList<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update<T>(T obj) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
