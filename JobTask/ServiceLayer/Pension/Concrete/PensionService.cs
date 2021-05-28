using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JobTask.ServiceLayer.Pension.Concrete
{
    public class PensionService : IPensionService
    {
        public async Task<PensionModel> GetPensionDataAsync()
        {
            PensionModel model = null;
            await Task.Run(() =>
            {
                var client = new WebClient();
                client.Credentials = new NetworkCredential(Constants.Login, Constants.Password);

                var response = client.DownloadString(Constants.IntegAPI);

                model = JsonSerializer.Deserialize(response, typeof(PensionModel)) as PensionModel;
            });

            return model;
        }

        public async Task<PensionTinModel> GetPensionTinAsync(string pinfl)
        {
            PensionTinModel model = null;
            await Task.Run(() =>
            {
                try
                {
                    var client = new WebClient();
                    client.Credentials = new NetworkCredential(Constants.Login, Constants.Password);

                    var response = client.DownloadString(Constants.IntegAPI_TIN + pinfl.ToString());

                    model = JsonSerializer.Deserialize(response, typeof(PensionTinModel)) as PensionTinModel;
                }
                catch { }
            });

            return model;
        }

        public async Task<ErrorResultModel> PostDataAsync(PensionModel model)
        {
            await Task.Run(() =>
            {
                //enter code to store data

                return new ErrorResultModel();
            });

            return null;
        }
    }
}
