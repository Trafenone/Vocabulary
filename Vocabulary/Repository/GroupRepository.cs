using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Vocabulary.IRepository;

namespace Vocabulary.Repository
{
    public class GroupRepository : IGroupRepository
    {
        private readonly ApplicationDbContext _context;

        public GroupRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public bool Delete(int groupId)
        {
            bool result = false;
            var group = _context.Group.Find(groupId);
            if (group != null)
            {
                _context.Entry(group).State = EntityState.Deleted;
                _context.SaveChanges();
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public async Task<IEnumerable<Group>> GetAll()
        {
            return await _context.Group.ToListAsync();
        }

        public async Task<Group> GetById(int id)
        {
            return await _context.Group.FindAsync(id);
        }

        public async Task<Group> Insert(Group group)
        {
            await _context.Group.AddAsync(group);
            await _context.SaveChangesAsync();
            return group;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task<Group> Update(Group group)
        {
            _context.Group.Update(group);
            await _context.SaveChangesAsync();
            return group;
        }
    }
}
