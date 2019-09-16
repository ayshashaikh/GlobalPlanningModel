using System.Collections.Generic;

namespace GlobalPlanningModel.Models.Interfaces
{
    public interface IXmlReaderService
    {
        List<Scenario> ReadAllScenarios(string serverPath);
    }
}
