//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disci_Hekim_Program.AdminServis {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AdminServis.AdminSoap")]
    public interface AdminSoap {
        
        // CODEGEN: Generating message contract since element name mail from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MailVarMi", ReplyAction="*")]
        Disci_Hekim_Program.AdminServis.MailVarMiResponse MailVarMi(Disci_Hekim_Program.AdminServis.MailVarMiRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MailVarMi", ReplyAction="*")]
        System.Threading.Tasks.Task<Disci_Hekim_Program.AdminServis.MailVarMiResponse> MailVarMiAsync(Disci_Hekim_Program.AdminServis.MailVarMiRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MailVarMiRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MailVarMi", Namespace="http://tempuri.org/", Order=0)]
        public Disci_Hekim_Program.AdminServis.MailVarMiRequestBody Body;
        
        public MailVarMiRequest() {
        }
        
        public MailVarMiRequest(Disci_Hekim_Program.AdminServis.MailVarMiRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MailVarMiRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string mail;
        
        public MailVarMiRequestBody() {
        }
        
        public MailVarMiRequestBody(string mail) {
            this.mail = mail;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MailVarMiResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MailVarMiResponse", Namespace="http://tempuri.org/", Order=0)]
        public Disci_Hekim_Program.AdminServis.MailVarMiResponseBody Body;
        
        public MailVarMiResponse() {
        }
        
        public MailVarMiResponse(Disci_Hekim_Program.AdminServis.MailVarMiResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MailVarMiResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool MailVarMiResult;
        
        public MailVarMiResponseBody() {
        }
        
        public MailVarMiResponseBody(bool MailVarMiResult) {
            this.MailVarMiResult = MailVarMiResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AdminSoapChannel : Disci_Hekim_Program.AdminServis.AdminSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdminSoapClient : System.ServiceModel.ClientBase<Disci_Hekim_Program.AdminServis.AdminSoap>, Disci_Hekim_Program.AdminServis.AdminSoap {
        
        public AdminSoapClient() {
        }
        
        public AdminSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdminSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Disci_Hekim_Program.AdminServis.MailVarMiResponse Disci_Hekim_Program.AdminServis.AdminSoap.MailVarMi(Disci_Hekim_Program.AdminServis.MailVarMiRequest request) {
            return base.Channel.MailVarMi(request);
        }
        
        public bool MailVarMi(string mail) {
            Disci_Hekim_Program.AdminServis.MailVarMiRequest inValue = new Disci_Hekim_Program.AdminServis.MailVarMiRequest();
            inValue.Body = new Disci_Hekim_Program.AdminServis.MailVarMiRequestBody();
            inValue.Body.mail = mail;
            Disci_Hekim_Program.AdminServis.MailVarMiResponse retVal = ((Disci_Hekim_Program.AdminServis.AdminSoap)(this)).MailVarMi(inValue);
            return retVal.Body.MailVarMiResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Disci_Hekim_Program.AdminServis.MailVarMiResponse> Disci_Hekim_Program.AdminServis.AdminSoap.MailVarMiAsync(Disci_Hekim_Program.AdminServis.MailVarMiRequest request) {
            return base.Channel.MailVarMiAsync(request);
        }
        
        public System.Threading.Tasks.Task<Disci_Hekim_Program.AdminServis.MailVarMiResponse> MailVarMiAsync(string mail) {
            Disci_Hekim_Program.AdminServis.MailVarMiRequest inValue = new Disci_Hekim_Program.AdminServis.MailVarMiRequest();
            inValue.Body = new Disci_Hekim_Program.AdminServis.MailVarMiRequestBody();
            inValue.Body.mail = mail;
            return ((Disci_Hekim_Program.AdminServis.AdminSoap)(this)).MailVarMiAsync(inValue);
        }
    }
}
