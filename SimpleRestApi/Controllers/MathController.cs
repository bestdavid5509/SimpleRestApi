using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleRestApi.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class MathController : ControllerBase {
        [HttpGet("sum")]
        public IActionResult GetSum(int num1, int num2) {
            var result = num1 + num2;
            return Ok(new { sum = result });
        }
    }
}
