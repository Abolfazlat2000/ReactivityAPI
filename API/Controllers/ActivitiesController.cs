using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Domain.Model;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _Context;
        public ActivitiesController(DataContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetAll() 
        {
            try
            {
                return await _Context.Activities.ToListAsync();
            }
            catch (Exception)
            {

                throw new InvalidOperationException("Invalid Operation");
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetById(Guid id)
        {
            try
            {
                return await _Context.Activities.FindAsync(id);
            }
            catch (Exception)
            {

                throw new InvalidOperationException("Invalid Operation");
            }
        }
    }
}
