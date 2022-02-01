using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CustomerRepositories : ICustomerDal
    {
        Context c = new Context();
        public void AddCustomer(Customer customer)
        {
            c.Add(customer);
            c.SaveChanges();
        }

        public void Delete(Customer t)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(Customer customer)
        {
            c.Remove(customer);
            c.SaveChanges();
        }

        public Customer GetById(int id)
        {
            return c.customers.Find(id);
        }

        public List<Customer> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Customer t)
        {
            throw new NotImplementedException();
        }

        public List<Customer> ListAllCustomer()
        {
            return c.customers.ToList();
        }

        public void Update(Customer t)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            c.Update(customer);
            c.SaveChanges();
        }
    }
}
