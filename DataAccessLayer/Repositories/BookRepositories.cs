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
    public class BookRepositories : IBookDal
    {
        Context c = new Context();
        public void AddBook(Book book)
        {
            c.Add(book);
            c.SaveChanges();
        }

        public void Delete(Book t)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(Book book)
        {
            c.Remove(book);
            c.SaveChanges();
        }

        public Book GetById(int id)
        {
            return c.books.Find(id);
        }

        public List<Book> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Book t)
        {
            throw new NotImplementedException();
        }

        public List<Book> ListAllBook()
        {
            return c.books.ToList();
        }

        public void Update(Book t)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Book book)
        {
            c.Update(book);
            c.SaveChanges();
        }
    }
}
