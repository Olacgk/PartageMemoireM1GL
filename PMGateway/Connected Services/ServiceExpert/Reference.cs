﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceExpert
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Personne", Namespace="http://schemas.datacontract.org/2004/07/MetierPM.Model")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceExpert.Expert))]
    public partial class Personne : object
    {
        
        private string EmailField;
        
        private int IdField;
        
        private string NomField;
        
        private string PrenomField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom
        {
            get
            {
                return this.NomField;
            }
            set
            {
                this.NomField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Prenom
        {
            get
            {
                return this.PrenomField;
            }
            set
            {
                this.PrenomField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Expert", Namespace="http://schemas.datacontract.org/2004/07/MetierPM.Model")]
    public partial class Expert : ServiceExpert.Personne
    {
        
        private string SpecialiteField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Specialite
        {
            get
            {
                return this.SpecialiteField;
            }
            set
            {
                this.SpecialiteField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceExpert.IExpertService")]
    public interface IExpertService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpertService/AddExpert", ReplyAction="http://tempuri.org/IExpertService/AddExpertResponse")]
        bool AddExpert(ServiceExpert.Expert expert);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpertService/AddExpert", ReplyAction="http://tempuri.org/IExpertService/AddExpertResponse")]
        System.Threading.Tasks.Task<bool> AddExpertAsync(ServiceExpert.Expert expert);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpertService/UpdateExpert", ReplyAction="http://tempuri.org/IExpertService/UpdateExpertResponse")]
        bool UpdateExpert(ServiceExpert.Expert expert);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpertService/UpdateExpert", ReplyAction="http://tempuri.org/IExpertService/UpdateExpertResponse")]
        System.Threading.Tasks.Task<bool> UpdateExpertAsync(ServiceExpert.Expert expert);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpertService/DeleteExpert", ReplyAction="http://tempuri.org/IExpertService/DeleteExpertResponse")]
        bool DeleteExpert(System.Nullable<int> idExpert);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpertService/DeleteExpert", ReplyAction="http://tempuri.org/IExpertService/DeleteExpertResponse")]
        System.Threading.Tasks.Task<bool> DeleteExpertAsync(System.Nullable<int> idExpert);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpertService/GetAllExpert", ReplyAction="http://tempuri.org/IExpertService/GetAllExpertResponse")]
        ServiceExpert.Expert[] GetAllExpert();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpertService/GetAllExpert", ReplyAction="http://tempuri.org/IExpertService/GetAllExpertResponse")]
        System.Threading.Tasks.Task<ServiceExpert.Expert[]> GetAllExpertAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpertService/GetExpert", ReplyAction="http://tempuri.org/IExpertService/GetExpertResponse")]
        ServiceExpert.Expert GetExpert(System.Nullable<int> idExpert);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpertService/GetExpert", ReplyAction="http://tempuri.org/IExpertService/GetExpertResponse")]
        System.Threading.Tasks.Task<ServiceExpert.Expert> GetExpertAsync(System.Nullable<int> idExpert);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpertService/GetExperts", ReplyAction="http://tempuri.org/IExpertService/GetExpertsResponse")]
        ServiceExpert.Expert[] GetExperts(string SearchItem);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpertService/GetExperts", ReplyAction="http://tempuri.org/IExpertService/GetExpertsResponse")]
        System.Threading.Tasks.Task<ServiceExpert.Expert[]> GetExpertsAsync(string SearchItem);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface IExpertServiceChannel : ServiceExpert.IExpertService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class ExpertServiceClient : System.ServiceModel.ClientBase<ServiceExpert.IExpertService>, ServiceExpert.IExpertService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ExpertServiceClient() : 
                base(ExpertServiceClient.GetDefaultBinding(), ExpertServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IExpertService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ExpertServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(ExpertServiceClient.GetBindingForEndpoint(endpointConfiguration), ExpertServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ExpertServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ExpertServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ExpertServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ExpertServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ExpertServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public bool AddExpert(ServiceExpert.Expert expert)
        {
            return base.Channel.AddExpert(expert);
        }
        
        public System.Threading.Tasks.Task<bool> AddExpertAsync(ServiceExpert.Expert expert)
        {
            return base.Channel.AddExpertAsync(expert);
        }
        
        public bool UpdateExpert(ServiceExpert.Expert expert)
        {
            return base.Channel.UpdateExpert(expert);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateExpertAsync(ServiceExpert.Expert expert)
        {
            return base.Channel.UpdateExpertAsync(expert);
        }
        
        public bool DeleteExpert(System.Nullable<int> idExpert)
        {
            return base.Channel.DeleteExpert(idExpert);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteExpertAsync(System.Nullable<int> idExpert)
        {
            return base.Channel.DeleteExpertAsync(idExpert);
        }
        
        public ServiceExpert.Expert[] GetAllExpert()
        {
            return base.Channel.GetAllExpert();
        }
        
        public System.Threading.Tasks.Task<ServiceExpert.Expert[]> GetAllExpertAsync()
        {
            return base.Channel.GetAllExpertAsync();
        }
        
        public ServiceExpert.Expert GetExpert(System.Nullable<int> idExpert)
        {
            return base.Channel.GetExpert(idExpert);
        }
        
        public System.Threading.Tasks.Task<ServiceExpert.Expert> GetExpertAsync(System.Nullable<int> idExpert)
        {
            return base.Channel.GetExpertAsync(idExpert);
        }
        
        public ServiceExpert.Expert[] GetExperts(string SearchItem)
        {
            return base.Channel.GetExperts(SearchItem);
        }
        
        public System.Threading.Tasks.Task<ServiceExpert.Expert[]> GetExpertsAsync(string SearchItem)
        {
            return base.Channel.GetExpertsAsync(SearchItem);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IExpertService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IExpertService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:61083/Services/ExpertService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ExpertServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IExpertService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ExpertServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IExpertService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IExpertService,
        }
    }
}