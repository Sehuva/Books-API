using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.APIv2.Services
{
    public interface IBookRepository
    {
        Task<IEnumerable<Entities.Book>> GetBooksAsync();
        Task<Entities.Book> GetBookAsync(Guid id);


    }
}
