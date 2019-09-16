using System.Xml.Serialization;

namespace GlobalPlanningModel.Models
{
    [XmlRoot("Scenario")]
    public class Scenario
    {
        /// <remarks/>
        public int ScenarioId { get; set; }

        /// <remarks/>
        public string Name { get; set; }

        /// <remarks/>
        public string Surname {get; set; }

        /// <remarks/>
        public string Forename { get; set; }

        /// <remarks/>
        public string UserID { get; set; }

        /// <remarks/>
        public System.DateTime SampleDate { get; set; }

        /// <remarks/>
        public System.DateTime CreationDate { get; set; }

        /// <remarks/>
        public int NumMonths { get; set; }

        /// <remarks/>
        public int MarketID { get; set; }

        /// <remarks/>
        public int NetworkLayerID { get; set; }
    }
}