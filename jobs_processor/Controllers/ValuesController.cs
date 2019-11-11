using System;
using System.Collections.Generic;
using Hangfire;
using Microsoft.AspNetCore.Mvc;

namespace jobs_processor.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ValuesController : ControllerBase
  {
    private readonly IBackgroundJobClient _jobClient;
    public ValuesController(IBackgroundJobClient jobClient)
    {
      _jobClient = jobClient ?? throw new ArgumentNullException(nameof(jobClient));
    }

    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      _jobClient.Enqueue(() => RaiseException());
      return new string[] { "value1", "value2" };
    }

    public void RaiseException() => throw new ArgumentException("Error had been thrown");
  }
}
