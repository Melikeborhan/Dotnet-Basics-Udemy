using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;



    public class CourseController : Controller
    {
        
        //listeyi tekrar tekrar yazmank yerıne Listeyi en üstten tanımladık böylece hepsinin erişimi sağlanmıs oldu
        List<Course> kurslar = new List<Course>{
                new Course
                {
                    Id = 1,
                    Title = "Javascript kursu",
                    Image = "tel-1.jpg",
                    IsActive = true,
                    IsHome = true
                },
                new Course
                {
                    
                    Id = 2,
                    Title = "React kursu",
                    Image = "tel-2.jpg",
                    IsActive = true,
                    IsHome = false                },
                new Course
                {
                    Id = 3,
                    Title = "Javascript kursu",
                    Image = "tel-1.jpg",
                    IsActive = true,
                    IsHome = false
                },
                new Course
                {
                    Id = 4,
                    Title = "React kursu",
                    Image = "tel-2.jpg",
                    IsActive = true,
                    IsHome = true                },
                new Course
                {
                    Id = 5,
                    Title = "Javascript kursu",
                    Image = "tel-1.jpg",
                    IsActive = true,
                    IsHome = true
                },
                new Course
                {
                    Id = 6,
                    Title = "React kursu",
                    Image = "tel-2.jpg",
                    IsActive = true,
                    IsHome = true                },
                new Course
                {
                    Id = 7,
                    Title = "Javascript kursu",
                    Image = "tel-1.jpg",
                    IsActive = true,
                    IsHome = true
                },
                new Course
                {
                    Id = 8,
                    Title = "React kursu",
                    Image = "tel-2.jpg",
                    IsActive = true,
                    IsHome = false                },
                new Course
                {
                    Id = 9,
                    Title = "Javascript kursu",
                    Image = "tel-1.jpg",
                    IsActive = true,
                    IsHome = true
                },
                new Course
                {
                    Id = 10,
                    Title = "React kursu",
                    Image = "tel-2.jpg",
                    IsActive = true,
                    IsHome = false               
                     },
                new Course
                {
                    Id = 11,
                    Title = "Javascript kursu",
                    Image = "tel-1.jpg",
                    IsActive = true,
                    IsHome = true
                },
                new Course
                {
                    Id = 12,
                    Title = "React kursu",
                    Image = "tel-2.jpg",
                    IsActive = true,
                    IsHome = false            
                }
            };

        public ActionResult  Index()  
        {
            

            return View(kurslar);
        }

        
        //localhost:5052/course/list

        public ActionResult  List()
        {
            
          




            return View(kurslar);
        }
        

        //localhost:5052/course/details
        public ActionResult  Details(int id) //id o anda ulaşmak istediğimiz kursun id'si
        {
            
            Course? kurs = kurslar.Where(a => a.Id == id).FirstOrDefault();//bu method bu id ile eşleşen ilk kursu bulur ve onu döndürür. Eğer böyle bir kurs yoksa null döner.ToList() ise bütün listeyi döndürür.


            return View(kurs);
        }
    }
