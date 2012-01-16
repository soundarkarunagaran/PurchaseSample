﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfClient.Purchase {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Purchase.PurchaseOrchestrations_PurchaseOrchestartion_PurchasePort")]
    public interface PurchaseOrchestrations_PurchaseOrchestartion_PurchasePort {
        
        // CODEGEN: Generating message contract since the operation MakePurchase is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="MakePurchase", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WcfClient.Purchase.MakePurchaseResponse MakePurchase(WcfClient.Purchase.MakePurchaseRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://PurchaseFlow.Schemas.PurchaseRequest")]
    public partial class PurchaseRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private uint customerIdField;
        
        private uint productIdField;
        
        private uint quantityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public uint customerId {
            get {
                return this.customerIdField;
            }
            set {
                this.customerIdField = value;
                this.RaisePropertyChanged("customerId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public uint productId {
            get {
                return this.productIdField;
            }
            set {
                this.productIdField = value;
                this.RaisePropertyChanged("productId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public uint quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
                this.RaisePropertyChanged("quantity");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://PurchaseFlowSchemas.ErrorSchema")]
    public partial class Error : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codeField;
        
        private string messageField;
        
        public Error() {
            this.codeField = "-";
            this.messageField = "-";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("Code");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("Message");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MakePurchaseRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://PurchaseFlow.Schemas.PurchaseRequest", Order=0)]
        public WcfClient.Purchase.PurchaseRequest PurchaseRequest;
        
        public MakePurchaseRequest() {
        }
        
        public MakePurchaseRequest(WcfClient.Purchase.PurchaseRequest PurchaseRequest) {
            this.PurchaseRequest = PurchaseRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MakePurchaseResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://PurchaseFlowSchemas.ErrorSchema", Order=0)]
        public WcfClient.Purchase.Error Error;
        
        public MakePurchaseResponse() {
        }
        
        public MakePurchaseResponse(WcfClient.Purchase.Error Error) {
            this.Error = Error;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PurchaseOrchestrations_PurchaseOrchestartion_PurchasePortChannel : WcfClient.Purchase.PurchaseOrchestrations_PurchaseOrchestartion_PurchasePort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PurchaseOrchestrations_PurchaseOrchestartion_PurchasePortClient : System.ServiceModel.ClientBase<WcfClient.Purchase.PurchaseOrchestrations_PurchaseOrchestartion_PurchasePort>, WcfClient.Purchase.PurchaseOrchestrations_PurchaseOrchestartion_PurchasePort {
        
        public PurchaseOrchestrations_PurchaseOrchestartion_PurchasePortClient() {
        }
        
        public PurchaseOrchestrations_PurchaseOrchestartion_PurchasePortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PurchaseOrchestrations_PurchaseOrchestartion_PurchasePortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PurchaseOrchestrations_PurchaseOrchestartion_PurchasePortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PurchaseOrchestrations_PurchaseOrchestartion_PurchasePortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WcfClient.Purchase.MakePurchaseResponse WcfClient.Purchase.PurchaseOrchestrations_PurchaseOrchestartion_PurchasePort.MakePurchase(WcfClient.Purchase.MakePurchaseRequest request) {
            return base.Channel.MakePurchase(request);
        }
        
        public WcfClient.Purchase.Error MakePurchase(WcfClient.Purchase.PurchaseRequest PurchaseRequest) {
            WcfClient.Purchase.MakePurchaseRequest inValue = new WcfClient.Purchase.MakePurchaseRequest();
            inValue.PurchaseRequest = PurchaseRequest;
            WcfClient.Purchase.MakePurchaseResponse retVal = ((WcfClient.Purchase.PurchaseOrchestrations_PurchaseOrchestartion_PurchasePort)(this)).MakePurchase(inValue);
            return retVal.Error;
        }
    }
}
