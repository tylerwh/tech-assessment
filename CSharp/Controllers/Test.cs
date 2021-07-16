using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CSharp.Controllers
{
	[ApiController]
    [Route("[controller]")]
	public class Test : ControllerBase
	{
		[HttpGet]
		public string Get()
		{
			return "Success!";
		}
	}
}
