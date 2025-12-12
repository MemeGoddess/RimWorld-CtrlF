using System.Reflection;
using System.Linq;
using Verse;
using RimWorld;
using UnityEngine;

namespace Ctrl_F
{
	public class Mod : Verse.Mod
	{
		public static Settings Settings;
		public Mod(ModContentPack content) : base(content)
		{
			Settings = GetSettings<Settings>();
		}

		public override string SettingsCategory()
		{
			return "TD.CtrlF".Translate();
		}

		public override void DoSettingsWindowContents(Rect inRect)
		{
			base.DoSettingsWindowContents(inRect);
			Settings.DoWindowContents(inRect);
		}
	}

	[StaticConstructorOnStartup]
	public static class CtrlFTex
	{
		//Names of objects in vanilla are haphazard so I might as well just declare these here.
		public static readonly Texture2D Separated = ContentFinder<Texture2D>.Get("UI/Designators/ZoneDelete");
		public static readonly Texture2D Connected = ContentFinder<Texture2D>.Get("UI/Designators/ZoneCreate_Stockpile");
	}
}