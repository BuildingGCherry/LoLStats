﻿#region References

using System;
using System.Collections.Generic;
using LoLStats.Data.Context;
using LoLStats.Shared.Interfaces;
using LoLStats.Shared.Models.Entities;

#endregion

namespace LoLStats.Core.Managers
{
    public class ChampionManager : IChampionManager
    {
        #region Fields

        protected static readonly string gncRiotAPIKey = "c92b6d81-20ff-438c-a966-503fa839c3e5";
        private LoLDBContext _lolDBContext = new LoLDBContext();

        #endregion

        #region Methods

        public Champion Add(Champion item)
        {
            throw new NotImplementedException();
        }

        public Champion DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Champion EditById(Champion item, int id)
        {
            throw new NotImplementedException();
        }

        public List<Champion> GetAll()
        {
            throw new NotImplementedException();
        }

        public Champion GetOneById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAllChampionsFromRiotApi(Champion champ)
        {
            throw new NotImplementedException();
        }

        public bool UpdateNewChampionsFromRiotApi(Champion champ)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}