using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Soccer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    [HttpGet]
    [Authorize]
    public IEnumerable<string> FindAll()
    {
        return new string[] { "Andril", "Vishnu" };
    }

    [HttpGet("{id}")]
    public string FindOne(int id)
    {
        return string.Concat("Name is ", id);
    }
}
