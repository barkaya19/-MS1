using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBookService
    {
        void BookAdd(Book book);
        void BookDelete(Book book);
        void BookUpdate(Book book);
        List<Book> GetList();
        Book GetById(int id);
    }
}
