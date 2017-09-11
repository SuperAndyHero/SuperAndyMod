using Terraria.ModLoader;

namespace SuperAndyMod
{
	class SuperAndyMod : Mod
	{
		public SuperAndyMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
