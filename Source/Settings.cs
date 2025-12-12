using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace Ctrl_F
{
	public class Settings : ModSettings
	{
		public bool ShowButton = true;

		public override void ExposeData()
		{
			Scribe_Values.Look(ref ShowButton, "TD.ShowSearchButton", true);
		}

		public void DoWindowContents(Rect wRect)
		{
			var options = new Listing_Standard();
			options.Begin(wRect);

			options.CheckboxLabeled("TD.ShowSearchButton".Translate(), ref ShowButton);

			options.End();
		}
	}
}
