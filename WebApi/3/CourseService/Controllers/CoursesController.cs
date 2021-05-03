using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CourseService.Models;

namespace CourseService.Controllers
{
    public class CoursesController : ApiController
    {
        static List<Course> courses = new List<Course>()
        {
            new Course(){CourseId=1,CourseName="Android",Trainer="Shawn",Fees=12000,
                CourseDescription="Android is a mobile operating system dev"},
            
            new Course(){CourseId=2,CourseName="ASP.Net",Trainer="Kevin",Fees=20000,
                CourseDescription="ASP .NET is a open source web development framework"},
            
            new Course(){CourseId=3, CourseName="JSP", Trainer="Debaratha",Fees=10000,
                CourseDescription ="Java server pages is a technology used for web page creations" },
           
            new Course(){CourseId=4, CourseName="Xamarin.forms", Trainer="Mark John",Fees=15000,
                CourseDescription="Xamarin forms are cross platform UI tools" }
        };
        public HttpResponseMessage Get([FromUri] string coursename)
        {
            var findedCourse = courses.Where(c => c.CourseName == coursename).SingleOrDefault();
            if (findedCourse == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Course Name " + coursename + " not found");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, findedCourse, "application/json");
            }
        }
        
        [HttpPost]
        public HttpResponseMessage Post([FromBody] Course course)
        {
            courses.Add(course);
            return Request.CreateResponse(HttpStatusCode.OK, course);
        }
    }
}

