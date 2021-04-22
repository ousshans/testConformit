using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProgrammationConformit.Infrastructures;
using TestProgrammationConformit.Models;

namespace TestProgrammationConformit.Data.Impl
{
    public class CommentaireRepoImpl : ICommentaireRepo
    {
        private readonly ConformitContext _context;

        public CommentaireRepoImpl(ConformitContext context)
        {
            _context = context;
        }
        void ICommentaireRepo.CreateCommentaire(Commentaire c)
        {
            if (c == null) throw new ArgumentNullException(nameof(c));
            _context.Commentaires.Add(c);
            _context.SaveChanges();
        }

        void ICommentaireRepo.DeleteCommentaire(int c)
        {
            Commentaire commentaire = _context.Commentaires.FirstOrDefault(p => p.Id == c);
            if (commentaire == null)
            {
                throw new ArgumentNullException(nameof(c));
            }
            _context.Commentaires.Remove(commentaire);
        }

        IEnumerable<Commentaire> ICommentaireRepo.GetAllCommentaire()
        {
            return _context.Commentaires.ToList();
        }

        Commentaire ICommentaireRepo.GetCommentaireById(int id)
        {
            return _context.Commentaires.FirstOrDefault(p => p.Id == id);
        }

        void ICommentaireRepo.UpdateCommentaire(Commentaire c)
        {
            if (e == null) throw new ArgumentNullException(nameof(c));
            _context.Commentaires.Update(c);
            _context.SaveChanges();
        }
    }
}
