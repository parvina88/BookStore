using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class AuthorService : IBaseService<Author>
    {
        private readonly IBaseRepository<Author> _authorRepository;

        public AuthorService(IBaseRepository<Author> authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            Author author = await GetAsync(id);

            if (author == null)
            {
                return false;
            }

            await _authorRepository.DeleteAsync(author.Id);
            return true;
        }

        public async Task<IEnumerable<Author>> GetAllAsync()
        {
            return await _authorRepository.GetAllAsync();
        }

        public async Task<Author> GetAsync(Guid id)
        {
            return await _authorRepository.GetAsync(id);
        }

        public async Task<Author> InsertAsync(Author author)
        {
            return await _authorRepository.InsertAsync(author);
        }

        public async Task<bool> UpdateAsync(Author author)
        {
            var existingAuthor = await _authorRepository.GetAsync(author.Id);

            if (existingAuthor is null)
            {
                return false;
            }

            existingAuthor.FullName = author.FullName;
            existingAuthor.Address = author.Address;
            existingAuthor.Phone = author.Phone;
            existingAuthor.Birthday = author.Birthday;
            existingAuthor.Gender = author.Gender;

            return await _authorRepository.UpdateAsync(existingAuthor);
        }
    }
}
