using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BirthdayRegister.Models
{
    public class Person
    {
        [Required(ErrorMessage ="İsim zorunlu alan")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Mail zorunlu alan")]
        [EmailAddress(ErrorMessage ="Mailinizi düzgün giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon zorunlu alan")]
        public string Phone { get; set; }

        public bool Confirm { get; set; }
    }
}
