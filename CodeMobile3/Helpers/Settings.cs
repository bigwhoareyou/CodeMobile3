// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace CodeMobile3.Helpers
{
	/// <summary>
	/// This is the Settings static class that can be used in your Core solution or in any
	/// of your client applications. All settings are laid out the same exact way with getters
	/// and setters. 
	/// </summary>
	public static class Settings
	{
		private static ISettings AppSettings
		{
			get
			{
				return CrossSettings.Current;
			}
		}

		#region Setting Constants

		private const string SettingsKey = "settings_key";
		private static readonly string SettingsDefault = string.Empty;

		#endregion


		public static string GeneralSettings
		{
			get
			{
				return AppSettings.GetValueOrDefault(SettingsKey, SettingsDefault);
			}
			set
			{
				AppSettings.AddOrUpdateValue(SettingsKey, value);
			}
		}

        public static string Name
        {
            get
            {
                return AppSettings.GetValueOrDefault("Name", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("Name", value);
            }
        }

        public static int Age
        {
            get
            {
                return AppSettings.GetValueOrDefault("Age", 0);
            }
            set
            {
                AppSettings.AddOrUpdateValue("Age", value);
            }
        }

        public static string Path
        {
            get
            {
                return AppSettings.GetValueOrDefault("Path", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("Path", value);
            }
        }

	}
}