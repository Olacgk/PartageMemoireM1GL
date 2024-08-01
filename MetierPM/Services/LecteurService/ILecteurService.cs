using MetierPM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MetierPM.Services.LecteurService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILecteurService" in both code and config file together.
    [ServiceContract]
    public interface ILecteurService
    {
        [OperationContract]
        bool AddLecteur(Lecteur lecteur);

        [OperationContract]
        bool UpdateLecteur(Lecteur lecteur);

        [OperationContract]
        bool DeleteLecteur(int? idLecteur);

        [OperationContract]
        List<Lecteur> GetAllLecteur();

        [OperationContract]
        Lecteur GetLecteur(int? idLecteur);

        [OperationContract]
        List<Lecteur> GetLecteurs(string item);
    }
}
