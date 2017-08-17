using System.Data.Entity;
using AccountBook.Models;
using AccountBook.Repositories;

namespace AccountBook.Controllers
{
    public class EFUnitOfWork : IUnitOfWork
    {
        public DbContext Context { get; set; }

        public EFUnitOfWork()
        {
            Context = new SkillTreeHomeworkEntities();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}