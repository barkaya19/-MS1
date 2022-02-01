using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void BookAdd(Book book)
        {
            throw new NotImplementedException();
        }

        public void BookDelete(Book book)
        {
            throw new NotImplementedException();
        }

        public void BookUpdate(Book book)
        {
            throw new NotImplementedException();
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetList()
        {
            return _bookDal.GetListAll();
        }
    }
}
