using AtelierLaDiDaDatabase;
using AtelierLaDiDaDatabase.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace AtelierLaDiDaTest
{
    [TestFixture]
    internal class AtelierLaDiDaDatabaseTest
    {
        [SetUp]
        public void Startup()
        {
        }

        /// <summary>
        /// 測試資料取得-A11
        /// </summary>
        [Test]
        public void GetItemInfo_Rorona_Item1()
        {
            List<IAtelier> rorona = GetInfo.GetItemInfo(AtelierLaDiDaDatabase.EnumSeriesName.A11_Atelier_Rorona);

            var actual = rorona[0] as Rorona;
            var expected = new Rorona() { Japanese = "ニューズ", Name = "針木果實", No = 1, Type1 = "植物類", Type2 = "中和劑" };

            Assert.AreEqual(expected.No, actual.No);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Japanese, actual.Japanese);
            Assert.AreEqual(expected.Type1, actual.Type1);
            Assert.AreEqual(expected.Type2, actual.Type2);
        }

        /// <summary>
        /// 測試資料取得-A12
        /// </summary>
        [Test]
        public void GetItemInfo_Totori_Item3()
        {
            List<IAtelier> totori = GetInfo.GetItemInfo(AtelierLaDiDaDatabase.EnumSeriesName.A12_Atelier_Totori);

            var actual = totori[2] as Totori;
            var expect = new Totori() { Name = "橡木", No = 3 };

            Assert.AreEqual(expect.No, actual.No);
            Assert.AreEqual(expect.Name, actual.Name);
        }

        /// <summary>
        /// 測試資料取得-A17
        /// </summary>
        [Test]
        public void GetItemInfo_Sophie_Item23()
        {
            List<IAtelier> sophie = GetInfo.GetItemInfo(AtelierLaDiDaDatabase.EnumSeriesName.A17_Atelier_Sophie);

            var actual = sophie[22] as Sophie;
            var expect = new Sophie() { Name = "妖精的土丸子", No = 23 };

            Assert.AreEqual(expect.No, actual.No);
            Assert.AreEqual(expect.Name, actual.Name);
        }

        /// <summary>
        /// 測試資料取得-A20
        /// </summary>
        [Test]
        public void GetItemInfo_Lulua_Item11()
        {
            List<IAtelier> lulua = GetInfo.GetItemInfo(AtelierLaDiDaDatabase.EnumSeriesName.A20_Atelier_Lulua);

            var actual = lulua[10] as Lulua;
            var expect = new Lulua() { Name = "千日草", No = 11 };

            Assert.AreEqual(expect.No, actual.No);
            Assert.AreEqual(expect.Name, actual.Name);
        }

        /// <summary>
        /// 測試資料取得-A21
        /// </summary>
        [Test]
        public void GetItemInfo_Ryza_Item382()
        {
            List<IAtelier> ryza = GetInfo.GetItemInfo(AtelierLaDiDaDatabase.EnumSeriesName.A21_Atelier_Ryza);

            var actual = ryza[381] as Ryza;
            var expect = new Ryza() { Name = "英靈之魂", No = 382 };

            Assert.AreEqual(expect.No, actual.No);
            Assert.AreEqual(expect.Name, actual.Name);
        }
    }
}