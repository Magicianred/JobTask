using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTask.ServiceLayer.Pension
{
    public interface IPensionService
    {
        /// <summary>
        /// some methods
        /// </summary>
        /// <returns></returns>
        Task<PensionModel> GetPensionDataAsync(string pinfl);
        Task<ErrorResultModel> PostDataAsync(PensionModel model);
        Task<PensionTinModel> GetPensionTinAsync(string pinfl);
    }
}
