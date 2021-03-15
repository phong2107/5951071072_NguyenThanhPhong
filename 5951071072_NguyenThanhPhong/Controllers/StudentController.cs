using _5951071072_NguyenThanhPhong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5951071072_NguyenThanhPhong.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var StuList = new List<StudentInfo>();
            for (int i = 0; i < 10; i++)
            {
                var student = new StudentInfo
                {
                    idStu = i.ToString(),
                    NameStu = $"student {i}",
                    SdtStu = $" {i}" + $" {i + 1}" + $" {i + 3}" + $" {i + 12}" + $" {i + 1}" + $" {i + 2}" + $" {i + 2}" + $" {i}"
                };
                StuList.Add(student);
            }
                return StuList;
        }

        // GET: api/Student/5
        public StudentInfo Get(int id)
        {
            if (id == 1) return new StudentInfo
            {
                NameStu = "Nguyen Thanh Phong",
                SdtStu = "242564671232",
                idStu = "5951071072"
            };

            return new StudentInfo
            {
                idStu = id.ToString(),
                NameStu = $"student {id}",
                SdtStu = $" {id}" + $" {id + 1}" + $" {id + 3}" + $" {id + 12}" + $" {id + 1}" + $" {id + 2}" + $" {id + 2}" + $" {id}"


            };
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
