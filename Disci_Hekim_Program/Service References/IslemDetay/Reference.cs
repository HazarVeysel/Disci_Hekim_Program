﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disci_Hekim_Program.IslemDetay {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="IslemDetaylari", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class IslemDetaylari : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IslemAdiField;
        
        private System.Nullable<int> AdetField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string IslemAdi {
            get {
                return this.IslemAdiField;
            }
            set {
                if ((object.ReferenceEquals(this.IslemAdiField, value) != true)) {
                    this.IslemAdiField = value;
                    this.RaisePropertyChanged("IslemAdi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public System.Nullable<int> Adet {
            get {
                return this.AdetField;
            }
            set {
                if ((this.AdetField.Equals(value) != true)) {
                    this.AdetField = value;
                    this.RaisePropertyChanged("Adet");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IslemDetay.IslemDetaySoap")]
    public interface IslemDetaySoap {
        
        // CODEGEN: Generating message contract since element name islemadi from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IslemDetayEkle", ReplyAction="*")]
        Disci_Hekim_Program.IslemDetay.IslemDetayEkleResponse IslemDetayEkle(Disci_Hekim_Program.IslemDetay.IslemDetayEkleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IslemDetayEkle", ReplyAction="*")]
        System.Threading.Tasks.Task<Disci_Hekim_Program.IslemDetay.IslemDetayEkleResponse> IslemDetayEkleAsync(Disci_Hekim_Program.IslemDetay.IslemDetayEkleRequest request);
        
        // CODEGEN: Generating message contract since element name islemdetaylisteleIDResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/islemdetaylisteleID", ReplyAction="*")]
        Disci_Hekim_Program.IslemDetay.islemdetaylisteleIDResponse islemdetaylisteleID(Disci_Hekim_Program.IslemDetay.islemdetaylisteleIDRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/islemdetaylisteleID", ReplyAction="*")]
        System.Threading.Tasks.Task<Disci_Hekim_Program.IslemDetay.islemdetaylisteleIDResponse> islemdetaylisteleIDAsync(Disci_Hekim_Program.IslemDetay.islemdetaylisteleIDRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class IslemDetayEkleRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="IslemDetayEkle", Namespace="http://tempuri.org/", Order=0)]
        public Disci_Hekim_Program.IslemDetay.IslemDetayEkleRequestBody Body;
        
        public IslemDetayEkleRequest() {
        }
        
        public IslemDetayEkleRequest(Disci_Hekim_Program.IslemDetay.IslemDetayEkleRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class IslemDetayEkleRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int islemid;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string islemadi;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public double birimfiyat;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int adet;
        
        public IslemDetayEkleRequestBody() {
        }
        
        public IslemDetayEkleRequestBody(int islemid, string islemadi, double birimfiyat, int adet) {
            this.islemid = islemid;
            this.islemadi = islemadi;
            this.birimfiyat = birimfiyat;
            this.adet = adet;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class IslemDetayEkleResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="IslemDetayEkleResponse", Namespace="http://tempuri.org/", Order=0)]
        public Disci_Hekim_Program.IslemDetay.IslemDetayEkleResponseBody Body;
        
        public IslemDetayEkleResponse() {
        }
        
        public IslemDetayEkleResponse(Disci_Hekim_Program.IslemDetay.IslemDetayEkleResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class IslemDetayEkleResponseBody {
        
        public IslemDetayEkleResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class islemdetaylisteleIDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="islemdetaylisteleID", Namespace="http://tempuri.org/", Order=0)]
        public Disci_Hekim_Program.IslemDetay.islemdetaylisteleIDRequestBody Body;
        
        public islemdetaylisteleIDRequest() {
        }
        
        public islemdetaylisteleIDRequest(Disci_Hekim_Program.IslemDetay.islemdetaylisteleIDRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class islemdetaylisteleIDRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int islemid;
        
        public islemdetaylisteleIDRequestBody() {
        }
        
        public islemdetaylisteleIDRequestBody(int islemid) {
            this.islemid = islemid;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class islemdetaylisteleIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="islemdetaylisteleIDResponse", Namespace="http://tempuri.org/", Order=0)]
        public Disci_Hekim_Program.IslemDetay.islemdetaylisteleIDResponseBody Body;
        
        public islemdetaylisteleIDResponse() {
        }
        
        public islemdetaylisteleIDResponse(Disci_Hekim_Program.IslemDetay.islemdetaylisteleIDResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class islemdetaylisteleIDResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Disci_Hekim_Program.IslemDetay.IslemDetaylari[] islemdetaylisteleIDResult;
        
        public islemdetaylisteleIDResponseBody() {
        }
        
        public islemdetaylisteleIDResponseBody(Disci_Hekim_Program.IslemDetay.IslemDetaylari[] islemdetaylisteleIDResult) {
            this.islemdetaylisteleIDResult = islemdetaylisteleIDResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IslemDetaySoapChannel : Disci_Hekim_Program.IslemDetay.IslemDetaySoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IslemDetaySoapClient : System.ServiceModel.ClientBase<Disci_Hekim_Program.IslemDetay.IslemDetaySoap>, Disci_Hekim_Program.IslemDetay.IslemDetaySoap {
        
        public IslemDetaySoapClient() {
        }
        
        public IslemDetaySoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IslemDetaySoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IslemDetaySoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IslemDetaySoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Disci_Hekim_Program.IslemDetay.IslemDetayEkleResponse Disci_Hekim_Program.IslemDetay.IslemDetaySoap.IslemDetayEkle(Disci_Hekim_Program.IslemDetay.IslemDetayEkleRequest request) {
            return base.Channel.IslemDetayEkle(request);
        }
        
        public void IslemDetayEkle(int islemid, string islemadi, double birimfiyat, int adet) {
            Disci_Hekim_Program.IslemDetay.IslemDetayEkleRequest inValue = new Disci_Hekim_Program.IslemDetay.IslemDetayEkleRequest();
            inValue.Body = new Disci_Hekim_Program.IslemDetay.IslemDetayEkleRequestBody();
            inValue.Body.islemid = islemid;
            inValue.Body.islemadi = islemadi;
            inValue.Body.birimfiyat = birimfiyat;
            inValue.Body.adet = adet;
            Disci_Hekim_Program.IslemDetay.IslemDetayEkleResponse retVal = ((Disci_Hekim_Program.IslemDetay.IslemDetaySoap)(this)).IslemDetayEkle(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Disci_Hekim_Program.IslemDetay.IslemDetayEkleResponse> Disci_Hekim_Program.IslemDetay.IslemDetaySoap.IslemDetayEkleAsync(Disci_Hekim_Program.IslemDetay.IslemDetayEkleRequest request) {
            return base.Channel.IslemDetayEkleAsync(request);
        }
        
        public System.Threading.Tasks.Task<Disci_Hekim_Program.IslemDetay.IslemDetayEkleResponse> IslemDetayEkleAsync(int islemid, string islemadi, double birimfiyat, int adet) {
            Disci_Hekim_Program.IslemDetay.IslemDetayEkleRequest inValue = new Disci_Hekim_Program.IslemDetay.IslemDetayEkleRequest();
            inValue.Body = new Disci_Hekim_Program.IslemDetay.IslemDetayEkleRequestBody();
            inValue.Body.islemid = islemid;
            inValue.Body.islemadi = islemadi;
            inValue.Body.birimfiyat = birimfiyat;
            inValue.Body.adet = adet;
            return ((Disci_Hekim_Program.IslemDetay.IslemDetaySoap)(this)).IslemDetayEkleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Disci_Hekim_Program.IslemDetay.islemdetaylisteleIDResponse Disci_Hekim_Program.IslemDetay.IslemDetaySoap.islemdetaylisteleID(Disci_Hekim_Program.IslemDetay.islemdetaylisteleIDRequest request) {
            return base.Channel.islemdetaylisteleID(request);
        }
        
        public Disci_Hekim_Program.IslemDetay.IslemDetaylari[] islemdetaylisteleID(int islemid) {
            Disci_Hekim_Program.IslemDetay.islemdetaylisteleIDRequest inValue = new Disci_Hekim_Program.IslemDetay.islemdetaylisteleIDRequest();
            inValue.Body = new Disci_Hekim_Program.IslemDetay.islemdetaylisteleIDRequestBody();
            inValue.Body.islemid = islemid;
            Disci_Hekim_Program.IslemDetay.islemdetaylisteleIDResponse retVal = ((Disci_Hekim_Program.IslemDetay.IslemDetaySoap)(this)).islemdetaylisteleID(inValue);
            return retVal.Body.islemdetaylisteleIDResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Disci_Hekim_Program.IslemDetay.islemdetaylisteleIDResponse> Disci_Hekim_Program.IslemDetay.IslemDetaySoap.islemdetaylisteleIDAsync(Disci_Hekim_Program.IslemDetay.islemdetaylisteleIDRequest request) {
            return base.Channel.islemdetaylisteleIDAsync(request);
        }
        
        public System.Threading.Tasks.Task<Disci_Hekim_Program.IslemDetay.islemdetaylisteleIDResponse> islemdetaylisteleIDAsync(int islemid) {
            Disci_Hekim_Program.IslemDetay.islemdetaylisteleIDRequest inValue = new Disci_Hekim_Program.IslemDetay.islemdetaylisteleIDRequest();
            inValue.Body = new Disci_Hekim_Program.IslemDetay.islemdetaylisteleIDRequestBody();
            inValue.Body.islemid = islemid;
            return ((Disci_Hekim_Program.IslemDetay.IslemDetaySoap)(this)).islemdetaylisteleIDAsync(inValue);
        }
    }
}