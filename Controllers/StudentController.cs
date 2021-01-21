using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
namespace automapper_sample.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private ApplicationDBContext _studentDTO;
        private readonly IMapper _mapper;
        List<Student> StudentList  = new List<Student>();
        public StudentController(IMapper mapper, ApplicationDBContext studentDTO)
        {  
            _mapper = mapper;
            _studentDTO = studentDTO;
        }

        // GET: api/<controller>
        //[HttpGet]
        //public Student Get()
        //{
        //    StudentDTO studentDTO = new StudentDTO()
        //    {
        //        Name = "Student 1",
        //        Age = 25,
        //        City = "Chicago",
        //        //Address = new AddressDTO ()
        //        //{
        //        //    State = "IL",
        //        //    Country = "US"
        //        //}
        //    };

        //    return _mapper.Map<Student>(studentDTO);
        //}


        public IActionResult Index()
        {
          //  StudentDTO studentDTO = new StudentDTO();
            //{
            //    Name = "Student 1",
            //    Age = 25,
            //    City = "Chicago",
            //    //Address = new AddressDTO ()
            //    //{
            //    //    State = "IL",
            //    //    Country = "US"
            //    //}
            //};
          //  _mapper.Map<Student>(studentDTO);
            foreach (var a in      _studentDTO.StudentDTO)
                StudentList.Add(_mapper.Map<Student>(a));

         //   Student.Add(_mapper.Map<Student>(studentDTO));
            return View(StudentList);
        }




    }
}
