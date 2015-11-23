using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestClientMitchell
{
    public partial class WbFrmClaimInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string claimID = Request.QueryString[0];
            CRUDMitchell_WCFService.CRUDMitchellClient c = new CRUDMitchell_WCFService.CRUDMitchellClient();
            ClsLibraryMitchell.claMitchellClaim.MitchellClaimType mct = c.GetClaimDetails(claimID);
            this.lblClaimNumber.Text = mct.ClaimNumber;
            this.txtFirstName.Text = mct.ClaimantFirstName;
            this.txtLastName.Text = mct.ClaimantLastName;
            if (mct.Status == ClsLibraryMitchell.claMitchellClaim.StatusCode.OPEN)
                this.ddlStatus.SelectedIndex = 0;
            else
                this.ddlStatus.SelectedIndex = 1;
            this.txtLossDateMM.Text = "" + mct.LossDate.Month;
            this.txtLossDateDD.Text = "" + mct.LossDate.Day;
            this.txtLossDateYYYY.Text = "" + mct.LossDate.Year;

            switch (mct.LossInfo.CauseOfLoss)
            {
                case ClsLibraryMitchell.claMitchellClaim.CauseOfLossCode.Collision:
                    this.ddlCuaseOfLoss.SelectedIndex = 0;
                    break;
                case ClsLibraryMitchell.claMitchellClaim.CauseOfLossCode.Explosion:
                    this.ddlCuaseOfLoss.SelectedIndex = 1;
                    break;
                case ClsLibraryMitchell.claMitchellClaim.CauseOfLossCode.Fire:
                    this.ddlCuaseOfLoss.SelectedIndex = 2;
                    break;
                case ClsLibraryMitchell.claMitchellClaim.CauseOfLossCode.Hail:
                    this.ddlCuaseOfLoss.SelectedIndex = 3;
                    break;
                case ClsLibraryMitchell.claMitchellClaim.CauseOfLossCode.MechanicalBreakdown:
                    this.ddlCuaseOfLoss.SelectedIndex =4;
                    break;
                case ClsLibraryMitchell.claMitchellClaim.CauseOfLossCode.Other:
                    this.ddlCuaseOfLoss.SelectedIndex = 5;
                    break;
                default:
                    this.ddlCuaseOfLoss.SelectedIndex = 5;
                    break;
            }
            this.txtReportDateMM.Text = "" + mct.LossInfo.ReportedDate.Month;
            this.txtReportDateDD.Text = "" + mct.LossInfo.ReportedDate.Day;
            this.txtReportDateYYYY.Text = "" + mct.LossInfo.ReportedDate.Year;
            this.txtLossDesc.Text = mct.LossInfo.LossDescription;
            this.txtAssignAdjID.Text = "" + mct.AssignedAdjusterID;

            System.Data.DataSet ds = c.GetVechiles(mct.ClaimNumber);
            if(ds.Tables[0].Rows.Count >0)
            {
                this.gvVehicle.DataSource = ds.Tables[0];
                this.gvVehicle.DataBind();
            }

        }
    }
}