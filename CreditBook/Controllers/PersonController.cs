using CreditBook.ContextFolder;
using CreditBook.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditBook.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult Index(int id=0)
        {
            ViewBag.Persons = new DataContext().Persons;
            var persons = new DataContext().Persons;
            if(id > 0)
            {
                var person = persons.Where(x => x.Id == id).First();
                ViewBag.Person = person;
                ViewBag.FIO = person.Surname + " " + person.Name[0] + "." + person.Patronymic[0] + ".";
            }
            else
            {
                var person = new Person();
                ViewBag.Person = person;
            }
            return View();
        }

        [HttpGet]
        public IActionResult IndexSearch(string name)
        {
            var persons = new DataContext().Persons;
            var person = persons.Where(x => x.Name.Contains(name) || x.Surname.Contains(name));
            ViewBag.Persons = person;
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Person person)
        {
            if (ModelState.IsValid)
            {
                using (var db = new DataContext())
                {
                    db.Persons.Add(person);
                    db.SaveChanges();
                }
                return Redirect("~/");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Reduce(string Id)
        {
            ViewBag.Id = int.Parse(Id);
            return View();
        }

        [HttpPost]
        public IActionResult GetCreditReduce(double creditReduce, int id)
        {
            var persons = new DataContext().Persons;
            var person = persons.Where(x => x.Id == id).First();
            person.Credit -= creditReduce;
            person.LastModifyData = DateTime.Now;
            using (var db = new DataContext())
            {
                db.Persons.Update(person);
                db.SaveChanges();
            }
            return Redirect("~/");
        }

        [HttpGet]
        public IActionResult Increase(string Id)
        {
            ViewBag.Id = int.Parse(Id);
            return View();
        }

        [HttpPost]
        public IActionResult GetCreditIncrease(double creditIncrease, int id)
        {
            var persons = new DataContext().Persons;
            var person = persons.Where(x => x.Id == id).First();
            person.Credit += creditIncrease;
            person.LastModifyData = DateTime.Now;
            using (var db = new DataContext())
            {
                db.Persons.Update(person);
                db.SaveChanges();
            }
            return Redirect("~/");
        }

        [HttpGet]
        public IActionResult Edit(string Id)
        {
            var persons = new DataContext().Persons;
            int id  = int.Parse(Id);
            var person = persons.Where(x => x.Id == id).First();
            ViewBag.Person = person;

            return View();
        }

        [HttpPost]
        public IActionResult Edit(Person person_new)
        {
            if (ModelState.IsValid)
            {
                var persons = new DataContext().Persons;
                var person = persons.Where(x => x.Id == person_new.Id).First();
                person.Surname = person_new.Surname;
                person.Name = person_new.Name;
                person.Patronymic = person_new.Patronymic;
                person.PhoneNumber = person_new.PhoneNumber;
                person.LastModifyData = DateTime.Now;

                using (var db = new DataContext())
                {
                    db.Persons.Update(person);
                    db.SaveChanges();
                }
                return Redirect("~/");
            }
            else
            {
                ViewBag.Person = person_new;
                return View();
            }
        }

        [HttpGet]
        public IActionResult Delete(string Id)
        {
            int id = int.Parse(Id);
            var persons = new DataContext().Persons;
            var person = persons.Where(x => x.Id == id).First();
            ViewBag.FIO = person.Surname + " " + person.Name[0] + "." + person.Patronymic[0] + ".";
            ViewBag.id = id;

            return View();
        }

        [HttpPost]
        public IActionResult GetCreditDelete(string surname, string name, string patronymic, string phoneNumber, int id)
        {
            var persons = new DataContext().Persons;
            var person = persons.Where(x => x.Id == id).First();
            person.Surname = surname;
            person.Name = name;
            person.Patronymic = patronymic;
            person.PhoneNumber = phoneNumber;
            person.LastModifyData = DateTime.Now;

            using (var db = new DataContext())
            {
                db.Persons.Remove(person);
                db.SaveChanges();
            }
            return Redirect("~/");
        }

    }
}
