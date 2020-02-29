﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hananoki;
namespace HananokiEditor {
	public static class EditorIcon  {
		public static Texture2D Error => Icon.Get( "console.erroricon.sml" );
		public static Texture2D Warning => Icon.Get( "console.warnicon.sml" );
		public static Texture2D Info => Icon.Get( "console.infoicon.sml" );
		//"console.warnicon.inactive.sml"
	}
}