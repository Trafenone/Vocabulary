using DataAccess.Models;

namespace Vocabulary.IRepository
{
    public interface IWordsRepository
    {
        Task<IEnumerable<Words>> GetAll();
        Task<Words> GetById(int id);
        Task Insert(Words words);
        Task Update(Words words);
        Task Delete(int wordsId);
        Task Save();
    }
}
