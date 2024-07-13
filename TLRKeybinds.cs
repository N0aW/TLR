using System.Diagnostics;
using Terraria.ModLoader;

namespace TLR
{
	// Acts as a container for keybinds registered by this mod.
	// See Common/Players/ExampleKeybindPlayer for usage.
	public class TLRKeybinds : ModSystem
	{
		public static ModKeybind SwitchGravity { get; private set; }
        public static ModKeybind CursorTeleport { get; private set; }
		public static ModKeybind UseGadget { get; private set; }

		public override void Load() {
			// Registers a new keybind
			// We localize keybinds by adding a Mods.{ModName}.Keybind.{KeybindName} entry to our localization files. The actual text displayed to English users is in en-US.hjson
			SwitchGravity = KeybindLoader.RegisterKeybind(Mod, "SwitchGravity", "G");
            CursorTeleport = KeybindLoader.RegisterKeybind(Mod, "CursorTeleport", "Z");
			UseGadget = KeybindLoader.RegisterKeybind(Mod, "UseBrawlGadget", "X");
		}

		// Please see ExampleMod.cs' Unload() method for a detailed explanation of the unloading process.
		public override void Unload() {
			// Not required if your AssemblyLoadContext is unloading properly, but nulling out static fields can help you figure out what's keeping it loaded.
			SwitchGravity = null;
            CursorTeleport = null;
			UseGadget = null;
		}
	}
}