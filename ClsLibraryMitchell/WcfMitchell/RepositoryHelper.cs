using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfMitchell
{
    public class RepositoryHelper
    {
        Repository repository = new Repository();

        public Repository Repository
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string AddNewClaim(ClsLibraryMitchell.claMitchellClaim.MitchellClaimType mitchellClaimType)
        {
            string result = "";
            result = repository.AddNewClaim(mitchellClaimType);

            if (mitchellClaimType.Vehicles != null)
            {
                if (mitchellClaimType.Vehicles.VehicleDetails.Length > 0)
                {
                    for (int i = 0; i < mitchellClaimType.Vehicles.VehicleDetails.Length; i++)
                    {
                        repository.AddNewVehicle(mitchellClaimType.Vehicles.VehicleDetails[i], mitchellClaimType.ClaimNumber);
                    }
                        
                }
            }

            return result;
        }

        public ClsLibraryMitchell.claMitchellClaim.MitchellClaimType GetClaimDetails(string ClaimNumber)
        {
            ClsLibraryMitchell.claMitchellClaim.MitchellClaimType mitchellClaimType = new ClsLibraryMitchell.claMitchellClaim.MitchellClaimType();
            string sql = "select * from tblMitchellClaim where ClaimNumber = '" + ClaimNumber + "'";
            System.Data.DataSet ds = repository.ExecuteQuery(sql);
            
            if (ds.Tables[0].Rows.Count > 0)
            {
                mitchellClaimType.ClaimNumber = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                mitchellClaimType.ClaimantFirstName = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                mitchellClaimType.ClaimantLastName = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                mitchellClaimType.Status = ( ds.Tables[0].Rows[0].ItemArray[3].ToString().Equals("OPEN")? ClsLibraryMitchell.claMitchellClaim.StatusCode.OPEN : ClsLibraryMitchell.claMitchellClaim.StatusCode.CLOSE );
                mitchellClaimType.LossDate = DateTime.Parse(ds.Tables[0].Rows[0].ItemArray[4].ToString());
                mitchellClaimType.LossInfo = new ClsLibraryMitchell.claMitchellClaim.LossInfoType();
                
                switch (ds.Tables[0].Rows[0].ItemArray[5].ToString())
                {
                    case  "Collision":
                        mitchellClaimType.LossInfo.CauseOfLoss = ClsLibraryMitchell.claMitchellClaim.CauseOfLossCode.Collision;
                        break;
                    case "Explosion":
                        mitchellClaimType.LossInfo.CauseOfLoss = ClsLibraryMitchell.claMitchellClaim.CauseOfLossCode.Explosion;
                        break;
                    case "Fire":
                        mitchellClaimType.LossInfo.CauseOfLoss = ClsLibraryMitchell.claMitchellClaim.CauseOfLossCode.Fire;
                        break;
                    case "Hail":
                        mitchellClaimType.LossInfo.CauseOfLoss = ClsLibraryMitchell.claMitchellClaim.CauseOfLossCode.Hail;
                        break;
                    case "MechanicalBreakdown":
                        mitchellClaimType.LossInfo.CauseOfLoss = ClsLibraryMitchell.claMitchellClaim.CauseOfLossCode.MechanicalBreakdown;
                        break;
                    default:
                        mitchellClaimType.LossInfo.CauseOfLoss = ClsLibraryMitchell.claMitchellClaim.CauseOfLossCode.Other;
                        break;            
                }
                mitchellClaimType.LossInfo.ReportedDate = DateTime.Parse(ds.Tables[0].Rows[0].ItemArray[6].ToString());
                mitchellClaimType.LossInfo.LossDescription = ds.Tables[0].Rows[0].ItemArray[7].ToString();
                try
                {
                    mitchellClaimType.AssignedAdjusterID = Convert.ToInt64(ds.Tables[0].Rows[0].ItemArray[8].ToString());                
                }
                catch
                {
                    mitchellClaimType.AssignedAdjusterID = 0;                
                }
                
            }

            return mitchellClaimType;
        }

        public System.Data.DataSet GetAllClaimsDataSet()
        {
            string sql = "select * from tblMitchellClaim";
            System.Data.DataSet ds = repository.ExecuteQuery(sql);
            return ds;
        }


        public System.Data.DataSet GetAllClaimsDataSet(DateTime lossDateFrom, DateTime lossDateTo)
        {
            string sql = "select * from tblMitchellClaim where LossDate between '" + lossDateFrom.ToShortDateString() + "' and '" + lossDateTo.ToShortDateString() + "'";
            System.Data.DataSet ds = repository.ExecuteQuery(sql);
            return ds;
        }

        public System.Data.DataSet GetVechiles(string claimNumber)
        {
            string sql = "select * from tblVehicles where ClaimNumber = '" + claimNumber + "'";
            System.Data.DataSet ds = repository.ExecuteQuery(sql);
            return ds;
        }

        public bool DeleteClaim(string claimNumber)
        {
            bool result = false;
            string sql = "delete from tblMitchellClaim where ClaimNumber ='" + claimNumber + "'";
            int n = repository.ExecuteNonQuery(sql);
            if (n > 0)
                result = true;
            return result;
        }

        public bool UpdateClaim(ClsLibraryMitchell.claMitchellClaim.MitchellClaimType mct)
        {
            bool result = false;
            List<string> updateSQLList_tblMitchellClaim = new List<string>();
            List<string> updateSQLList_tblVehicle = new List<string>();
            System.Reflection.FieldInfo[] mctFields = mct.GetType().GetFields();
            for (int i = 0; i < mctFields.Length; i++)
            {
                if (this.HasValidValue(mctFields[i].GetValue(mct)) && mctFields[i].Name != "Vehicles" && mctFields[i].Name != "xmlns")
                {
                    updateSQLList_tblMitchellClaim.Add(mctFields[i].Name + "='" + mctFields[i].GetValue(mct).ToString() + "'");
                }
                    
            }
            if (mct.Vehicles != null)
            {
                if (mct.Vehicles.VehicleDetails.Length > 0)
                {
                    for (int i = 0; i < mct.Vehicles.VehicleDetails.Length; i++)
                    {
                        Console.WriteLine("Vehicle :" + i);
                        System.Reflection.FieldInfo[] vehicleFields = mct.Vehicles.VehicleDetails[i].GetType().GetFields();
                        for (int j = 0; j < vehicleFields.Length; j++)
                        {
                            if (this.HasValidValue(vehicleFields[j].GetValue(mct.Vehicles.VehicleDetails[i])))
                            {
                                updateSQLList_tblVehicle.Add(vehicleFields[j].Name + "= '" + vehicleFields[j].GetValue(mct.Vehicles.VehicleDetails[i]) + "'");
                            }                                                     
                        }
                        // Update DB
                        if (updateSQLList_tblVehicle.Count > 0)
                        {
                            string sql = " update tblVehicles set ";
                            for (int k = 0; k < updateSQLList_tblVehicle.Count - 1; k++)
                            {
                                sql += updateSQLList_tblVehicle[k] + " , ";
                            }
                            sql += updateSQLList_tblVehicle[updateSQLList_tblVehicle.Count - 1];
                            sql += " where Vin ='" + mct.Vehicles.VehicleDetails[i].Vin + "'";
                            repository.ExecuteNonQuery(sql);
                        }

                    }

                }
            }

            if (updateSQLList_tblMitchellClaim.Count > 0)
            {
                string sql = " update tblMitchellClaim set ";
                for (int i = 0; i < updateSQLList_tblMitchellClaim.Count-1; i++)
                {
                    sql += updateSQLList_tblMitchellClaim[i] + " , ";
                }
                sql += updateSQLList_tblMitchellClaim[updateSQLList_tblMitchellClaim.Count - 1];
                sql += " where ClaimNumber ='" + mct.ClaimNumber + "'";
                repository.ExecuteNonQuery(sql);
            }
            


            return result;
        }


        public List<ClsLibraryMitchell.claMitchellClaim.MitchellClaimType> GetAllClaimsList()
        {
            List<ClsLibraryMitchell.claMitchellClaim.MitchellClaimType> listClaims = new List<ClsLibraryMitchell.claMitchellClaim.MitchellClaimType>();
            string sql = "select * from tblMitchellClaim";
            System.Data.DataSet ds = repository.ExecuteQuery(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ClsLibraryMitchell.claMitchellClaim.MitchellClaimType mitchellClaimType = new ClsLibraryMitchell.claMitchellClaim.MitchellClaimType();
                    mitchellClaimType.ClaimNumber = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                    mitchellClaimType.ClaimantFirstName = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                    mitchellClaimType.ClaimantLastName = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                    mitchellClaimType.Status = (ds.Tables[0].Rows[0].ItemArray[3].ToString().Equals("OPEN") ? ClsLibraryMitchell.claMitchellClaim.StatusCode.OPEN : ClsLibraryMitchell.claMitchellClaim.StatusCode.CLOSE);
                    mitchellClaimType.LossDate = DateTime.Parse(ds.Tables[0].Rows[0].ItemArray[4].ToString());
                    mitchellClaimType.LossInfo = new ClsLibraryMitchell.claMitchellClaim.LossInfoType();

                    switch (ds.Tables[0].Rows[0].ItemArray[5].ToString())
                    {
                        case "Collision":
                            mitchellClaimType.LossInfo.CauseOfLoss = ClsLibraryMitchell.claMitchellClaim.CauseOfLossCode.Collision;
                            break;
                        case "Explosion":
                            mitchellClaimType.LossInfo.CauseOfLoss = ClsLibraryMitchell.claMitchellClaim.CauseOfLossCode.Explosion;
                            break;
                        case "Fire":
                            mitchellClaimType.LossInfo.CauseOfLoss = ClsLibraryMitchell.claMitchellClaim.CauseOfLossCode.Fire;
                            break;
                        case "Hail":
                            mitchellClaimType.LossInfo.CauseOfLoss = ClsLibraryMitchell.claMitchellClaim.CauseOfLossCode.Hail;
                            break;
                        case "MechanicalBreakdown":
                            mitchellClaimType.LossInfo.CauseOfLoss = ClsLibraryMitchell.claMitchellClaim.CauseOfLossCode.MechanicalBreakdown;
                            break;
                        default:
                            mitchellClaimType.LossInfo.CauseOfLoss = ClsLibraryMitchell.claMitchellClaim.CauseOfLossCode.Other;
                            break;
                    }
                    mitchellClaimType.LossInfo.ReportedDate = DateTime.Parse(ds.Tables[0].Rows[0].ItemArray[6].ToString());
                    mitchellClaimType.LossInfo.LossDescription = ds.Tables[0].Rows[0].ItemArray[7].ToString();
                    try
                    {
                        mitchellClaimType.AssignedAdjusterID = Convert.ToInt64(ds.Tables[0].Rows[0].ItemArray[8].ToString());
                    }
                    catch
                    {
                        mitchellClaimType.AssignedAdjusterID = 0;
                    }
                    listClaims.Add(mitchellClaimType);
                }
            }
            


            return listClaims;
        }

        public string TestDBConnection()
        {
            return repository.TestDB();
        }

        private bool HasValidValue(object obj)
        {
            bool result = true;
            if (obj == null)
                return false;
            try
            {
                if (Convert.ToInt32(obj) == 0)
                    return false;
                if (Convert.ToDateTime(obj) == new DateTime(1, 1, 1, 0, 0, 0))
                {
                    return false;
                }
            }
            catch { }
            try
            {

                if (Convert.ToDateTime(obj) == new DateTime(1, 1, 1, 0, 0, 0))
                {
                    return false;
                }
            }
            catch { }
            return result;
        }
    }
}