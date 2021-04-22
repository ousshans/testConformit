using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProgrammationConformit.Models;

namespace TestProgrammationConformit.Data
{
    public interface ICommentaireRepo
    {
        IEnumerable<Commentaire> GetAllCommentaire();
        Commentaire GetCommentaireById(int id);
        void CreateCommentaire(Commentaire c);
        void UpdateCommentaire(Commentaire c);
        void DeleteCommentaire(int c);
    }
}
