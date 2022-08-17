using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyThirdApiController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetModelData()
        {
            LMS.web.Models.Category category = new Models.Category()
            {
                CategoryId = 1,
                CategoryName = "First Category",
                Books = new LMS.web.Models.Book[]
                {
                    new Models.Book {
                        BookId = 1,
                        Title = "First Book",
                        CategoryId = 1,
                        Authors = new LMS.web.Models.Author[] {
                            new Models.Author { AuthorId = 1, AuthorName = "First Author", BookId = 1}
                        }
                    }
                }
            };

            return Ok(category);
        }
    }
}
