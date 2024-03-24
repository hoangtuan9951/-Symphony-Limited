using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository.Epro3;
using Epro3.Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Infrastructure.Repositories.Epro3
{
    public class AdminRepository : IAdminRepository
    {
        private readonly ApplicationDatabaseContext _dbContext;
        public AdminRepository(ApplicationDatabaseContext dbContext) {
            _dbContext = dbContext;
        }
        public async Task<int> Login(string username, string password)
        {
            var data = await _dbContext.Admins.Where(e => e.UserName == username && e.Password == password).FirstOrDefaultAsync();
            if (data == null)
            {
                throw new Exception("login fail");
            }
            return data.Id;
        }
    }
}
