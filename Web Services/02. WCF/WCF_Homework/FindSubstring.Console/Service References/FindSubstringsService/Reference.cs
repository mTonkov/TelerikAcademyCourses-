﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FindSubstring.ConsoleClient.FindSubstringsService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FindSubstringsService.IFindSubstring")]
    public interface IFindSubstring {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFindSubstring/SubstringCount", ReplyAction="http://tempuri.org/IFindSubstring/SubstringCountResponse")]
        int SubstringCount(string substring, string fullString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFindSubstring/SubstringCount", ReplyAction="http://tempuri.org/IFindSubstring/SubstringCountResponse")]
        System.Threading.Tasks.Task<int> SubstringCountAsync(string substring, string fullString);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFindSubstringChannel : FindSubstring.ConsoleClient.FindSubstringsService.IFindSubstring, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FindSubstringClient : System.ServiceModel.ClientBase<FindSubstring.ConsoleClient.FindSubstringsService.IFindSubstring>, FindSubstring.ConsoleClient.FindSubstringsService.IFindSubstring
    {
        
        public FindSubstringClient() {
        }
        
        public FindSubstringClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FindSubstringClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FindSubstringClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FindSubstringClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int SubstringCount(string substring, string fullString) {
            return base.Channel.SubstringCount(substring, fullString);
        }
        
        public System.Threading.Tasks.Task<int> SubstringCountAsync(string substring, string fullString) {
            return base.Channel.SubstringCountAsync(substring, fullString);
        }
    }
}
