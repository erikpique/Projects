﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SingletonPattern.Models;


namespace Singleton
{
    public class Singleton
    {
        private readonly DatabaseEntities context;

        #region Singleton Pattern
        private static readonly Singleton instance = new Singleton();
        private Singleton()
        {
            context = new DatabaseEntities();
        }
        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
        #endregion
        public DatabaseEntities Context
        {
            get
            {
                return context;
            }
        }
    }

}
