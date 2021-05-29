using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTask.ServiceLayer
{
    public class Constants
    {
        public static readonly string IntegAPI = "https://api.soliq.uz/service/pension-fund/get-entrepreneur-income-tax-rate?pinfl=";
        public static readonly string IntegAPI_TIN = "https://api.soliq.uz/service/pension-fund/get-tin?pinfl=";
        public static readonly string Login = "pension-fund-api-user";
        public static readonly string Password = "pen$!0nu$er";
    }
}
