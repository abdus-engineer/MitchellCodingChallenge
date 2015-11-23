using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClsLibraryMitchell
{
    public class claMitchellClaim
    {
        
        [XmlRoot(ElementName = "MitchellClaim", Namespace = "http://www.mitchell.com/examples/claim")]
        public class MitchellClaimType
        {                
            public string ClaimNumber;
            public string ClaimantFirstName;                
            public string ClaimantLastName;                
            public StatusCode Status;                
            public DateTime LossDate;                
            public LossInfoType LossInfo;                
            public long AssignedAdjusterID;                
            public VehicleListType Vehicles;


            [XmlNamespaceDeclarations]
            public XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();
            public MitchellClaimType()
            {
                xmlns.Add("cla", "http://www.mitchell.com/examples/claim");
            }

        }
        public MitchellClaimType MitchellClaim;

        public enum StatusCode
        {
            OPEN,
            CLOSE
        }
                        
        public class LossInfoType
        {
            public CauseOfLossCode CauseOfLoss;                
            public DateTime ReportedDate;                
            public string LossDescription;
        }

        public enum CauseOfLossCode
        {
            Collision,
            Explosion,
            Fire,
            Hail,
            MechanicalBreakdown,
            Other
        }

        [XmlRoot(ElementName = "Vehicles", Namespace = "http://www.mitchell.com/examples/claim")]
        public class VehicleListType
        {
            [XmlElement(Namespace = "http://www.mitchell.com/examples/claim")]
            public VehicleInfoType[] VehicleDetails;
            
        }
        [XmlRoot(ElementName = "VehicleDetails", Namespace = "http://www.mitchell.com/examples/claim")]
        public class VehicleInfoType
        {
            [XmlElement(Namespace = "http://www.mitchell.com/examples/claim")]
            public int ModelYear;
            [XmlElement(Namespace = "http://www.mitchell.com/examples/claim")]
            public string MakeDescription;
            [XmlElement(Namespace = "http://www.mitchell.com/examples/claim")]
            public string ModelDescription;
            [XmlElement(Namespace = "http://www.mitchell.com/examples/claim")]
            public string EngineDescription;
            [XmlElement(Namespace = "http://www.mitchell.com/examples/claim")]
            public string ExteriorColor;
            [XmlElement(Namespace = "http://www.mitchell.com/examples/claim")]
            public string Vin;
            [XmlElement(Namespace = "http://www.mitchell.com/examples/claim")]
            public string LicPlate;
            [XmlElement(Namespace = "http://www.mitchell.com/examples/claim")]
            public string LicPlateState;
            [XmlElement(Namespace = "http://www.mitchell.com/examples/claim")]
            public DateTime LicPlateExpDate;
            [XmlElement(Namespace = "http://www.mitchell.com/examples/claim")]
            public string DamageDescription;
            [XmlElement(Namespace = "http://www.mitchell.com/examples/claim")]
            public int Mileage;
                        
        }
    }

}
