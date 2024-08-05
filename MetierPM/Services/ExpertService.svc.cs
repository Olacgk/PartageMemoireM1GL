using MetierPM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MetierPM.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ExpertService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ExpertService.svc or ExpertService.svc.cs at the Solution Explorer and start debugging.
    public class ExpertService : IExpertService
    {
        bdMemoireM1Context db = new bdMemoireM1Context();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expert"></param>
        /// <returns></returns>

        public bool AddExpert(Expert expert)
        {
            try
            {
                db.experts.Add(expert);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Service1-AddExpert", e.ToString());
                return false;
            }
        }

        /// <summary>
        /// Modification de l'expert
        /// </summary>
        /// <param name="expert"></param>
        /// <returns></returns>

        public bool UpdateExpert(Expert expert)
        {
            try
            {
                var lExpert = db.experts.Find(expert.Id);

                if (lExpert != null)
                {
                    lExpert.Prenom = expert.Prenom;
                    lExpert.Nom = expert.Nom;
                    lExpert.Email = expert.Email;
                    lExpert.Specialite = expert.Specialite;
                    db.SaveChanges();
                    return true;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Service1-UpdateExpert", e.ToString());
                return false;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idExpert"></param>
        /// <returns></returns>
        public bool DeleteExpert(int? idExpert)
        {
            try
            {
                var lExpert = db.experts.Find(idExpert);
                if (lExpert != null)
                {
                    db.experts.Remove(lExpert);
                    db.SaveChanges();
                    return true;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Service1-DeleteExpert", e.ToString());
                return false;
            }
            return false;
        }

        /// <summary>
        /// GetAllExpert retourne la liste de tous les experts
        /// </summary>
        /// <returns></returns>
        public List<Expert> GetAllExpert()
        {
            return db.experts.ToList();
        }

        /// <summary>
        /// GetExpert retourne un expert en fonction de son id
        /// </summary>
        /// <param name="idExpert"></param>
        /// <returns></returns>
        public Expert GetExpert(int? idExpert)
        {
            return db.experts.Find(idExpert);
        }

        /// <summary>
        /// GetExperts retourne un expert en fonction du string envoyé
        /// </summary>
        /// <param name="SearchItem"></param>
        /// <returns></returns>
        public List<Expert> GetExperts(string SearchItem)
        {
            var liste = db.experts.ToList();
            if (!string.IsNullOrEmpty(SearchItem))
            {
                // Convert searchTerm to uppercase for case-insensitive comparison
                string upperSearchTerm = SearchItem.ToUpper();

                // Filter the list based on the searchTerm
                liste = liste.Where(x =>
                    x.Nom.ToUpper().Contains(upperSearchTerm) ||
                    x.Prenom.ToUpper().Contains(upperSearchTerm) ||
                    x.Specialite.ToUpper().Contains(upperSearchTerm)
                ).ToList();
            }

                return liste;
        }

        public Expert VerifyEmailAndPaswword(string Email)
        {
            try
            {
                var user = db.experts.SingleOrDefault(x => x.Email == Email);
                return user;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
