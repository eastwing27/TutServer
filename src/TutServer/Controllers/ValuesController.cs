using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TutServer.Models;
using Newtonsoft.Json;
using TutServer.DTO;

namespace TutServer.Controllers
{
    [Route("")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return new RedirectResult("~/index.html");
        }

        [HttpGet]
        [Route("data")]
        public IActionResult GetData()
        {
            return new JsonResult(JsonModel.Answers);
        }

        [HttpPost]
        [Route("answer")]
        public IActionResult AddAnswer([FromBody] PostDTO dto)
        {
            JsonModel.Answers.Add(new Answer()
            {
                Author = dto.Author,
                Content = dto.Content,
                Rating = 0,
                Date = DateTime.UtcNow
            });

            JsonModel.Save();

            return new OkResult();
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
