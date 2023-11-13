
using System.ComponentModel;

namespace ActimizeETL.Core.Services.Implementations.Payments
{
     
    [DisplayName("Wire Transfer to Actimize Suspicious Activity Monitoring Data Processor Service")]
    public class WFToSAMDataProcessorService : IETLProcessServices
    {
        public Task<string> ExtractDataFromSources()
        {
            throw new NotImplementedException();
        }
        public Task<string> TransformDataToActimizeModel()
        {
            throw new NotImplementedException();
        }
        public Task<string> MapDataToActimizeModel()
        {
            throw new NotImplementedException();
        }
        public Task<string> ValidateActimizeData()
        {
            throw new NotImplementedException();
        }
        public Task<string> LoadDataToActimizePlatform()
        {
            throw new NotImplementedException();
        }
    }
}
