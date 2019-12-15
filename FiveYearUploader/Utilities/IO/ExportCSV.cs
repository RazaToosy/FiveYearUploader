using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using FiveYearUploader.Core;

namespace FiveYearUploader.Utilities.IO
{
    public class ExportCSV
    {
        public ExportCSV(List<ModelExeter> exeterList)
        {
            using (var writer = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "5YearExportForExeter.csv")))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(exeterList);
            }

        }
    }
}
