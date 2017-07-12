using OpenQbit.Hospital.Common.Models.opd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService.Contracts
{
   public interface IRecordManager
    {
        bool RecoredRecordsl(Record record);

        bool UpdataRecord(Record record);

        bool RemoveRecord(Record record);

        Record SearchRecord(String recordID);

        Array AllRecord();
    }
}
