using System.Collections.Generic;
using System.Linq;

namespace RepositoryPattern.Models.BooksLinq
{
    public class BooksRepository : IBooksRepository
    {
        private BooksIReadDataContext _dataContext;

        public BooksRepository()
        {
            _dataContext = new BooksIReadDataContext();
        }

        #region IBooksRepository Members
        public IList<BooksIRead> ListAll()
        {
            var books = from b in _dataContext.BooksIReads 
                        orderby b.Author 
                        select b;

            return books.ToList();
        }






        #endregion
    }
}