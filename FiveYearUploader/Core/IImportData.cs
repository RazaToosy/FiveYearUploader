using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveYearUploader.Core
{
    public interface IImportData<T> where T : class, new()
    {
        IList<T> FetchList(string FileName);
    }
}
