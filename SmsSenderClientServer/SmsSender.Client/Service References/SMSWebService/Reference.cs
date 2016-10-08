﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmsSender.Client.Service_References.SMSWebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org/Service", ConfigurationName="SMSWebService.SMSServiceSoap")]
    public interface SMSServiceSoap {
        
        // CODEGEN: Generating message contract since element name telephoneNumber from namespace http://tempuri.org/Service is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Service/PostMessageData", ReplyAction="*")]
        PostMessageDataResponse PostMessageData(PostMessageDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Service/PostMessageData", ReplyAction="*")]
        System.Threading.Tasks.Task<PostMessageDataResponse> PostMessageDataAsync(PostMessageDataRequest request);
        
        // CODEGEN: Generating message contract since element name username from namespace http://tempuri.org/Service is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Service/GetAuthentification", ReplyAction="*")]
        GetAuthentificationResponse GetAuthentification(GetAuthentificationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Service/GetAuthentification", ReplyAction="*")]
        System.Threading.Tasks.Task<GetAuthentificationResponse> GetAuthentificationAsync(GetAuthentificationRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PostMessageDataRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PostMessageData", Namespace="http://tempuri.org/Service", Order=0)]
        public PostMessageDataRequestBody Body;
        
        public PostMessageDataRequest() {
        }
        
        public PostMessageDataRequest(PostMessageDataRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/Service")]
    public partial class PostMessageDataRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string telephoneNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string message;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int priority;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string username;
        
        public PostMessageDataRequestBody() {
        }
        
        public PostMessageDataRequestBody(string telephoneNumber, string message, int priority, string username) {
            this.telephoneNumber = telephoneNumber;
            this.message = message;
            this.priority = priority;
            this.username = username;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PostMessageDataResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PostMessageDataResponse", Namespace="http://tempuri.org/Service", Order=0)]
        public PostMessageDataResponseBody Body;
        
        public PostMessageDataResponse() {
        }
        
        public PostMessageDataResponse(PostMessageDataResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/Service")]
    public partial class PostMessageDataResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string PostMessageDataResult;
        
        public PostMessageDataResponseBody() {
        }
        
        public PostMessageDataResponseBody(string PostMessageDataResult) {
            this.PostMessageDataResult = PostMessageDataResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAuthentificationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAuthentification", Namespace="http://tempuri.org/Service", Order=0)]
        public GetAuthentificationRequestBody Body;
        
        public GetAuthentificationRequest() {
        }
        
        public GetAuthentificationRequest(GetAuthentificationRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/Service")]
    public partial class GetAuthentificationRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public GetAuthentificationRequestBody() {
        }
        
        public GetAuthentificationRequestBody(string username, string password) {
            this.username = username;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAuthentificationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAuthentificationResponse", Namespace="http://tempuri.org/Service", Order=0)]
        public GetAuthentificationResponseBody Body;
        
        public GetAuthentificationResponse() {
        }
        
        public GetAuthentificationResponse(GetAuthentificationResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/Service")]
    public partial class GetAuthentificationResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetAuthentificationResult;
        
        public GetAuthentificationResponseBody() {
        }
        
        public GetAuthentificationResponseBody(string GetAuthentificationResult) {
            this.GetAuthentificationResult = GetAuthentificationResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SMSServiceSoapChannel : SMSServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SMSServiceSoapClient : System.ServiceModel.ClientBase<SMSServiceSoap>, SMSServiceSoap {
        
        public SMSServiceSoapClient() {
        }
        
        public SMSServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SMSServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SMSServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SMSServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PostMessageDataResponse SMSServiceSoap.PostMessageData(PostMessageDataRequest request) {
            return base.Channel.PostMessageData(request);
        }
        
        public string PostMessageData(string telephoneNumber, string message, int priority, string username) {
            PostMessageDataRequest inValue = new PostMessageDataRequest();
            inValue.Body = new PostMessageDataRequestBody();
            inValue.Body.telephoneNumber = telephoneNumber;
            inValue.Body.message = message;
            inValue.Body.priority = priority;
            inValue.Body.username = username;
            PostMessageDataResponse retVal = ((SMSServiceSoap)(this)).PostMessageData(inValue);
            return retVal.Body.PostMessageDataResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PostMessageDataResponse> SMSServiceSoap.PostMessageDataAsync(PostMessageDataRequest request) {
            return base.Channel.PostMessageDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<PostMessageDataResponse> PostMessageDataAsync(string telephoneNumber, string message, int priority, string username) {
            PostMessageDataRequest inValue = new PostMessageDataRequest();
            inValue.Body = new PostMessageDataRequestBody();
            inValue.Body.telephoneNumber = telephoneNumber;
            inValue.Body.message = message;
            inValue.Body.priority = priority;
            inValue.Body.username = username;
            return ((SMSServiceSoap)(this)).PostMessageDataAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetAuthentificationResponse SMSServiceSoap.GetAuthentification(GetAuthentificationRequest request) {
            return base.Channel.GetAuthentification(request);
        }
        
        public string GetAuthentification(string username, string password) {
            GetAuthentificationRequest inValue = new GetAuthentificationRequest();
            inValue.Body = new GetAuthentificationRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            GetAuthentificationResponse retVal = ((SMSServiceSoap)(this)).GetAuthentification(inValue);
            return retVal.Body.GetAuthentificationResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GetAuthentificationResponse> SMSServiceSoap.GetAuthentificationAsync(GetAuthentificationRequest request) {
            return base.Channel.GetAuthentificationAsync(request);
        }
        
        public System.Threading.Tasks.Task<GetAuthentificationResponse> GetAuthentificationAsync(string username, string password) {
            GetAuthentificationRequest inValue = new GetAuthentificationRequest();
            inValue.Body = new GetAuthentificationRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            return ((SMSServiceSoap)(this)).GetAuthentificationAsync(inValue);
        }
    }
}
