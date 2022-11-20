using DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vocabulary.IRepository;

namespace Vocabulary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordController : ControllerBase
    {
        private IWordRepository _wordRepository;

        public WordController(IWordRepository wordRepository )
        {
            _wordRepository = wordRepository;
        }

        [HttpGet]
        [Route("GetWord")]
        public IEnumerable<Word> GetAllWord()
        {
            return _wordRepository.GetAll();
        }

        [HttpGet]
        [Route("GetWordById/{id}")]
        public async Task<IActionResult> GetWord(int id)
        {
            return Ok(await _wordRepository.GetById(id));
        }

        [HttpPost]
        [Route("AddWord")]
        public IActionResult AddWord(Word word)
        {
            return Ok(_wordRepository.Insert(word));
        }

    }
}
