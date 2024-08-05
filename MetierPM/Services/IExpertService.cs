using MetierPM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MetierPM.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IExpertService" in both code and config file together.
    [ServiceContract]
    public interface IExpertService
    {
      

        [OperationContract]
        bool AddExpert(Expert expert);

        [OperationContract]
        bool UpdateExpert(Expert expert);

        [OperationContract]
        bool DeleteExpert(int? idExpert);

        [OperationContract]
        List<Expert> GetAllExpert();

        [OperationContract]
        Expert GetExpert(int? idExpert);

        [OperationContract]
        List<Expert> GetExperts(string SearchItem);

        [OperationContract]
        Expert VerifyEmailAndPaswword(string Email);
    }
}
