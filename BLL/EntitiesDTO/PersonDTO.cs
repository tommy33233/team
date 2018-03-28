using System;
using DAL.Entities;

namespace BLL.EntitiesDTO
{
    public class PersonDTO
    {
        #region Properties

        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Patronymic { get; set; }
        public DateTime? DateOfBirth { get; set; }

        #endregion

        public static PersonBase PersonToCore(PersonDTO personDto)
        {
            PersonBase person = new PersonBase();
            if (personDto != null)
            {
                person.PersonId = personDto.PersonId;
                person.FirstName = personDto.FirstName;
                person.SecondName = personDto.SecondName;
                person.Patronymic = personDto.Patronymic;
                person.DateOfBirth = personDto.DateOfBirth;
            }
            return person;
        }

        public static PersonDTO PersonToDTO(PersonBase person)
        {
            PersonDTO personDTO = new PersonDTO
            {
                PersonId = person.PersonId,
                FirstName = person.FirstName,
                SecondName = person.SecondName,
                Patronymic = person.Patronymic,
                DateOfBirth = person.DateOfBirth
            };
            return personDTO;
        }
    }
}
