﻿using OpenQbit.Hospital.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService.Contracts
{
    public interface IPatientManager
    {
        bool RecoredPatien(Patient patient);
    }
}
