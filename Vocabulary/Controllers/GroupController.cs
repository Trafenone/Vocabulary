using DataAccess.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vocabulary.IRepository;

namespace Vocabulary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class GroupController : ControllerBase
    {
        private readonly IGroupRepository _groupRepository;

        public GroupController(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        [HttpGet]
        [Route("GetGroup")]
        public async Task<IActionResult> GetAllGroup()
        { 
            return Ok(await _groupRepository.GetAll());
        }

        [HttpGet]
        [Route("GetGroupById/{id}")]
        public async Task<IActionResult> GetGroup(int id)
        {
            return Ok(await _groupRepository.GetById(id));
        }

        [HttpPost]
        [Route("AddGroup")]
        public async Task<IActionResult> Add([FromBody] Group group)
        {
            var result = await _groupRepository.Insert(group);
            if(result.Id == 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
            }
            return Ok("Added Successfully");
        }

        [HttpPut]
        [Route("UpdateGroup")]
        public async Task<IActionResult> Put(Group group)
        {
            await _groupRepository.Update(group);
            return Ok("Updated Successfully");
        }

        [HttpDelete]
        [Route("DeleteGroup")]
        public JsonResult Delete(int id)
        {
            _groupRepository.Delete(id);
            return new JsonResult("Deleted Successfully");
        }
    }
}
