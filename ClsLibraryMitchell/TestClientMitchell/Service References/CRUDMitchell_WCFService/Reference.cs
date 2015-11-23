﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestClientMitchell.CRUDMitchell_WCFService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CRUDMitchell_WCFService.ICRUDMitchell")]
    public interface ICRUDMitchell {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDMitchell/CreateNewClaim", ReplyAction="http://tempuri.org/ICRUDMitchell/CreateNewClaimResponse")]
        string CreateNewClaim(ClsLibraryMitchell.claMitchellClaim.MitchellClaimType mct);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDMitchell/CreateNewClaim", ReplyAction="http://tempuri.org/ICRUDMitchell/CreateNewClaimResponse")]
        System.Threading.Tasks.Task<string> CreateNewClaimAsync(ClsLibraryMitchell.claMitchellClaim.MitchellClaimType mct);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDMitchell/GetClaimDetails", ReplyAction="http://tempuri.org/ICRUDMitchell/GetClaimDetailsResponse")]
        ClsLibraryMitchell.claMitchellClaim.MitchellClaimType GetClaimDetails(string ClaimNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDMitchell/GetClaimDetails", ReplyAction="http://tempuri.org/ICRUDMitchell/GetClaimDetailsResponse")]
        System.Threading.Tasks.Task<ClsLibraryMitchell.claMitchellClaim.MitchellClaimType> GetClaimDetailsAsync(string ClaimNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDMitchell/GetAllClaimsList", ReplyAction="http://tempuri.org/ICRUDMitchell/GetAllClaimsListResponse")]
        ClsLibraryMitchell.claMitchellClaim.MitchellClaimType[] GetAllClaimsList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDMitchell/GetAllClaimsList", ReplyAction="http://tempuri.org/ICRUDMitchell/GetAllClaimsListResponse")]
        System.Threading.Tasks.Task<ClsLibraryMitchell.claMitchellClaim.MitchellClaimType[]> GetAllClaimsListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDMitchell/GetAllClaimsDataSet", ReplyAction="http://tempuri.org/ICRUDMitchell/GetAllClaimsDataSetResponse")]
        System.Data.DataSet GetAllClaimsDataSet();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDMitchell/GetAllClaimsDataSet", ReplyAction="http://tempuri.org/ICRUDMitchell/GetAllClaimsDataSetResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetAllClaimsDataSetAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDMitchell/GetVechiles", ReplyAction="http://tempuri.org/ICRUDMitchell/GetVechilesResponse")]
        System.Data.DataSet GetVechiles(string claimNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDMitchell/GetVechiles", ReplyAction="http://tempuri.org/ICRUDMitchell/GetVechilesResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetVechilesAsync(string claimNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDMitchell/DeleteClaim", ReplyAction="http://tempuri.org/ICRUDMitchell/DeleteClaimResponse")]
        bool DeleteClaim(string claimNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDMitchell/DeleteClaim", ReplyAction="http://tempuri.org/ICRUDMitchell/DeleteClaimResponse")]
        System.Threading.Tasks.Task<bool> DeleteClaimAsync(string claimNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDMitchell/UpdateClaim", ReplyAction="http://tempuri.org/ICRUDMitchell/UpdateClaimResponse")]
        bool UpdateClaim(ClsLibraryMitchell.claMitchellClaim.MitchellClaimType mct);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDMitchell/UpdateClaim", ReplyAction="http://tempuri.org/ICRUDMitchell/UpdateClaimResponse")]
        System.Threading.Tasks.Task<bool> UpdateClaimAsync(ClsLibraryMitchell.claMitchellClaim.MitchellClaimType mct);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDMitchell/TestDBConnection", ReplyAction="http://tempuri.org/ICRUDMitchell/TestDBConnectionResponse")]
        string TestDBConnection();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDMitchell/TestDBConnection", ReplyAction="http://tempuri.org/ICRUDMitchell/TestDBConnectionResponse")]
        System.Threading.Tasks.Task<string> TestDBConnectionAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICRUDMitchellChannel : TestClientMitchell.CRUDMitchell_WCFService.ICRUDMitchell, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CRUDMitchellClient : System.ServiceModel.ClientBase<TestClientMitchell.CRUDMitchell_WCFService.ICRUDMitchell>, TestClientMitchell.CRUDMitchell_WCFService.ICRUDMitchell {
        
        public CRUDMitchellClient() {
        }
        
        public CRUDMitchellClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CRUDMitchellClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CRUDMitchellClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CRUDMitchellClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string CreateNewClaim(ClsLibraryMitchell.claMitchellClaim.MitchellClaimType mct) {
            return base.Channel.CreateNewClaim(mct);
        }
        
        public System.Threading.Tasks.Task<string> CreateNewClaimAsync(ClsLibraryMitchell.claMitchellClaim.MitchellClaimType mct) {
            return base.Channel.CreateNewClaimAsync(mct);
        }
        
        public ClsLibraryMitchell.claMitchellClaim.MitchellClaimType GetClaimDetails(string ClaimNumber) {
            return base.Channel.GetClaimDetails(ClaimNumber);
        }
        
        public System.Threading.Tasks.Task<ClsLibraryMitchell.claMitchellClaim.MitchellClaimType> GetClaimDetailsAsync(string ClaimNumber) {
            return base.Channel.GetClaimDetailsAsync(ClaimNumber);
        }
        
        public ClsLibraryMitchell.claMitchellClaim.MitchellClaimType[] GetAllClaimsList() {
            return base.Channel.GetAllClaimsList();
        }
        
        public System.Threading.Tasks.Task<ClsLibraryMitchell.claMitchellClaim.MitchellClaimType[]> GetAllClaimsListAsync() {
            return base.Channel.GetAllClaimsListAsync();
        }
        
        public System.Data.DataSet GetAllClaimsDataSet() {
            return base.Channel.GetAllClaimsDataSet();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetAllClaimsDataSetAsync() {
            return base.Channel.GetAllClaimsDataSetAsync();
        }
        
        public System.Data.DataSet GetVechiles(string claimNumber) {
            return base.Channel.GetVechiles(claimNumber);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetVechilesAsync(string claimNumber) {
            return base.Channel.GetVechilesAsync(claimNumber);
        }
        
        public bool DeleteClaim(string claimNumber) {
            return base.Channel.DeleteClaim(claimNumber);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteClaimAsync(string claimNumber) {
            return base.Channel.DeleteClaimAsync(claimNumber);
        }
        
        public bool UpdateClaim(ClsLibraryMitchell.claMitchellClaim.MitchellClaimType mct) {
            return base.Channel.UpdateClaim(mct);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateClaimAsync(ClsLibraryMitchell.claMitchellClaim.MitchellClaimType mct) {
            return base.Channel.UpdateClaimAsync(mct);
        }
        
        public string TestDBConnection() {
            return base.Channel.TestDBConnection();
        }
        
        public System.Threading.Tasks.Task<string> TestDBConnectionAsync() {
            return base.Channel.TestDBConnectionAsync();
        }
    }
}
