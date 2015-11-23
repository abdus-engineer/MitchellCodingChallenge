using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WcfMitchell
{
    public class Repository
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MitchellDBConnection"].ConnectionString;

        public string TestDB()
        {
            string result = "";
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(this.connectionString);
            try
            {
                
                con.Open();
                result = "DB Connection Successful";
            }
            catch (Exception ex)
            {
                result = "Error DB Connection. Detail: " + ex.Message;
            }
            finally
            {
                con.Close();
            }

            return result;
        }

        public string AddNewVehicle(ClsLibraryMitchell.claMitchellClaim.VehicleInfoType vehicle, string claimNumber)
        {
            string result = "";

            SqlConnection conn = new SqlConnection(this.connectionString);
            try
            {
                conn.Open();
                string sql = "SP_ADD_NEW_VEHICLE";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@ClaimNumber", System.Data.SqlDbType.VarChar, 200);
                p1.Value = claimNumber;
                cmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@ModelYear", System.Data.SqlDbType.Int, 50);
                p2.Value = vehicle.ModelYear;
                cmd.Parameters.Add(p2);

                SqlParameter p3 = new SqlParameter("@MakeDescription", System.Data.SqlDbType.VarChar, 50);
                p3.Value = vehicle.MakeDescription;
                cmd.Parameters.Add(p3);

                SqlParameter p4 = new SqlParameter("@ModelDescription", System.Data.SqlDbType.VarChar, 50);
                p4.Value = vehicle.ModelDescription;
                cmd.Parameters.Add(p4);

                SqlParameter p5 = new SqlParameter("@EngineDescription", System.Data.SqlDbType.VarChar, 50);
                p5.Value = vehicle.EngineDescription;
                cmd.Parameters.Add(p5);

                SqlParameter p6 = new SqlParameter("@ExteriorColor", System.Data.SqlDbType.VarChar, 50);
                p6.Value = vehicle.ExteriorColor;
                cmd.Parameters.Add(p6);

                SqlParameter p7 = new SqlParameter("@Vin", System.Data.SqlDbType.VarChar, 50);
                p7.Value = vehicle.Vin;
                cmd.Parameters.Add(p7);

                SqlParameter p8 = new SqlParameter("@LicPlate", System.Data.SqlDbType.VarChar, 50);
                p8.Value = vehicle.LicPlate;
                cmd.Parameters.Add(p8);

                SqlParameter p9 = new SqlParameter("@LicPlateState", System.Data.SqlDbType.VarChar, 50);
                p9.Value = vehicle.LicPlateState;
                cmd.Parameters.Add(p9);

                SqlParameter p10 = new SqlParameter("@LicPlateExpDate", System.Data.SqlDbType.Date, 50);
                p10.Value = vehicle.LicPlateExpDate;
                cmd.Parameters.Add(p10);

                SqlParameter p11 = new SqlParameter("@DamageDescription", System.Data.SqlDbType.VarChar, 50);
                p11.Value = vehicle.DamageDescription;
                cmd.Parameters.Add(p11);

                SqlParameter p12 = new SqlParameter("@Mileage", System.Data.SqlDbType.Int, 50);
                p12.Value = vehicle.Mileage;
                cmd.Parameters.Add(p12);

                result = "" + cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public string AddNewClaim(ClsLibraryMitchell.claMitchellClaim.MitchellClaimType mitchellClaimType)
        {
            string result = "";
            SqlConnection conn = new SqlConnection(this.connectionString);
            try
            {
                conn.Open();
                string sql = "SP_ADD_NEW_CLAIM"; 
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@ClaimNumber", System.Data.SqlDbType.VarChar, 200);                                
                p1.Value = mitchellClaimType.ClaimNumber;
                cmd.Parameters.Add(p1);
                
                SqlParameter p2 = new SqlParameter("@ClaimantFirstName", System.Data.SqlDbType.VarChar, 50);
                p2.Value = mitchellClaimType.ClaimantFirstName;
                cmd.Parameters.Add(p2);

                SqlParameter p3 = new SqlParameter("@ClaimantLastName", System.Data.SqlDbType.VarChar, 50);
                p3.Value = mitchellClaimType.ClaimantLastName;
                cmd.Parameters.Add(p3);

                SqlParameter p4 = new SqlParameter("@Status", System.Data.SqlDbType.VarChar, 50);
                p4.Value = mitchellClaimType.Status;
                cmd.Parameters.Add(p4);

                SqlParameter p5 = new SqlParameter("@LossDate", System.Data.SqlDbType.DateTime, 50);
                p5.Value = mitchellClaimType.LossDate;
                cmd.Parameters.Add(p5);

                SqlParameter p6 = new SqlParameter("@CauseOfLoss", System.Data.SqlDbType.VarChar, 50);
                p6.Value = mitchellClaimType.LossInfo.CauseOfLoss;
                cmd.Parameters.Add(p6);

                SqlParameter p7 = new SqlParameter("@ReportedDate", System.Data.SqlDbType.DateTime, 50);
                p7.Value = mitchellClaimType.LossInfo.ReportedDate;
                cmd.Parameters.Add(p7);

                SqlParameter p8 = new SqlParameter("@LossDescription", System.Data.SqlDbType.VarChar, 50);
                p8.Value = mitchellClaimType.LossInfo.LossDescription;
                cmd.Parameters.Add(p8);

                SqlParameter p9 = new SqlParameter("@AssignedAdjusterID", System.Data.SqlDbType.BigInt, 50);
                p9.Value = mitchellClaimType.AssignedAdjusterID;
                cmd.Parameters.Add(p9);
                result = "" +  cmd.ExecuteNonQuery();

                if (mitchellClaimType.Vehicles != null)
                {

                }

            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        

        public int ExecuteNonQuery(string sql)
        {
            int result = 0;
            System.Data.SqlClient.SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;
                result  =  cmd.ExecuteNonQuery();
                
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public System.Data.DataSet ExecuteQuery(string sql)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            System.Data.SqlClient.SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql,con);
                dap.Fill(ds);
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            return ds;
        }
    }
}