﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disci_Hekim_Program.HizmetServis {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Hizmet", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Hizmet : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HizmetAdiField;
        
        private System.Nullable<double> BirimFiyatField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string HizmetAdi {
            get {
                return this.HizmetAdiField;
            }
            set {
                if ((object.ReferenceEquals(this.HizmetAdiField, value) != true)) {
                    this.HizmetAdiField = value;
                    this.RaisePropertyChanged("HizmetAdi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.Nullable<double> BirimFiyat {
            get {
                return this.BirimFiyatField;
            }
            set {
                if ((this.BirimFiyatField.Equals(value) != true)) {
                    this.BirimFiyatField = value;
                    this.RaisePropertyChanged("BirimFiyat");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HizmetServis.Hizmetler1Soap")]
    public interface Hizmetler1Soap {
        
        // CODEGEN: Generating message contract since element name HizmetListeleResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HizmetListele", ReplyAction="*")]
        Disci_Hekim_Program.HizmetServis.HizmetListeleResponse HizmetListele(Disci_Hekim_Program.HizmetServis.HizmetListeleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HizmetListele", ReplyAction="*")]
        System.Threading.Tasks.Task<Disci_Hekim_Program.HizmetServis.HizmetListeleResponse> HizmetListeleAsync(Disci_Hekim_Program.HizmetServis.HizmetListeleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BirimFiyatGetir", ReplyAction="*")]
        double BirimFiyatGetir(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BirimFiyatGetir", ReplyAction="*")]
        System.Threading.Tasks.Task<double> BirimFiyatGetirAsync(int id);
        
        // CODEGEN: Generating message contract since element name HizmetAdiGetirResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HizmetAdiGetir", ReplyAction="*")]
        Disci_Hekim_Program.HizmetServis.HizmetAdiGetirResponse HizmetAdiGetir(Disci_Hekim_Program.HizmetServis.HizmetAdiGetirRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HizmetAdiGetir", ReplyAction="*")]
        System.Threading.Tasks.Task<Disci_Hekim_Program.HizmetServis.HizmetAdiGetirResponse> HizmetAdiGetirAsync(Disci_Hekim_Program.HizmetServis.HizmetAdiGetirRequest request);
        
        // CODEGEN: Generating message contract since element name hizmetadi from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HizmetEkle", ReplyAction="*")]
        Disci_Hekim_Program.HizmetServis.HizmetEkleResponse HizmetEkle(Disci_Hekim_Program.HizmetServis.HizmetEkleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HizmetEkle", ReplyAction="*")]
        System.Threading.Tasks.Task<Disci_Hekim_Program.HizmetServis.HizmetEkleResponse> HizmetEkleAsync(Disci_Hekim_Program.HizmetServis.HizmetEkleRequest request);
        
        // CODEGEN: Generating message contract since element name hizmetadi from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HizmetGuncelle", ReplyAction="*")]
        Disci_Hekim_Program.HizmetServis.HizmetGuncelleResponse HizmetGuncelle(Disci_Hekim_Program.HizmetServis.HizmetGuncelleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HizmetGuncelle", ReplyAction="*")]
        System.Threading.Tasks.Task<Disci_Hekim_Program.HizmetServis.HizmetGuncelleResponse> HizmetGuncelleAsync(Disci_Hekim_Program.HizmetServis.HizmetGuncelleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HizmetSil", ReplyAction="*")]
        void HizmetSil(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HizmetSil", ReplyAction="*")]
        System.Threading.Tasks.Task HizmetSilAsync(int id);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HizmetListeleRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HizmetListele", Namespace="http://tempuri.org/", Order=0)]
        public Disci_Hekim_Program.HizmetServis.HizmetListeleRequestBody Body;
        
        public HizmetListeleRequest() {
        }
        
        public HizmetListeleRequest(Disci_Hekim_Program.HizmetServis.HizmetListeleRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HizmetListeleRequestBody {
        
        public HizmetListeleRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HizmetListeleResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HizmetListeleResponse", Namespace="http://tempuri.org/", Order=0)]
        public Disci_Hekim_Program.HizmetServis.HizmetListeleResponseBody Body;
        
        public HizmetListeleResponse() {
        }
        
        public HizmetListeleResponse(Disci_Hekim_Program.HizmetServis.HizmetListeleResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HizmetListeleResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Disci_Hekim_Program.HizmetServis.Hizmet[] HizmetListeleResult;
        
        public HizmetListeleResponseBody() {
        }
        
        public HizmetListeleResponseBody(Disci_Hekim_Program.HizmetServis.Hizmet[] HizmetListeleResult) {
            this.HizmetListeleResult = HizmetListeleResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HizmetAdiGetirRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HizmetAdiGetir", Namespace="http://tempuri.org/", Order=0)]
        public Disci_Hekim_Program.HizmetServis.HizmetAdiGetirRequestBody Body;
        
        public HizmetAdiGetirRequest() {
        }
        
        public HizmetAdiGetirRequest(Disci_Hekim_Program.HizmetServis.HizmetAdiGetirRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HizmetAdiGetirRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public HizmetAdiGetirRequestBody() {
        }
        
        public HizmetAdiGetirRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HizmetAdiGetirResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HizmetAdiGetirResponse", Namespace="http://tempuri.org/", Order=0)]
        public Disci_Hekim_Program.HizmetServis.HizmetAdiGetirResponseBody Body;
        
        public HizmetAdiGetirResponse() {
        }
        
        public HizmetAdiGetirResponse(Disci_Hekim_Program.HizmetServis.HizmetAdiGetirResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HizmetAdiGetirResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HizmetAdiGetirResult;
        
        public HizmetAdiGetirResponseBody() {
        }
        
        public HizmetAdiGetirResponseBody(string HizmetAdiGetirResult) {
            this.HizmetAdiGetirResult = HizmetAdiGetirResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HizmetEkleRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HizmetEkle", Namespace="http://tempuri.org/", Order=0)]
        public Disci_Hekim_Program.HizmetServis.HizmetEkleRequestBody Body;
        
        public HizmetEkleRequest() {
        }
        
        public HizmetEkleRequest(Disci_Hekim_Program.HizmetServis.HizmetEkleRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HizmetEkleRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string hizmetadi;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public double birimfiyat;
        
        public HizmetEkleRequestBody() {
        }
        
        public HizmetEkleRequestBody(string hizmetadi, double birimfiyat) {
            this.hizmetadi = hizmetadi;
            this.birimfiyat = birimfiyat;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HizmetEkleResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HizmetEkleResponse", Namespace="http://tempuri.org/", Order=0)]
        public Disci_Hekim_Program.HizmetServis.HizmetEkleResponseBody Body;
        
        public HizmetEkleResponse() {
        }
        
        public HizmetEkleResponse(Disci_Hekim_Program.HizmetServis.HizmetEkleResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HizmetEkleResponseBody {
        
        public HizmetEkleResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HizmetGuncelleRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HizmetGuncelle", Namespace="http://tempuri.org/", Order=0)]
        public Disci_Hekim_Program.HizmetServis.HizmetGuncelleRequestBody Body;
        
        public HizmetGuncelleRequest() {
        }
        
        public HizmetGuncelleRequest(Disci_Hekim_Program.HizmetServis.HizmetGuncelleRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HizmetGuncelleRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string hizmetadi;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public double birimfiyat;
        
        public HizmetGuncelleRequestBody() {
        }
        
        public HizmetGuncelleRequestBody(int id, string hizmetadi, double birimfiyat) {
            this.id = id;
            this.hizmetadi = hizmetadi;
            this.birimfiyat = birimfiyat;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HizmetGuncelleResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HizmetGuncelleResponse", Namespace="http://tempuri.org/", Order=0)]
        public Disci_Hekim_Program.HizmetServis.HizmetGuncelleResponseBody Body;
        
        public HizmetGuncelleResponse() {
        }
        
        public HizmetGuncelleResponse(Disci_Hekim_Program.HizmetServis.HizmetGuncelleResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HizmetGuncelleResponseBody {
        
        public HizmetGuncelleResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Hizmetler1SoapChannel : Disci_Hekim_Program.HizmetServis.Hizmetler1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Hizmetler1SoapClient : System.ServiceModel.ClientBase<Disci_Hekim_Program.HizmetServis.Hizmetler1Soap>, Disci_Hekim_Program.HizmetServis.Hizmetler1Soap {
        
        public Hizmetler1SoapClient() {
        }
        
        public Hizmetler1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Hizmetler1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Hizmetler1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Hizmetler1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Disci_Hekim_Program.HizmetServis.HizmetListeleResponse Disci_Hekim_Program.HizmetServis.Hizmetler1Soap.HizmetListele(Disci_Hekim_Program.HizmetServis.HizmetListeleRequest request) {
            return base.Channel.HizmetListele(request);
        }
        
        public Disci_Hekim_Program.HizmetServis.Hizmet[] HizmetListele() {
            Disci_Hekim_Program.HizmetServis.HizmetListeleRequest inValue = new Disci_Hekim_Program.HizmetServis.HizmetListeleRequest();
            inValue.Body = new Disci_Hekim_Program.HizmetServis.HizmetListeleRequestBody();
            Disci_Hekim_Program.HizmetServis.HizmetListeleResponse retVal = ((Disci_Hekim_Program.HizmetServis.Hizmetler1Soap)(this)).HizmetListele(inValue);
            return retVal.Body.HizmetListeleResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Disci_Hekim_Program.HizmetServis.HizmetListeleResponse> Disci_Hekim_Program.HizmetServis.Hizmetler1Soap.HizmetListeleAsync(Disci_Hekim_Program.HizmetServis.HizmetListeleRequest request) {
            return base.Channel.HizmetListeleAsync(request);
        }
        
        public System.Threading.Tasks.Task<Disci_Hekim_Program.HizmetServis.HizmetListeleResponse> HizmetListeleAsync() {
            Disci_Hekim_Program.HizmetServis.HizmetListeleRequest inValue = new Disci_Hekim_Program.HizmetServis.HizmetListeleRequest();
            inValue.Body = new Disci_Hekim_Program.HizmetServis.HizmetListeleRequestBody();
            return ((Disci_Hekim_Program.HizmetServis.Hizmetler1Soap)(this)).HizmetListeleAsync(inValue);
        }
        
        public double BirimFiyatGetir(int id) {
            return base.Channel.BirimFiyatGetir(id);
        }
        
        public System.Threading.Tasks.Task<double> BirimFiyatGetirAsync(int id) {
            return base.Channel.BirimFiyatGetirAsync(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Disci_Hekim_Program.HizmetServis.HizmetAdiGetirResponse Disci_Hekim_Program.HizmetServis.Hizmetler1Soap.HizmetAdiGetir(Disci_Hekim_Program.HizmetServis.HizmetAdiGetirRequest request) {
            return base.Channel.HizmetAdiGetir(request);
        }
        
        public string HizmetAdiGetir(int id) {
            Disci_Hekim_Program.HizmetServis.HizmetAdiGetirRequest inValue = new Disci_Hekim_Program.HizmetServis.HizmetAdiGetirRequest();
            inValue.Body = new Disci_Hekim_Program.HizmetServis.HizmetAdiGetirRequestBody();
            inValue.Body.id = id;
            Disci_Hekim_Program.HizmetServis.HizmetAdiGetirResponse retVal = ((Disci_Hekim_Program.HizmetServis.Hizmetler1Soap)(this)).HizmetAdiGetir(inValue);
            return retVal.Body.HizmetAdiGetirResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Disci_Hekim_Program.HizmetServis.HizmetAdiGetirResponse> Disci_Hekim_Program.HizmetServis.Hizmetler1Soap.HizmetAdiGetirAsync(Disci_Hekim_Program.HizmetServis.HizmetAdiGetirRequest request) {
            return base.Channel.HizmetAdiGetirAsync(request);
        }
        
        public System.Threading.Tasks.Task<Disci_Hekim_Program.HizmetServis.HizmetAdiGetirResponse> HizmetAdiGetirAsync(int id) {
            Disci_Hekim_Program.HizmetServis.HizmetAdiGetirRequest inValue = new Disci_Hekim_Program.HizmetServis.HizmetAdiGetirRequest();
            inValue.Body = new Disci_Hekim_Program.HizmetServis.HizmetAdiGetirRequestBody();
            inValue.Body.id = id;
            return ((Disci_Hekim_Program.HizmetServis.Hizmetler1Soap)(this)).HizmetAdiGetirAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Disci_Hekim_Program.HizmetServis.HizmetEkleResponse Disci_Hekim_Program.HizmetServis.Hizmetler1Soap.HizmetEkle(Disci_Hekim_Program.HizmetServis.HizmetEkleRequest request) {
            return base.Channel.HizmetEkle(request);
        }
        
        public void HizmetEkle(string hizmetadi, double birimfiyat) {
            Disci_Hekim_Program.HizmetServis.HizmetEkleRequest inValue = new Disci_Hekim_Program.HizmetServis.HizmetEkleRequest();
            inValue.Body = new Disci_Hekim_Program.HizmetServis.HizmetEkleRequestBody();
            inValue.Body.hizmetadi = hizmetadi;
            inValue.Body.birimfiyat = birimfiyat;
            Disci_Hekim_Program.HizmetServis.HizmetEkleResponse retVal = ((Disci_Hekim_Program.HizmetServis.Hizmetler1Soap)(this)).HizmetEkle(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Disci_Hekim_Program.HizmetServis.HizmetEkleResponse> Disci_Hekim_Program.HizmetServis.Hizmetler1Soap.HizmetEkleAsync(Disci_Hekim_Program.HizmetServis.HizmetEkleRequest request) {
            return base.Channel.HizmetEkleAsync(request);
        }
        
        public System.Threading.Tasks.Task<Disci_Hekim_Program.HizmetServis.HizmetEkleResponse> HizmetEkleAsync(string hizmetadi, double birimfiyat) {
            Disci_Hekim_Program.HizmetServis.HizmetEkleRequest inValue = new Disci_Hekim_Program.HizmetServis.HizmetEkleRequest();
            inValue.Body = new Disci_Hekim_Program.HizmetServis.HizmetEkleRequestBody();
            inValue.Body.hizmetadi = hizmetadi;
            inValue.Body.birimfiyat = birimfiyat;
            return ((Disci_Hekim_Program.HizmetServis.Hizmetler1Soap)(this)).HizmetEkleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Disci_Hekim_Program.HizmetServis.HizmetGuncelleResponse Disci_Hekim_Program.HizmetServis.Hizmetler1Soap.HizmetGuncelle(Disci_Hekim_Program.HizmetServis.HizmetGuncelleRequest request) {
            return base.Channel.HizmetGuncelle(request);
        }
        
        public void HizmetGuncelle(int id, string hizmetadi, double birimfiyat) {
            Disci_Hekim_Program.HizmetServis.HizmetGuncelleRequest inValue = new Disci_Hekim_Program.HizmetServis.HizmetGuncelleRequest();
            inValue.Body = new Disci_Hekim_Program.HizmetServis.HizmetGuncelleRequestBody();
            inValue.Body.id = id;
            inValue.Body.hizmetadi = hizmetadi;
            inValue.Body.birimfiyat = birimfiyat;
            Disci_Hekim_Program.HizmetServis.HizmetGuncelleResponse retVal = ((Disci_Hekim_Program.HizmetServis.Hizmetler1Soap)(this)).HizmetGuncelle(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Disci_Hekim_Program.HizmetServis.HizmetGuncelleResponse> Disci_Hekim_Program.HizmetServis.Hizmetler1Soap.HizmetGuncelleAsync(Disci_Hekim_Program.HizmetServis.HizmetGuncelleRequest request) {
            return base.Channel.HizmetGuncelleAsync(request);
        }
        
        public System.Threading.Tasks.Task<Disci_Hekim_Program.HizmetServis.HizmetGuncelleResponse> HizmetGuncelleAsync(int id, string hizmetadi, double birimfiyat) {
            Disci_Hekim_Program.HizmetServis.HizmetGuncelleRequest inValue = new Disci_Hekim_Program.HizmetServis.HizmetGuncelleRequest();
            inValue.Body = new Disci_Hekim_Program.HizmetServis.HizmetGuncelleRequestBody();
            inValue.Body.id = id;
            inValue.Body.hizmetadi = hizmetadi;
            inValue.Body.birimfiyat = birimfiyat;
            return ((Disci_Hekim_Program.HizmetServis.Hizmetler1Soap)(this)).HizmetGuncelleAsync(inValue);
        }
        
        public void HizmetSil(int id) {
            base.Channel.HizmetSil(id);
        }
        
        public System.Threading.Tasks.Task HizmetSilAsync(int id) {
            return base.Channel.HizmetSilAsync(id);
        }
    }
}
