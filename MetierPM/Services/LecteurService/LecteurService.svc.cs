using MetierPM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

namespace MetierPM.Services.LecteurService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LecteurService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LecteurService.svc or LecteurService.svc.cs at the Solution Explorer and start debugging.
    public class LecteurService : ILecteurService
    {
        bdMemoireM1Context db = new bdMemoireM1Context();

        /// <summary>
        /// Méthode d'ajout de lecteur
        /// </summary>
        /// <param name="lecteur"></param>
        /// <returns></returns>
        public bool AddLecteur(Lecteur lecteur)
        {
            try
            {
                db.lecteurs.Add(lecteur);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("ServiceLecteur-AddLecteur", ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// Méthode de modification d'un lecteur
        /// </summary>
        /// <param name="lecteur"></param>
        /// <returns></returns>
        public bool UpdateLecteur(Lecteur lecteur)
        {
            try
            {
                var theLecteur = db.lecteurs.Find(lecteur.Id);

                if(theLecteur != null)
                {
                    theLecteur.Prenom = lecteur.Prenom;
                    theLecteur.Nom = lecteur.Nom;
                    theLecteur.Email = lecteur.Email;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Service-UpdateLecteur", ex.ToString());
                return false;
            }
            return false;
        }

        /// <summary>
        /// Suppression d'un lecteur
        /// </summary>
        /// <param name="idLecteur"></param>
        /// <returns></returns>
        public bool DeleteLecteur(int? idLecteur)
        {
            try
            {
                var theLecteur = db.lecteurs.Find(idLecteur);
                if (theLecteur != null)
                {
                    db.lecteurs.Remove(theLecteur);
                    db.SaveChanges();
                    return true;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Service1-DeleteLecteur", e.ToString());
                return false;
            }
            return false;
        }

        /// <summary>
        /// Liste des lecteurs
        /// </summary>
        /// <returns></returns>
        public List<Lecteur> GetAllLecteur()
        {
            return db.lecteurs.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idLecteur"></param>
        /// <returns></returns>
        public Lecteur GetLecteur(int? idLecteur)
        {
            return db.lecteurs.Find(idLecteur);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public List<Lecteur> GetLecteurs(string item)
        {
            var list = db.lecteurs.ToList();
            if (!string.IsNullOrEmpty(item))
            {
                string upperItem = item.ToUpper();

                list = list.Where(x =>
                x.Nom.ToUpper().Contains(upperItem) ||
                x.Prenom.ToUpper().Contains(upperItem)
                ).ToList();
            }

            return list;
        }
    }
}
