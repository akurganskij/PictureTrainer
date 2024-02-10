//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace PictureTrainer.Data
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProblemsController : ControllerBase
//    {
//        private DBContext dbContext;
//        public ProblemsController(DBContext dBContext)
//        {
//            this.dbContext = dBContext;
//        }
//        // GET: api/<ProblemsController>
//        [HttpGet]
//        public List<Problems> Get()
//        {
//            return dbContext.problems.ToList();
//        }

//        // GET api/<ProblemsController>/5
//        [HttpGet("{id}")]
//        public Problems Get(int id)
//        {
//            return dbContext.problems.ToList().FirstOrDefault(p => p.Id == id);
//        }

//        [HttpPost]
//        public async Task<ActionResult<Problems>> Post(Problems problems)
//        {
//            if(problems == null) return BadRequest(problems);
//            await dbContext.problems.AddAsync(problems);
//            await dbContext.SaveChangesAsync();
//            return Ok(problems);
//        }
//    }
//}
