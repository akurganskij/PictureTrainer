
//using Microsoft.EntityFrameworkCore;

//namespace PictureTrainer.Data
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class TasksController : ControllerBase
//    {
//        private DBContext dbContext;

//        public TasksController(DBContext dB)
//        {
//            dbContext = dB;
//        }

//        [HttpGet("{id:int}")]
//        public async Task<ActionResult<List<Tasks>>> GetTasks(int id)
//        {
//            return (await dbContext.tasks.ToListAsync()).Where(t => t.ImageId == id).ToList();

//        }

//        [HttpGet]
//        public async Task<ActionResult<List<Tasks>>> GetTasks()
//        {
//            return (await dbContext.tasks.ToListAsync());

//        }


//        [HttpPost]
//        public async Task<ActionResult<List<Tasks>>> PostTasks(List<Tasks> tasks)
//        {
//            if (tasks == null) return BadRequest(tasks);
//            await dbContext.tasks.AddRangeAsync(tasks);
//            await dbContext.SaveChangesAsync();
//            return Ok(tasks);
//        }
//    }
//}
