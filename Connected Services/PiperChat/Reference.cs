﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.PiperChat {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/PiperchatService.Models")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfApp1.PiperChat.Message[] UserMessagesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfApp1.PiperChat.Message[] UserMessages {
            get {
                return this.UserMessagesField;
            }
            set {
                if ((object.ReferenceEquals(this.UserMessagesField, value) != true)) {
                    this.UserMessagesField = value;
                    this.RaisePropertyChanged("UserMessages");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Message", Namespace="http://schemas.datacontract.org/2004/07/PiperchatService.Models")]
    [System.SerializableAttribute()]
    public partial class Message : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageSentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ReceiverIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SenderIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeSentField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MessageSent {
            get {
                return this.MessageSentField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageSentField, value) != true)) {
                    this.MessageSentField = value;
                    this.RaisePropertyChanged("MessageSent");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ReceiverId {
            get {
                return this.ReceiverIdField;
            }
            set {
                if ((this.ReceiverIdField.Equals(value) != true)) {
                    this.ReceiverIdField = value;
                    this.RaisePropertyChanged("ReceiverId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SenderId {
            get {
                return this.SenderIdField;
            }
            set {
                if ((this.SenderIdField.Equals(value) != true)) {
                    this.SenderIdField = value;
                    this.RaisePropertyChanged("SenderId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeSent {
            get {
                return this.TimeSentField;
            }
            set {
                if ((this.TimeSentField.Equals(value) != true)) {
                    this.TimeSentField = value;
                    this.RaisePropertyChanged("TimeSent");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PiperChat.IMessageService", CallbackContract=typeof(WpfApp1.PiperChat.IMessageServiceCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IMessageService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/Connect")]
        void Connect(WpfApp1.PiperChat.User user);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/Connect")]
        System.Threading.Tasks.Task ConnectAsync(WpfApp1.PiperChat.User user);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/SendMessage")]
        void SendMessage(WpfApp1.PiperChat.Message message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/SendMessage")]
        System.Threading.Tasks.Task SendMessageAsync(WpfApp1.PiperChat.Message message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageService/GetConnectedUsers", ReplyAction="http://tempuri.org/IMessageService/GetConnectedUsersResponse")]
        WpfApp1.PiperChat.User[] GetConnectedUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageService/GetConnectedUsers", ReplyAction="http://tempuri.org/IMessageService/GetConnectedUsersResponse")]
        System.Threading.Tasks.Task<WpfApp1.PiperChat.User[]> GetConnectedUsersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMessageServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/ForwardToClient")]
        void ForwardToClient(WpfApp1.PiperChat.Message message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/UsersConnected")]
        void UsersConnected(WpfApp1.PiperChat.User[] users);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMessageServiceChannel : WpfApp1.PiperChat.IMessageService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MessageServiceClient : System.ServiceModel.DuplexClientBase<WpfApp1.PiperChat.IMessageService>, WpfApp1.PiperChat.IMessageService {
        
        public MessageServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public MessageServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public MessageServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MessageServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MessageServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Connect(WpfApp1.PiperChat.User user) {
            base.Channel.Connect(user);
        }
        
        public System.Threading.Tasks.Task ConnectAsync(WpfApp1.PiperChat.User user) {
            return base.Channel.ConnectAsync(user);
        }
        
        public void SendMessage(WpfApp1.PiperChat.Message message) {
            base.Channel.SendMessage(message);
        }
        
        public System.Threading.Tasks.Task SendMessageAsync(WpfApp1.PiperChat.Message message) {
            return base.Channel.SendMessageAsync(message);
        }
        
        public WpfApp1.PiperChat.User[] GetConnectedUsers() {
            return base.Channel.GetConnectedUsers();
        }
        
        public System.Threading.Tasks.Task<WpfApp1.PiperChat.User[]> GetConnectedUsersAsync() {
            return base.Channel.GetConnectedUsersAsync();
        }
    }
}