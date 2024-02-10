//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace PictureTrainer.Data
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ImagesController : ControllerBase
//    {
//        private DBContext dbContext;

//        public ImagesController(DBContext dB)
//        {
//            dbContext = dB;
//        }

//        [HttpGet]
//        public async Task<ActionResult<List<Image>>> GetImages()
//        {
//            return (await dbContext.images.ToListAsync()).ToList();

//        }
//        [HttpGet("{id:int}")]
//        public async Task<ActionResult<Image>> GetImages(int id)
//        {
//            return await dbContext.images.FirstOrDefaultAsync(i => i.ProblemId == id);

//        }
//        [HttpPost]
//        public async Task<ActionResult<Image>> PostImage(Image image)
//        {
//            if (image == null) return BadRequest(image);
//            await dbContext.images.AddAsync(image);
//            await dbContext.SaveChangesAsync();
//            return Ok(image);
//        }
//    }
//}
