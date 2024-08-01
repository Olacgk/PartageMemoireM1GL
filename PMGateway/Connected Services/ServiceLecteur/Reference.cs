﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceLecteur
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Personne", Namespace="http://schemas.datacontract.org/2004/07/MetierPM.Model")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceLecteur.Lecteur))]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Lecteur", Namespace="http://schemas.datacontract.org/2004/07/MetierPM.Model")]
    public partial class Lecteur : ServiceLecteur.Personne
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceLecteur.ILecteurService")]
    public interface ILecteurService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILecteurService/AddLecteur", ReplyAction="http://tempuri.org/ILecteurService/AddLecteurResponse")]
        bool AddLecteur(ServiceLecteur.Lecteur lecteur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILecteurService/AddLecteur", ReplyAction="http://tempuri.org/ILecteurService/AddLecteurResponse")]
        System.Threading.Tasks.Task<bool> AddLecteurAsync(ServiceLecteur.Lecteur lecteur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILecteurService/UpdateLecteur", ReplyAction="http://tempuri.org/ILecteurService/UpdateLecteurResponse")]
        bool UpdateLecteur(ServiceLecteur.Lecteur lecteur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILecteurService/UpdateLecteur", ReplyAction="http://tempuri.org/ILecteurService/UpdateLecteurResponse")]
        System.Threading.Tasks.Task<bool> UpdateLecteurAsync(ServiceLecteur.Lecteur lecteur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILecteurService/DeleteLecteur", ReplyAction="http://tempuri.org/ILecteurService/DeleteLecteurResponse")]
        bool DeleteLecteur(System.Nullable<int> idLecteur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILecteurService/DeleteLecteur", ReplyAction="http://tempuri.org/ILecteurService/DeleteLecteurResponse")]
        System.Threading.Tasks.Task<bool> DeleteLecteurAsync(System.Nullable<int> idLecteur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILecteurService/GetAllLecteur", ReplyAction="http://tempuri.org/ILecteurService/GetAllLecteurResponse")]
        ServiceLecteur.Lecteur[] GetAllLecteur();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILecteurService/GetAllLecteur", ReplyAction="http://tempuri.org/ILecteurService/GetAllLecteurResponse")]
        System.Threading.Tasks.Task<ServiceLecteur.Lecteur[]> GetAllLecteurAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILecteurService/GetLecteur", ReplyAction="http://tempuri.org/ILecteurService/GetLecteurResponse")]
        ServiceLecteur.Lecteur GetLecteur(System.Nullable<int> idLecteur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILecteurService/GetLecteur", ReplyAction="http://tempuri.org/ILecteurService/GetLecteurResponse")]
        System.Threading.Tasks.Task<ServiceLecteur.Lecteur> GetLecteurAsync(System.Nullable<int> idLecteur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILecteurService/GetLecteurs", ReplyAction="http://tempuri.org/ILecteurService/GetLecteursResponse")]
        ServiceLecteur.Lecteur[] GetLecteurs(string item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILecteurService/GetLecteurs", ReplyAction="http://tempuri.org/ILecteurService/GetLecteursResponse")]
        System.Threading.Tasks.Task<ServiceLecteur.Lecteur[]> GetLecteursAsync(string item);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface ILecteurServiceChannel : ServiceLecteur.ILecteurService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class LecteurServiceClient : System.ServiceModel.ClientBase<ServiceLecteur.ILecteurService>, ServiceLecteur.ILecteurService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public LecteurServiceClient() : 
                base(LecteurServiceClient.GetDefaultBinding(), LecteurServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ILecteurService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LecteurServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(LecteurServiceClient.GetBindingForEndpoint(endpointConfiguration), LecteurServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LecteurServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(LecteurServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LecteurServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(LecteurServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LecteurServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public bool AddLecteur(ServiceLecteur.Lecteur lecteur)
        {
            return base.Channel.AddLecteur(lecteur);
        }
        
        public System.Threading.Tasks.Task<bool> AddLecteurAsync(ServiceLecteur.Lecteur lecteur)
        {
            return base.Channel.AddLecteurAsync(lecteur);
        }
        
        public bool UpdateLecteur(ServiceLecteur.Lecteur lecteur)
        {
            return base.Channel.UpdateLecteur(lecteur);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateLecteurAsync(ServiceLecteur.Lecteur lecteur)
        {
            return base.Channel.UpdateLecteurAsync(lecteur);
        }
        
        public bool DeleteLecteur(System.Nullable<int> idLecteur)
        {
            return base.Channel.DeleteLecteur(idLecteur);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteLecteurAsync(System.Nullable<int> idLecteur)
        {
            return base.Channel.DeleteLecteurAsync(idLecteur);
        }
        
        public ServiceLecteur.Lecteur[] GetAllLecteur()
        {
            return base.Channel.GetAllLecteur();
        }
        
        public System.Threading.Tasks.Task<ServiceLecteur.Lecteur[]> GetAllLecteurAsync()
        {
            return base.Channel.GetAllLecteurAsync();
        }
        
        public ServiceLecteur.Lecteur GetLecteur(System.Nullable<int> idLecteur)
        {
            return base.Channel.GetLecteur(idLecteur);
        }
        
        public System.Threading.Tasks.Task<ServiceLecteur.Lecteur> GetLecteurAsync(System.Nullable<int> idLecteur)
        {
            return base.Channel.GetLecteurAsync(idLecteur);
        }
        
        public ServiceLecteur.Lecteur[] GetLecteurs(string item)
        {
            return base.Channel.GetLecteurs(item);
        }
        
        public System.Threading.Tasks.Task<ServiceLecteur.Lecteur[]> GetLecteursAsync(string item)
        {
            return base.Channel.GetLecteursAsync(item);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ILecteurService))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ILecteurService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:61083/Services/LecteurService/LecteurService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return LecteurServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ILecteurService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return LecteurServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ILecteurService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ILecteurService,
        }
    }
}