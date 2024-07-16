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
        [Header ("classsettings")]
        [DefaultValue(true)]
        [ReloadRequired]
        public bool SadismEnabled;
        [DefaultValue(true)]
        [ReloadRequired]
        public bool MasochismEnabled;
        [DefaultValue(true)]
        public bool ItemReclassing;
        [Header ("itemsettings")]
        [DefaultValue(true)]
        [ReloadRequired]
        public bool Gamebreakers;
        [Header("wipcontent")]
        [DefaultValue(2)]
        [Range(0, 2)]
        [ReloadRequired]
        public int Spriteless;
    }
}