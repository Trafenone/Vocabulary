using DataAccess.Models;

namespace Vocabulary.IRepository
{
    public interface IWordRepository
    {
        IEnumerable<Word> GetAll();
        Task<Word> GetById(int id);
        Task Insert(Word word);
        Task Update(Word word);
        Task Delete(int wordId);
        void Save();
    }
}
