using Application.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbInitialize : IApplicationDbInitialize
    {
        private readonly ApplicationDbContext _context;

        public ApplicationDbInitialize(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            if (_context.Database.IsRelational())
            {
                _context.Database.Migrate();
            }
        }
    }
}
