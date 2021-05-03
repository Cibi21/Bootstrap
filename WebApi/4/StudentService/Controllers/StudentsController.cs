using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentService.Models;

namespace StudentService.Controllers
{
    public class StudentsController : ApiController
    {
        StudentDBContext db = new StudentDBContext();
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, db.Students.ToList());
        }
        public HttpResponseMessage Get(int id)
        {

            var k = db.Students.Where(c => c.ID == id).SingleOrDefault();

            if (k != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, k, "application/json");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Student with Id " + id + " not found");
            }
        }
        [HttpPost]
        public HttpResponseMessage Post([FromBody] Student student)
        {
            try
            {
                db.Students.Add(student);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.Created, student);

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }
        [HttpPut]
        public HttpResponseMessage Put(int id, [FromBody] Student student)
        {

            var k = db.Students.Where(c => c.ID == id).SingleOrDefault();
            try
            {
                if (k == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Student with Id " + id + " not found");
                }
                else
                {
                    k.FirstName = student.FirstName;
                    k.LastName = student.LastName;
                    k.Gender = student.Gender;
                    k.Address = student.Address;
                    db.SaveChanges();
                    return Request.CreateResponse<Student>(HttpStatusCode.OK, k, "application/json");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var k = db.Students.Where(c => c.ID == id).FirstOrDefault();
                if (k == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Student with Id " + id + " not found");
                }
                else
                {
                    db.Students.Remove(k);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
