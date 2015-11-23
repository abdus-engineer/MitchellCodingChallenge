using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestClientMitchell
{
    public partial class WbFromShowData : System.Web.UI.Page
    {
        CRUDMitchell_WCFService.CRUDMitchellClient c = new CRUDMitchell_WCFService.CRUDMitchellClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadUI();
        }

        private void LoadUI()
        {
            
            System.Data.DataSet ds = c.GetAllClaimsDataSet();
            this.gvClaimData.DataSource = ds;
            this.gvClaimData.DataBind();
        }

        protected void gvClaimData_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "det")
            {
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                string claimNumber = this.gvClaimData.Rows[index].Cells[0].Text.ToString();
                Response.Redirect("WbFrmClaimInfo.aspx?claidID=" + claimNumber);
            }
            if (e.CommandName == "del")
            {
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                string claimNumber = this.gvClaimData.Rows[index].Cells[0].Text.ToString();
                if (c.DeleteClaim(claimNumber))
                    this.LoadUI();
                
            }
        }
    }
}