using System.Collections.Generic;
using System.Xml.Serialization;

namespace GlobalPlanningModel.Models
{
    public class Data
    {
        private List<Scenario> _scenarioField;
        [XmlElement("Scenario")]
        public List<Scenario> Scenarios
        {
            get { return _scenarioField ?? (_scenarioField = new List<Scenario>()); }
        }

    }
}