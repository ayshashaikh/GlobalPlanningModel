using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using GlobalPlanningModel.Models.Interfaces;

namespace GlobalPlanningModel.Models
{
    public class XmlFileReaderService : IXmlReaderService
    {
        public List<Scenario> ReadAllScenarios(string serverPath)
        {
            try
            {
                var xDocument = XDocument.Load(serverPath);
                var serializer = new XmlSerializer(typeof(Data));
                var data = (Data)serializer.Deserialize(xDocument.CreateReader());
                return data.Scenarios.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}