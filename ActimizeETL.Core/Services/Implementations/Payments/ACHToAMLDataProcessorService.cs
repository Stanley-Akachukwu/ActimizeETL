using System.ComponentModel;

namespace ActimizeETL.Core.Services.Implementations.Payments
{
    [DisplayName("Automated Clearing House to Actimize Anti-Money Laundering Data Processor Service")]
    public class ACHToAMLDataProcessorService : IETLProcessServices
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
