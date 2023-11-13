using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActimizeETL.Core.Services
{
    public interface IETLProcessServices
    {
        Task<string> ExtractDataFromSources();
        Task<string> TransformDataToActimizeModel();
        Task<string> MapDataToActimizeModel();
        Task<string> ValidateActimizeData();
        Task<string> LoadDataToActimizePlatform();
    }
}
