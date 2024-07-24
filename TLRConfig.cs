using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Terraria.UI;
using tModPorter;

namespace TLR
{
    public class TLRConfigServer : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        [Header ("overhauls")]
        [DefaultValue(true)]
        public bool UselessOverhauls;
        [DefaultValue(true)]
        public bool LargeGemBuffs;
    }
}