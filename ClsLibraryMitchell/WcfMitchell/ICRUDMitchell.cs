using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfMitchell
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICRUDMitchell" in both code and config file together.
    [ServiceContract]
    public interface ICRUDMitchell
    {
        [OperationContract]
        string CreateNewClaim(ClsLibraryMitchell.claMitchellClaim.MitchellClaimType mct);

        [OperationContract]
        ClsLibraryMitchell.claMitchellClaim.MitchellClaimType GetClaimDetails(string ClaimNumber);

        [OperationContract]
        List<ClsLibraryMitchell.claMitchellClaim.MitchellClaimType> GetAllClaimsList();

        [OperationContract]
        System.Data.DataSet GetAllClaimsDataSet();

        [OperationContract]
        System.Data.DataSet GetAllClaimsDataSet(DateTime lossDateFrom, DateTime lossDateTo);

        [OperationContract]
        System.Data.DataSet GetVechiles(string claimNumber);

        [OperationContract]
        bool DeleteClaim(string claimNumber);

        [OperationContract]
        bool UpdateClaim(ClsLibraryMitchell.claMitchellClaim.MitchellClaimType mct);


        [OperationContract]
        string TestDBConnection();
    }
}
