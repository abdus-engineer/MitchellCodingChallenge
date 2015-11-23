using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

namespace TestClientMitchell
{
    public partial class WbFrmHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {               
                XmlSerializer deserializer = new XmlSerializer(typeof(ClsLibraryMitchell.claMitchellClaim.MitchellClaimType));
                TextReader reader = new StreamReader(Server.MapPath("create-claim.xml"));
                object obj = deserializer.Deserialize(reader);
                ClsLibraryMitchell.claMitchellClaim.MitchellClaimType XmlData = (ClsLibraryMitchell.claMitchellClaim.MitchellClaimType)obj;                
                reader.Close();
                
                CRUDMitchell_WCFService.CRUDMitchellClient c = new CRUDMitchell_WCFService.CRUDMitchellClient();
                XmlData.ClaimNumber = this.Session.SessionID + System.DateTime.Now.Ticks;
                string res = c.CreateNewClaim(XmlData);
                this.Label1.Text += res;
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CRUDMitchell_WCFService.CRUDMitchellClient c = new CRUDMitchell_WCFService.CRUDMitchellClient();
            this.Label1.Text = c.TestDBConnection();           
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            CRUDMitchell_WCFService.CRUDMitchellClient c = new CRUDMitchell_WCFService.CRUDMitchellClient();
            ClsLibraryMitchell.claMitchellClaim.MitchellClaimType mct = c.GetClaimDetails("22c9c23bac142856018ce14a26b6csdfsf");
            string str = mct.ClaimantFirstName;
            Response.Redirect("WbFromShowData.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(ClsLibraryMitchell.claMitchellClaim.MitchellClaimType));
                TextReader reader = new StreamReader(Server.MapPath("update-claim.xml"));
                object obj = deserializer.Deserialize(reader);                
                ClsLibraryMitchell.claMitchellClaim.MitchellClaimType XmlData = (ClsLibraryMitchell.claMitchellClaim.MitchellClaimType)obj;
                reader.Close();
                CRUDMitchell_WCFService.CRUDMitchellClient c = new CRUDMitchell_WCFService.CRUDMitchellClient();
                c.UpdateClaim(XmlData);
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }
    }
}