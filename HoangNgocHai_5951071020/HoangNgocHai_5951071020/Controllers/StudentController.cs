using HoangNgocHai_5951071020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HoangNgocHai_5951071020.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var studentInfoList = new List<StudentInfo>();
            for (int i = 0; i < 10; i++)
            {
                var studentInfo = new StudentInfo
                {
                    MSV = $"{5951071000 + i}",
                    Name = "Hoang Ngoc Hai",
                    Birthday = DateTime.Parse("2000/07/10"),
                    Address = "Ha Tinh",
                    Phone = "12345678"
                };
                studentInfoList.Add(studentInfo);
            }
            return studentInfoList;
        }

        // GET: api/Student/5
        public StudentInfo Get(string id)
        {
            return new StudentInfo
            {
                MSV = $"{id}",
                Name = "Hoang Ngoc Hai",
                Birthday = DateTime.Parse("2000/07/10"),
                Address = "Ha Tinh",
                Phone = "12345678"
            };
        }
    }
}
