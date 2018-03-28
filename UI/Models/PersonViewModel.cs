using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL.EntitiesDTO;

namespace UI.Models
{
    public class PersonViewModel
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Patronymic { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public static PersonDTO PersonToDTOFromView(PersonViewModel personViewModel)
        {
            PersonDTO person = new PersonDTO();
            if (personViewModel != null)
            {
                person.PersonId = personViewModel.PersonId;
                person.FirstName = personViewModel.FirstName;
                person.SecondName = personViewModel.SecondName;
                person.Patronymic = personViewModel.Patronymic;
                person.DateOfBirth = personViewModel.DateOfBirth;
            }
            return person;
        }

        public static PersonViewModel PersonToView(PersonDTO person)
        {
            PersonViewModel personViewModel = new PersonViewModel
            {
                PersonId = person.PersonId,
                FirstName = person.FirstName,
                SecondName = person.SecondName,
                Patronymic = person.Patronymic,
                DateOfBirth = person.DateOfBirth
            };
            return personViewModel;
        }
    }
}