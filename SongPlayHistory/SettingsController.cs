﻿using BeatSaberMarkupLanguage.Attributes;

namespace SongPlayHistory
{
    public class SettingsController : PersistentSingleton<SettingsController>
    {
        [UIValue("show-play-counts")]
        public bool ShowPlayCounts
        {
            get => Plugin.Config.Value.ShowPlayCounts;
            set => Plugin.Config.Value.ShowPlayCounts = value;
        }

        [UIValue("sort-by-date")]
        public bool SortByDate
        {
            get => Plugin.Config.Value.SortByDate;
            set => Plugin.Config.Value.SortByDate = value;
        }

        [UIAction("#apply")]
        public void OnApply()
        {
            Logger.Log?.Info("Applying settings...");
            Plugin.ConfigProvider.Store(Plugin.Config.Value);
        }
    }
}