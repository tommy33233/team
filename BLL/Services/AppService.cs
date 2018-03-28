using System.Collections.Generic;
using System.Linq;
using BLL.EntitiesDTO;
using BLL.Interfaces;
using DAL.Interfaces;

namespace BLL.Services
{
   public class AppService : IAppService
    {
        private IUnitOfWork db;
        public AppService(IUnitOfWork uow)
        {
            db = uow;
        }
        public List<PersonDTO> GetAllPersons()
        {
            var personBasesCore = db.PersonBases.GetAll();
            var persons = personBasesCore.Select(x=>PersonDTO.PersonToDTO(x)).ToList();

            return persons;
        }

       public PersonDTO GetPersonById(int id)
       {
           var personCore = db.PersonBases.Get(id);
           return PersonDTO.PersonToDTO(personCore);
       }
    }
}
