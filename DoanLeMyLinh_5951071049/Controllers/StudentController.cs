
using DoanLeMyLinh_5951071049.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DoanLeMyLinh_5951071049.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<Student> Get()
        {
            var studentList = new List<Student>();
            // for (int i = 0; i < 10; i++)
            // {
            var student = new Student
            {
                Lop = "CQ.59.CNTT",
                Ten = "Doan Le My Linh",
                Mssv = "5951071049",
                DiaChi = "Ho Chi Minh City",
                Datetime = DateTime.Now.ToUniversalTime()
            };
            studentList.Add(student);
            //  }
            return studentList;
        }

        // GET: api/Student/5
        public Student Get(int id)
        {
            return new Student
            {
                Lop = "CQ.59.CNTT",
                Ten = "Doan Le My Linh",
                Mssv = "5951071049",
                DiaChi = "Ho Chi Minh City",
                Datetime = DateTime.Now.ToUniversalTime()
            };
        }

        // POST: api/Student
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
