using DataAccess.Models;

namespace Vocabulary.IRepository
{
    public interface IGroupRepository
    {
        Task<IEnumerable<Group>> GetAll();
        Task<Group> GetById(int id);
        Task<Group> Insert(Group group);
        Task<Group> Update(Group group);
        bool Delete(int groupId);
        void Save();
    }
}
