﻿using System.ComponentModel;

namespace ActimizeETL.Core.Services.Implementations.WatchLists
{
     
    [DisplayName("Customer KYC to Actimize Watch List Filtering Data Processor Service")]
    public class CustomerKYCToWLFDataProcessorService : IETLProcessServices
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
