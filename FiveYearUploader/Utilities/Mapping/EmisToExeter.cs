using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiveYearUploader.Core;
using FiveYearUploader.Properties;

namespace FiveYearUploader.Utilities.Mapping
{
    public class EmisToExeter
    {

        public List<ModelExeter> ConvertEmisToExeter(List<ModelEmis> emisData)
        {
            string gpCode = Settings.Default.GPCode;
            string dataSource = Settings.Default.DataSource;
            string listDate = Settings.Default.ListDate;

            var exeterData = new List<ModelExeter>();

            emisData.ForEach(e =>
            {
                if (e.AsGMSBooster != String.Empty)
                {
                    var exeterFiveInOne = new ModelExeter
                    {
                        GP_CODE = gpCode,
                        DATASOURCE = dataSource,
                        LIST_DATE = listDate,
                        IMMUNISATION_DATE = e.DateBooster.Value.ToString("dd" + "." + "MM" + "." + "yyyy"),
                        IMMUNISATION_TYPE = Enums.ImmunisationType.BOOSTER.ToString(),
                        NHS_NUMBER = e.NHSNumber.Replace(" ",""),
                        IMMUNISATION_UNDER_GMS = e.AsGMSBooster == "True" ? "Y" : "N"
                    };
                    exeterData.Add(exeterFiveInOne);
                }

            });

            return exeterData.Where(e=>e.IMMUNISATION_UNDER_GMS!=null).ToList();

        }
    }
}
