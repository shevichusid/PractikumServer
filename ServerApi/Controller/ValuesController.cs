using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repositories.Entities;
using Service.Interface;
using Service.Models;


namespace ServerApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IParentService _parentService;
        public ValuesController(IParentService parent)
        {
            _parentService = parent;
        }

        
        [HttpGet]
        //public async Task<IEnumerable<ParentModel>> Get()
        //{
        //    var result = await _parentService.GetAllAsync();
        //    return result;
        //}

        
        [HttpGet("{id}")]
        public async Task<ParentModel> GetByIdNumber(string id)
        {
            return await _parentService.GetByIdNumberAsync(id);
        }

        [HttpPost]
        public async Task<ParentModel> Post([FromBody] ParentModel parent)
        {
            return await _parentService.AddAsync(parent);
        }

        [HttpPut("{id}")]
        public async Task<ParentModel> Put([FromBody] ParentModel parent)
        {
            return await _parentService.UpdateAsync(parent);
        }
        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _parentService.DeleteAsync(id);
        }
    }
}