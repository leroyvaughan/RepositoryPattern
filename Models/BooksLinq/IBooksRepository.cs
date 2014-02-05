using System.Collections.Generic;

namespace RepositoryPattern.Models.BooksLinq
{
    public interface IBooksRepository
    {
        IList<BooksIRead> ListAll();
    }
}