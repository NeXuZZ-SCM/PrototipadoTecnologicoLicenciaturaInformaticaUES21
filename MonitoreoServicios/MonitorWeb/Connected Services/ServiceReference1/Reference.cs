﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonitorWeb.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1", CallbackContract=typeof(MonitorWeb.ServiceReference1.IService1Callback))]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Conectar", ReplyAction="http://tempuri.org/IService1/ConectarResponse")]
        void Conectar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Conectar", ReplyAction="http://tempuri.org/IService1/ConectarResponse")]
        System.Threading.Tasks.Task ConectarAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Callback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService1/CallbackMostrarEstados")]
        void CallbackMostrarEstados(string json);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : MonitorWeb.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.DuplexClientBase<MonitorWeb.ServiceReference1.IService1>, MonitorWeb.ServiceReference1.IService1 {
        
        public Service1Client(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public Service1Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public Service1Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Conectar() {
            base.Channel.Conectar();
        }
        
        public System.Threading.Tasks.Task ConectarAsync() {
            return base.Channel.ConectarAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IAcciones")]
    public interface IAcciones {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAcciones/IniciarServicio", ReplyAction="http://tempuri.org/IAcciones/IniciarServicioResponse")]
        bool IniciarServicio(string nombreProceso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAcciones/IniciarServicio", ReplyAction="http://tempuri.org/IAcciones/IniciarServicioResponse")]
        System.Threading.Tasks.Task<bool> IniciarServicioAsync(string nombreProceso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAcciones/DetenerServicio", ReplyAction="http://tempuri.org/IAcciones/DetenerServicioResponse")]
        bool DetenerServicio(string nombreProceso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAcciones/DetenerServicio", ReplyAction="http://tempuri.org/IAcciones/DetenerServicioResponse")]
        System.Threading.Tasks.Task<bool> DetenerServicioAsync(string nombreProceso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAcciones/PausarServicio", ReplyAction="http://tempuri.org/IAcciones/PausarServicioResponse")]
        bool PausarServicio(string nombreProceso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAcciones/PausarServicio", ReplyAction="http://tempuri.org/IAcciones/PausarServicioResponse")]
        System.Threading.Tasks.Task<bool> PausarServicioAsync(string nombreProceso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAcciones/ReanudarServicio", ReplyAction="http://tempuri.org/IAcciones/ReanudarServicioResponse")]
        bool ReanudarServicio(string nombreProceso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAcciones/ReanudarServicio", ReplyAction="http://tempuri.org/IAcciones/ReanudarServicioResponse")]
        System.Threading.Tasks.Task<bool> ReanudarServicioAsync(string nombreProceso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAcciones/ReiniciarServicio", ReplyAction="http://tempuri.org/IAcciones/ReiniciarServicioResponse")]
        bool ReiniciarServicio(string nombreProceso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAcciones/ReiniciarServicio", ReplyAction="http://tempuri.org/IAcciones/ReiniciarServicioResponse")]
        System.Threading.Tasks.Task<bool> ReiniciarServicioAsync(string nombreProceso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAcciones/killService", ReplyAction="http://tempuri.org/IAcciones/killServiceResponse")]
        bool killService(string nombreProceso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAcciones/killService", ReplyAction="http://tempuri.org/IAcciones/killServiceResponse")]
        System.Threading.Tasks.Task<bool> killServiceAsync(string nombreProceso);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAccionesChannel : MonitorWeb.ServiceReference1.IAcciones, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccionesClient : System.ServiceModel.ClientBase<MonitorWeb.ServiceReference1.IAcciones>, MonitorWeb.ServiceReference1.IAcciones {
        
        public AccionesClient() {
        }
        
        public AccionesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccionesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccionesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccionesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool IniciarServicio(string nombreProceso) {
            return base.Channel.IniciarServicio(nombreProceso);
        }
        
        public System.Threading.Tasks.Task<bool> IniciarServicioAsync(string nombreProceso) {
            return base.Channel.IniciarServicioAsync(nombreProceso);
        }
        
        public bool DetenerServicio(string nombreProceso) {
            return base.Channel.DetenerServicio(nombreProceso);
        }
        
        public System.Threading.Tasks.Task<bool> DetenerServicioAsync(string nombreProceso) {
            return base.Channel.DetenerServicioAsync(nombreProceso);
        }
        
        public bool PausarServicio(string nombreProceso) {
            return base.Channel.PausarServicio(nombreProceso);
        }
        
        public System.Threading.Tasks.Task<bool> PausarServicioAsync(string nombreProceso) {
            return base.Channel.PausarServicioAsync(nombreProceso);
        }
        
        public bool ReanudarServicio(string nombreProceso) {
            return base.Channel.ReanudarServicio(nombreProceso);
        }
        
        public System.Threading.Tasks.Task<bool> ReanudarServicioAsync(string nombreProceso) {
            return base.Channel.ReanudarServicioAsync(nombreProceso);
        }
        
        public bool ReiniciarServicio(string nombreProceso) {
            return base.Channel.ReiniciarServicio(nombreProceso);
        }
        
        public System.Threading.Tasks.Task<bool> ReiniciarServicioAsync(string nombreProceso) {
            return base.Channel.ReiniciarServicioAsync(nombreProceso);
        }
        
        public bool killService(string nombreProceso) {
            return base.Channel.killService(nombreProceso);
        }
        
        public System.Threading.Tasks.Task<bool> killServiceAsync(string nombreProceso) {
            return base.Channel.killServiceAsync(nombreProceso);
        }
    }
}
