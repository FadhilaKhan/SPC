﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminApplication.CategoryWebServiceReference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CategoryWebServiceReference.categorywebserviceSoap")]
    public interface categorywebserviceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertCategory", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string insertCategory(string CategoryId, string CategoryName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertCategory", ReplyAction="*")]
        System.Threading.Tasks.Task<string> insertCategoryAsync(string CategoryId, string CategoryName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/deleteCategory", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string deleteCategory(string CategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/deleteCategory", ReplyAction="*")]
        System.Threading.Tasks.Task<string> deleteCategoryAsync(string CategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchCategory", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet SearchCategory(string CategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchCategory", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> SearchCategoryAsync(string CategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateCategory", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string updateCategory(string CategoryId, string CategoryName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateCategory", ReplyAction="*")]
        System.Threading.Tasks.Task<string> updateCategoryAsync(string CategoryId, string CategoryName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface categorywebserviceSoapChannel : AdminApplication.CategoryWebServiceReference.categorywebserviceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class categorywebserviceSoapClient : System.ServiceModel.ClientBase<AdminApplication.CategoryWebServiceReference.categorywebserviceSoap>, AdminApplication.CategoryWebServiceReference.categorywebserviceSoap {
        
        public categorywebserviceSoapClient() {
        }
        
        public categorywebserviceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public categorywebserviceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public categorywebserviceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public categorywebserviceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string insertCategory(string CategoryId, string CategoryName) {
            return base.Channel.insertCategory(CategoryId, CategoryName);
        }
        
        public System.Threading.Tasks.Task<string> insertCategoryAsync(string CategoryId, string CategoryName) {
            return base.Channel.insertCategoryAsync(CategoryId, CategoryName);
        }
        
        public string deleteCategory(string CategoryId) {
            return base.Channel.deleteCategory(CategoryId);
        }
        
        public System.Threading.Tasks.Task<string> deleteCategoryAsync(string CategoryId) {
            return base.Channel.deleteCategoryAsync(CategoryId);
        }
        
        public System.Data.DataSet SearchCategory(string CategoryId) {
            return base.Channel.SearchCategory(CategoryId);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SearchCategoryAsync(string CategoryId) {
            return base.Channel.SearchCategoryAsync(CategoryId);
        }
        
        public string updateCategory(string CategoryId, string CategoryName) {
            return base.Channel.updateCategory(CategoryId, CategoryName);
        }
        
        public System.Threading.Tasks.Task<string> updateCategoryAsync(string CategoryId, string CategoryName) {
            return base.Channel.updateCategoryAsync(CategoryId, CategoryName);
        }
    }
}
