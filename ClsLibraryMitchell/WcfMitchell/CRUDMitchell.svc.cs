using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfMitchell
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CRUDMitchell" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CRUDMitchell.svc or CRUDMitchell.svc.cs at the Solution Explorer and start debugging.
    public class CRUDMitchell : ICRUDMitchell
    {
        RepositoryHelper repHelder = new RepositoryHelper();

        public RepositoryHelper RepositoryHelper
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public string CreateNewClaim(ClsLibraryMitchell.claMitchellClaim.MitchellClaimType mitchellClaim)
        {
            string result = "";
            result = repHelder.AddNewClaim(mitchellClaim);
            return result;
        }
        
        public string TestDBConnection()
        {
            return repHelder.TestDBConnection();
        }


        public ClsLibraryMitchell.claMitchellClaim.MitchellClaimType GetClaimDetails(string ClaimNumber)
        {
            return repHelder.GetClaimDetails(ClaimNumber);
        }

        public List<ClsLibraryMitchell.claMitchellClaim.MitchellClaimType> GetAllClaimsList()
        {
            return repHelder.GetAllClaimsList();
        }


        System.Data.DataSet ICRUDMitchell.GetAllClaimsDataSet()
        {
            return repHelder.GetAllClaimsDataSet();
        }


        public System.Data.DataSet GetVechiles(string claimNumber)
        {
            return repHelder.GetVechiles(claimNumber);
        }


        public bool DeleteClaim(string claimNumber)
        {
            return repHelder.DeleteClaim(claimNumber);
        }

        public bool UpdateClaim(ClsLibraryMitchell.claMitchellClaim.MitchellClaimType mct)
        {
            return repHelder.UpdateClaim(mct);
        }


        public System.Data.DataSet GetAllClaimsDataSet(DateTime lossDateFrom, DateTime lossDateTo)
        {
            return repHelder.GetAllClaimsDataSet(lossDateFrom, lossDateTo);
        }
    }
}
