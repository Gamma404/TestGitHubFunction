﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Db Context
        /// </summary>
        DbContext Context { get; set; }
    }
}