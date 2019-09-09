﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArrivalStation.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.tier2", ConfigurationName="ServiceReference1.WarehouseWS")]
    public interface WarehouseWS {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="insertPalletReturn")]
        bool insertPallet(ArrivalStation.ServiceReference1.Pallet pallet);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="insertPalletReturn")]
        System.Threading.Tasks.Task<bool> insertPalletAsync(ArrivalStation.ServiceReference1.Pallet pallet);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="retrievePalletsReturn")]
        ArrivalStation.ServiceReference1.Pallet[] retrievePallets(ArrivalStation.ServiceReference1.Good good, int count, int stationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="retrievePalletsReturn")]
        System.Threading.Tasks.Task<ArrivalStation.ServiceReference1.Pallet[]> retrievePalletsAsync(ArrivalStation.ServiceReference1.Good good, int count, int stationId);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://model.tier2")]
    public partial class Pallet : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int countField;
        
        private Good goodField;
        
        private int idField;
        
        private int pickStationIdField;
        
        /// <remarks/>
        public int count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
                this.RaisePropertyChanged("count");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public Good good {
            get {
                return this.goodField;
            }
            set {
                this.goodField = value;
                this.RaisePropertyChanged("good");
            }
        }
        
        /// <remarks/>
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        public int pickStationId {
            get {
                return this.pickStationIdField;
            }
            set {
                this.pickStationIdField = value;
                this.RaisePropertyChanged("pickStationId");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://model.tier2")]
    public partial class Good : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int goodidField;
        
        private string manufacturerField;
        
        private string nameField;
        
        /// <remarks/>
        public int goodid {
            get {
                return this.goodidField;
            }
            set {
                this.goodidField = value;
                this.RaisePropertyChanged("goodid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string manufacturer {
            get {
                return this.manufacturerField;
            }
            set {
                this.manufacturerField = value;
                this.RaisePropertyChanged("manufacturer");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
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
    public interface WarehouseWSChannel : ArrivalStation.ServiceReference1.WarehouseWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WarehouseWSClient : System.ServiceModel.ClientBase<ArrivalStation.ServiceReference1.WarehouseWS>, ArrivalStation.ServiceReference1.WarehouseWS {
        
        public WarehouseWSClient() {
        }
        
        public WarehouseWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WarehouseWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WarehouseWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WarehouseWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool insertPallet(ArrivalStation.ServiceReference1.Pallet pallet) {
            return base.Channel.insertPallet(pallet);
        }
        
        public System.Threading.Tasks.Task<bool> insertPalletAsync(ArrivalStation.ServiceReference1.Pallet pallet) {
            return base.Channel.insertPalletAsync(pallet);
        }
        
        public ArrivalStation.ServiceReference1.Pallet[] retrievePallets(ArrivalStation.ServiceReference1.Good good, int count, int stationId) {
            return base.Channel.retrievePallets(good, count, stationId);
        }
        
        public System.Threading.Tasks.Task<ArrivalStation.ServiceReference1.Pallet[]> retrievePalletsAsync(ArrivalStation.ServiceReference1.Good good, int count, int stationId) {
            return base.Channel.retrievePalletsAsync(good, count, stationId);
        }
    }
}