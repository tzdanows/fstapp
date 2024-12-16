using Microsoft.AspNetCore.Mvc;
using JobSite.API.Models;

namespace JobSite.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JobsController : ControllerBase
{
    private static readonly string[] Companies = new[]
    {
        "Facebook", "Amazon", "Apple", "Netflix", "Google", "Paylocity"
    };

    [HttpGet]
    public IActionResult GetJobs()
    {
        var rng = new Random();
        var jobs = Enumerable.Range(1, 5).Select(index => new Job
        {
            Id = index,
            Title = $"Software Engineer {index}",
            Company = Companies[rng.Next(Companies.Length)],
            Location = "Remote",
            Description = "We are looking for a Full Stack software engineer with flexibility towards cloud native development.",
            CreatedAt = DateTime.Now.AddDays(-index)
        })
        .ToArray();

        return Ok(jobs);
    }
}