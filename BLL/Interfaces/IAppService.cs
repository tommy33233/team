using System.Collections.Generic;
using BLL.EntitiesDTO;

namespace BLL.Interfaces
{
    public interface IAppService
    {
        List<PersonDTO> GetAllPersons();
        PersonDTO GetPersonById(int id);
    }
}
