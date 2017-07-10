﻿using OpenQbit.Hospital.BusinessService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Hospital.Common.Models;
using OpenQbit.Hospital.DataAccess.DAL.Contracts;
using OpenQbit.Hospital.Common.Utils.Logs;
using Microsoft.Practices.Unity;

namespace OpenQbit.Hospital.BusinessService
{
    public class ItemManager : IItemManager
    {
        private IRepository _repository;

        private ILogger _log;

        [InjectionConstructor]  
        public ItemManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }


        //[Dependency] 
        //public IRepository Repository
        //{
        //    get { return _repository; }
        //    set { _repository = value; }
        //}

        //[Dependency] 
        //public ILogger Logger
        //{
        //    get { return _log; }
        //    set { _log = value; }
        //}


        //[InjectionMethod] 
        //public void SetRepository(IRepository repository)
        //{
        //    _repository = repository;
        //}

        public bool RecoredItem(Item item)
        {
            _log.LogError("");

            return _repository.Create<Item>(item);
        }
    }
}
