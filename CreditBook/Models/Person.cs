using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditBook.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите фамилию")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите отчество")]
        public string Patronymic { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите номер телефона")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите долг")]
        public double Credit { get; set; }
        public DateTime LastModifyData { get; set; }
    }
}
