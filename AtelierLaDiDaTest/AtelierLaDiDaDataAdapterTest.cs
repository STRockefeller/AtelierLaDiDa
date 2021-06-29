using NUnit.Framework;
using AtelierLaDiDaDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using AtelierLaDiDaDatabase.Models;
using AtelierLaDiDaDataAdapter;

namespace AtelierLaDiDaTest
{
    [TestFixture]
    class AtelierLaDiDaDataAdapterTest
    {
        [SetUp]
        public void SetUp() { }
        /// <summary>
        /// 跑一些method看看會不會跳例外
        /// </summary>
        [Test]
        public void DataAdapter_FunctionRun()
        {
            DataAdapter.SetDBPath("hahaha");
            DataAdapter.SetSeriesName("A11");
        }
    }
}
