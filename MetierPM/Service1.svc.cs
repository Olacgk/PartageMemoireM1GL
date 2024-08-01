using MetierPM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MetierPM
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        bdMemoireM1Context db = new bdMemoireM1Context();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

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
        /// GetExperts retourne un expert en fonction du nom, du prenom ou de la specialite
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Prenom"></param>
        /// <param name="Specialite"></param>
        /// <returns></returns>
        public List<Expert> GetExperts(string Nom, string Prenom, string Specialite)
        {
            var liste = db.experts.ToList();
            if (!string.IsNullOrEmpty(Nom))
            {
                liste = liste.Where(x => x.Nom.ToUpper().Contains(Nom.ToUpper())).ToList();
            }

            if (!string.IsNullOrEmpty(Prenom))
            {
                liste = liste.Where(x => x.Prenom.ToUpper().Contains(Prenom.ToUpper())).ToList();
            }

            if (!string.IsNullOrEmpty(Specialite))
            {
                liste = liste.Where(x => x.Specialite.ToUpper().Contains(Specialite.ToUpper())).ToList();
            }

            return liste;
        }
    }
}
