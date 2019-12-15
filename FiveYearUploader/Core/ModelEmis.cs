using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace FiveYearUploader.Core
{
    public class ModelEmis
    {
        [Index(0)]
        public string FullName { get; set; }
        [Index(1)]
        public DateTime? DOB { get; set; }
        [Index(2)]
        public string NHSNumber { get; set; }
        [Index(3)]
        public string UsualGP { get; set; }
        [Index(4)]
        public DateTime? DateBooster { get; set; }
        [Index(5)]
        public string AsGMSBooster { get; set; }
    }
}
