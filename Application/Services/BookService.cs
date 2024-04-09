using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class BookService : IBaseService<Book>
    {
        private readonly IBaseRepository<Book> _bookRepository;

        public BookService(IBaseRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var book = GetAsync(id);

            if (book is not null)
            {
                await _bookRepository.DeleteAsync(id);
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await _bookRepository.GetAllAsync();
        }

        public async Task<Book> GetAsync(Guid id)
        {
            return await _bookRepository.GetAsync(id);
        }

        public async Task<Book> InsertAsync(Book book)
        {
            return await _bookRepository.InsertAsync(book);
        }

        public async Task<bool> UpdateAsync(Book book)
        {
            var existingBook = await _bookRepository.GetAsync(book.Id);

            if (existingBook is null)
            {
                return false;
            }

            existingBook.Name = book.Name;
            existingBook.Description = book.Description;
            existingBook.Price = book.Price;
            existingBook.Genre = book.Genre;

            return await _bookRepository.UpdateAsync(existingBook);
        }
    }
}
