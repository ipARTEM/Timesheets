using Microsoft.EntityFrameworkCore;
using Timesheets.API.EF.PostgreSQL.Models;

namespace Timesheets.API.EF.PostgreSQL.Repository
{
    public sealed class UserRepository
    {
        private readonly ApplicationContext _context;

        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        //public bool Add(User entity)
        //{
        //    try
        //    {
        //        _context.Add(entity);
        //        _context.SaveChanges();
        //    }
        //    catch (Exception exception)
        //    {
        //        return false;
        //    }

        //    return true;
        //}

        public async Task Add(User entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        //public IReadOnlyList<User> Get()
        //{
        //    // skipped try/catch

        //    return _context.Users.Where(x => x.IsDeleted == false).ToList();
        //}


        public async Task <IReadOnlyCollection<User>> Get()
        {
            // skipped try/catch
            var res=await _context.Users.Where(x => x.IsDeleted == false).ToListAsync();
            return res;
        }

        //public bool Update(User entity)
        //{
        //    // skipped try/catch

        //    return Commit();
        //}

        public async Task Update(User entity)
        {
           var ef= await _context.Users.FirstOrDefaultAsync(x=>x.Id==entity.Id);

            ef.FirstName=entity.FirstName;
            ef.LastName=entity.LastName;
            ef.Email=entity.Email;  
            ef.IsDeleted=entity.IsDeleted;
            ef.Company=entity.Company;
            ef.Age=entity.Age;  

            await _context.SaveChangesAsync();
            
        }


        //public bool Delete(int id)
        //{
        //    // skipped try/catch

        //    User entity = _context.Users.Find(id);

        //    entity.IsDeleted = true;

        //    return Commit();
        //}


        public async Task Delete(int id)
        {
            // skipped try/catch

            User entity = _context.Users.Find(id);

            entity.IsDeleted = true;

            await _context.SaveChangesAsync();

            
        }

        //private bool Commit()
        //{
        //    int count = _context.SaveChanges();

        //    return count > 0;
        //}
    }

}
