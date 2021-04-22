using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProgrammationConformit.Infrastructures;
using TestProgrammationConformit.Models;

namespace TestProgrammationConformit.Data.Impl
{
    public class EvementRepoImpl : IEvenementRepo
    {
        private readonly ConformitContext _context;

        public EvementRepoImpl(ConformitContext context)
        {
            _context = context;
        }
        void IEvenementRepo.CreateEvenement(Evenement e)
        {
            if (e == null) throw new ArgumentNullException(nameof(e));
            _context.Evenements.Add(e);
            _context.SaveChanges();
        }

        void IEvenementRepo.DeleteEvenement(int id)
        {
            var evenement = _context.Evenements.FirstOrDefault(p => p.Id == id);
            if (evenement == null)
            {
                throw new ArgumentNullException("Evenemt not found");
            }
            _context.Evenements.Remove(evenement);
        }

        IEnumerable<Evenement> IEvenementRepo.GetAllEvenement()
        {
            return _context.Evenements.ToList();
        }

        Evenement IEvenementRepo.GetEvenementById(int id)
        {
            return _context.Evenements.FirstOrDefault(p => p.Id == id);
        }

        void IEvenementRepo.UpdateEvenement(Evenement e)
        {
            if (e == null) throw new ArgumentNullException(nameof(e));
            _context.Evenements.Update(e);
            _context.SaveChanges();
        }
    }
}
