using System;
using System.Collections.Generic;

namespace Factory3
{
	class ReplaceableThemeFactory
	{
		private readonly List<WeakReference<Ref<ITheme>>> themes = new(); 

		private ITheme CreateThemeImpl(bool dark)
		{
			return dark ? new DarkTheme() : new LightTheme();
		}

		public Ref<ITheme> CreateTheme(bool dark)
		{
			var r = new Ref<ITheme>(CreateThemeImpl(dark));
			themes.Add(new(r));
			return r;
		}

		public void ReplaceTheme(bool dark)
		{
			foreach (var theme in themes)
			{
				if (theme.TryGetTarget(out var reference))
				{
					reference.Value = CreateThemeImpl(dark);
				}
			}
		}
	}
}
