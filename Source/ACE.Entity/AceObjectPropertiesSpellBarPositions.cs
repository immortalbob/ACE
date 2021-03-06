﻿using System;
using ACE.Common;
using MySql.Data.MySqlClient;
namespace ACE.Entity
{
    [DbTable("ace_object_properties_spellbar_positions")]
    public class AceObjectPropertiesSpellBarPositions : ICloneable
    {
        [DbField("aceObjectId", (int)MySqlDbType.UInt32, IsCriteria = true, ListGet = true, ListDelete = true)]
        public uint AceObjectId { get; set; }

        [DbField("spellId", (int)MySqlDbType.UInt32)]
        public uint SpellId { get; set; }

        /// <summary>
        /// 0-7 are the allowed values
        /// </summary>
        [DbField("spellBarId", (int)MySqlDbType.UInt32)]
        public uint SpellBarId { get; set; }

        /// <summary>
        /// 0 based within a spell bar and must be unique within that bar.   Can be duplicated on other bars.
        /// </summary>
        [DbField("spellBarPositionId", (int)MySqlDbType.UInt32)]
        public uint SpellBarPositionId { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
