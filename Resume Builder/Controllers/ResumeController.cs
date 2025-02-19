//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace Resume_Builder.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ResumeBuilder : ControllerBase
//    {
//    }
//}


using Infrastructrer.Context;
using Infrastructrer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Resume_Builder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize]
    public class ResumeController : ControllerBase
    {
        private readonly ResumeContext _context;

        public ResumeController(ResumeContext context)
        {
            _context = context;
        }

        // GET: api/Resume
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Resume>>> GetResumes()
        {
            var userId = User.Identity.Name;
            return await _context.Resumes.Where(r => r.UserId == userId).ToListAsync();
        }

        // GET: api/Resume/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Resume>> GetResume(int id)
        {
            var resume = await _context.Resumes.FindAsync(id);

            if (resume == null || resume.UserId != User.Identity.Name)
            {
                return NotFound();
            }

            return resume;
        }

        // POST: api/Resume
        [HttpPost]
        public async Task<ActionResult<Resume>> PostResume(Resume resume)
        {
            //resume.UserId = User.Identity.Name;
            resume.UserId = "Admin";
            _context.Resumes.Add(resume);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetResume), new { id = resume.Id }, resume);
        }

        // PUT: api/Resume/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResume(int id, Resume resume)
        {
            if (id != resume.Id || resume.UserId != User.Identity.Name)
            {
                return BadRequest();
            }

            _context.Entry(resume).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Resume/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResume(int id)
        {
            var resume = await _context.Resumes.FindAsync(id);
            if (resume == null || resume.UserId != User.Identity.Name)
            {
                return NotFound();
            }

            _context.Resumes.Remove(resume);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}