﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testRest.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebServices/", ConfigurationName="ServiceReference1.WebServiceSeta")]
    public interface WebServiceSeta {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento return del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebServices/WebServiceSeta/segundaRequest", ReplyAction="http://WebServices/WebServiceSeta/segundaResponse")]
        testRest.ServiceReference1.segundaResponse segunda(testRest.ServiceReference1.segundaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebServices/WebServiceSeta/segundaRequest", ReplyAction="http://WebServices/WebServiceSeta/segundaResponse")]
        System.Threading.Tasks.Task<testRest.ServiceReference1.segundaResponse> segundaAsync(testRest.ServiceReference1.segundaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class segundaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="segunda", Namespace="http://WebServices/", Order=0)]
        public testRest.ServiceReference1.segundaRequestBody Body;
        
        public segundaRequest() {
        }
        
        public segundaRequest(testRest.ServiceReference1.segundaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class segundaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int idperfil;
        
        public segundaRequestBody() {
        }
        
        public segundaRequestBody(int idperfil) {
            this.idperfil = idperfil;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class segundaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="segundaResponse", Namespace="http://WebServices/", Order=0)]
        public testRest.ServiceReference1.segundaResponseBody Body;
        
        public segundaResponse() {
        }
        
        public segundaResponse(testRest.ServiceReference1.segundaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class segundaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public segundaResponseBody() {
        }
        
        public segundaResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSetaChannel : testRest.ServiceReference1.WebServiceSeta, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSetaClient : System.ServiceModel.ClientBase<testRest.ServiceReference1.WebServiceSeta>, testRest.ServiceReference1.WebServiceSeta {
        
        public WebServiceSetaClient() {
        }
        
        public WebServiceSetaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSetaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSetaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSetaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        testRest.ServiceReference1.segundaResponse testRest.ServiceReference1.WebServiceSeta.segunda(testRest.ServiceReference1.segundaRequest request) {
            return base.Channel.segunda(request);
        }
        
        public string segunda(int idperfil) {
            testRest.ServiceReference1.segundaRequest inValue = new testRest.ServiceReference1.segundaRequest();
            inValue.Body = new testRest.ServiceReference1.segundaRequestBody();
            inValue.Body.idperfil = idperfil;
            testRest.ServiceReference1.segundaResponse retVal = ((testRest.ServiceReference1.WebServiceSeta)(this)).segunda(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<testRest.ServiceReference1.segundaResponse> testRest.ServiceReference1.WebServiceSeta.segundaAsync(testRest.ServiceReference1.segundaRequest request) {
            return base.Channel.segundaAsync(request);
        }
        
        public System.Threading.Tasks.Task<testRest.ServiceReference1.segundaResponse> segundaAsync(int idperfil) {
            testRest.ServiceReference1.segundaRequest inValue = new testRest.ServiceReference1.segundaRequest();
            inValue.Body = new testRest.ServiceReference1.segundaRequestBody();
            inValue.Body.idperfil = idperfil;
            return ((testRest.ServiceReference1.WebServiceSeta)(this)).segundaAsync(inValue);
        }
    }
}
