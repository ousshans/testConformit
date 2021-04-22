using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProgrammationConformit.Models;

namespace TestProgrammationConformit.Data
{
    public interface IEvenementRepo
    {
        IEnumerable<Evenement> GetAllEvenement();
        Evenement GetEvenementById(int id);
        void CreateEvenement(Evenement e);
        void UpdateEvenement(Evenement e);
        void DeleteEvenement(int id );
    }
}
