using System.IO;
using GlobalPlanningModel.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GlobalPlanningModel.Tests.Model
{
    [TestClass]
    public class XmlFileReaderTests
    {

        [TestMethod]
        public void XmlFileReader_CanLoadXMLProvided_CorrectFileName()
        {
            XmlFileReaderService xmlFileReaderService = new XmlFileReaderService();
            var stringPath = @"C:\Users\ashaikh\source\repos\GlobalPlanningModel\GlobalPlanningModel\App_Data\Data.xml";
          
            var result = xmlFileReaderService.ReadAllScenarios(stringPath);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count>0);

        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void XmlFileReader_CanLoadXMLProvided_WrongFileName()
        {
            XmlFileReaderService xmlFileReaderService = new XmlFileReaderService();
            var stringPath = @"C:\Users\ashaikh\source\repos\GlobalPlanningModel\GlobalPlanningModel\App_Data\Data1.xml";

            var result = xmlFileReaderService.ReadAllScenarios(stringPath);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 0);

        }
    }
}
