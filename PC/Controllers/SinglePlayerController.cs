using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PC.DataLayer;
using PC.Models;

namespace PC.Controllers
{
    public class SinglePlayerController : Controller
    {
        private PcDbContext DbContext;
        public SinglePlayerController(PcDbContext pcDbContext)
        {
            DbContext = pcDbContext;
        }
        // GET
        [Authorize]
        [Route("{controller}/")]
        public async Task<IActionResult> SinglePlayer()
        {
            var response = await DbContext.Set<UserScore>().FirstOrDefaultAsync(n => n.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier));
            if (response == null)
            {
                var record = new UserScore
                {
                    UserId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                    TimeStamp = DateTime.UtcNow,
                    EvaCost = 10,
                    NewtonCost = 50,
                    JobsCost = 100,
                    EvaCount = 0,
                    NewtonCount = 0,
                    JobsCount = 0,
                    Score = 1
                };
                DbContext.Add(record);
                DbContext.SaveChanges();
                response = record;
            }
            var model = new SinglePlayerViewModel
            {
                EvaCost = response.EvaCost,
                EvaCount = response.EvaCount,
                JobsCost = response.JobsCost,
                JobsCount = response.JobsCount,
                NewtonCost = response.NewtonCost,
                NewtonCount = response.NewtonCount,
                Score = response.Score
            };
            return View(model);
        }

        [Route("{controller}/{action}")]
        [HttpPost]
        public async Task postData([FromForm] userSaveData data)
        {
            var  userRecord = await DbContext.Set<UserScore>().FirstOrDefaultAsync((n => n.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier)));
            userRecord.EvaCount = data.EvaCount;
            userRecord.EvaCost = data.EvaCost;
            userRecord.JobsCount = data.JobsCount;
            userRecord.JobsCost = data.JobsCost;
            userRecord.NewtonCount = data.NewtonCount;
            userRecord.NewtonCount = data.NewtonCount;
            userRecord.Score = data.Score;
            userRecord.TimeStamp = DateTime.UtcNow;
            DbContext.Entry(userRecord).State = EntityState.Modified;
            DbContext.SaveChanges();
        }
    }
}