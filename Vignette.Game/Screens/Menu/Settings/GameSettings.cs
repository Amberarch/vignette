// Copyright 2020 - 2021 Vignette Project
// Licensed under NPOSLv3. See LICENSE for details.

using osu.Framework.Graphics;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Localisation;
using Vignette.Game.Graphics.Typesets;
using Vignette.Game.Screens.Menu.Settings.Sections;

namespace Vignette.Game.Screens.Menu.Settings
{
    public class GameSettings : SettingsPage
    {
        public override LocalisableString Title => "Settings";

        public override IconUsage Icon => FluentSystemIcons.Settings24;

        public GameSettings()
        {
            AddRange(new Drawable[]
            {
                new GeneralSection(),
                new AppearanceSection(),
                new GraphicsSection(),
                new WindowSection(),
                new DebugSection(),
            });
        }
    }
}
