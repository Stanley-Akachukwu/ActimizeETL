using System.ComponentModel;

namespace ActimizeETL.Core.Services.Implementations.Identities
{

    [DisplayName("Customer Onboarding to Actimize Customer Due Diligence (CDD) and Know Your Customer (KYC) Data Processor Service")]
    public class CustomerKYCCDDataProcessorService : IETLProcessServices
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
