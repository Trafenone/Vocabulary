using DataAccess;
using DataAccess.Models;
using Vocabulary.IRepository;

namespace Vocabulary.Repository
{
    public class WordRepository : IWordRepository
    {
        private readonly ApplicationDbContext _context;

        public WordRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Delete(int wordId)
        {
            Word word = await _context.Word.FindAsync(wordId);
            _context.Word.Remove(word);
        }

        public IEnumerable<Word> GetAll()
        {
            return _context.Word.ToList();
        }

        public async Task<Word> GetById(int id)
        {
            return await _context.Word.FindAsync(id);
        }

        public async Task Insert(Word word)
        {
            await _context.Word.AddAsync(word);
        }

        public async Task Update(Word word)
        {
            _context.Word.Update(word);
            await _context.SaveChangesAsync();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

     
    }
}
