using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VMT_BigSchools.Models;

namespace VMT_BigSchools.Controllers.Api
{
    public class CoursesController : ApiController
    {
        public ApplicationDbContext _dbContext { get; set; }

        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpDelete]
        public IHttpActionResult Cancel(int id)
        {
            var userId = User.Identity.GetUserId();
            var courses = _dbContext.Courses.Single(c => c.Id == id && c.LecturerId == userId);
            if (courses.IsCanceled)
                return NotFound();
            courses.IsCanceled = true;
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
