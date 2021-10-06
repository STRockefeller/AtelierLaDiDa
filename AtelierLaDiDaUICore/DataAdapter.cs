using System;
using AtelierLaDiDaDatabase;
using System.Collections.Generic;

namespace AtelierLaDiDaUICore
{
    /// <summary>
    /// 物品類別
    /// </summary>
    public class CustomData
    {
        public CustomData MigrateFromIAtelier(IAtelier atelier)
        {
            ID = Convert.ToInt32(atelier.No);
            Name = atelier.Name;
            JapaneseName = atelier.Japanese;
            if (!String.IsNullOrEmpty(atelier.Attribute1))
                Attribute.Add(atelier.Attribute1);
            if (!String.IsNullOrEmpty(atelier.Attribute2))
                Attribute.Add(atelier.Attribute2);
            if (!String.IsNullOrEmpty(atelier.Attribute3))
                Attribute.Add(atelier.Attribute3);
            if (!String.IsNullOrEmpty(atelier.Attribute4))
                Attribute.Add(atelier.Attribute4);
            if (!String.IsNullOrEmpty(atelier.Attribute5))
                Attribute.Add(atelier.Attribute5);
            if (!String.IsNullOrEmpty(atelier.Type1))
                Type.Add(atelier.Type1);
            if (!String.IsNullOrEmpty(atelier.Type2))
                Type.Add(atelier.Type2);
            if (!String.IsNullOrEmpty(atelier.Type3))
                Type.Add(atelier.Type3);
            if (!String.IsNullOrEmpty(atelier.Type4))
                Type.Add(atelier.Type4);
            if (!String.IsNullOrEmpty(atelier.Type5))
                Type.Add(atelier.Type5);
            if (!String.IsNullOrEmpty(atelier.Type6))
                Type.Add(atelier.Type6);
            if (!String.IsNullOrEmpty(atelier.Source1))
                Source.Add(atelier.Source1);
            if (!String.IsNullOrEmpty(atelier.Source2))
                Source.Add(atelier.Source2);
            if (!String.IsNullOrEmpty(atelier.Source3))
                Source.Add(atelier.Source3);
            if (!String.IsNullOrEmpty(atelier.Source4))
                Source.Add(atelier.Source4);
            return this;
        }

        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 名稱
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 日文名稱
        /// </summary>
        public string JapaneseName { get; set; }

        /// <summary>
        /// 英文名稱
        /// </summary>
        public string EnglishName { get; set; }

        /// <summary>
        /// 屬性
        /// </summary>
        public List<string> Attribute { get; set; } = new List<string>();

        /// <summary>
        /// 類型
        /// </summary>
        public List<string> Type { get; set; } = new List<string>();

        /// <summary>
        /// 原料
        /// </summary>
        public List<string> Source { get; set; } = new List<string>();
    }
}