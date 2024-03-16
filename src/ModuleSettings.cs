using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Blish_HUD.Settings;

namespace Nekres.Mumble_Info
{
    public class ModuleSettings
    {
        private static ModuleSettings Instance {get;}

        private SettingEntry<KeyBinding> _toggleInfoBinding;
        private SettingEntry<bool>  _showCursorPosition;
        private SettingEntry<bool> _enablePerformanceCounters;
        private SettingEntry<bool> _swapYZAxes;

        public static SettingEntry<KeyBinding> ToggleInfoBinding => Instance._toggleInfoBinding.Value;
        public static SettingEntry<KeyBinding> ShowCursorPosition => Instance._showCursorPosition.Value;
        public static SettingEntry<bool> EnablePerformanceCounters => Instance._enablePerformanceCounters.Value;
        public static SettingEntry<bool> SwapYZAxes => Instance._swapYZAxes;
        public static string Vector3FormatString => "xpos=\"{0}\" ypos=\"{1}\" zpos=\"{2}\"";
        public static string Coordinates2FormatString => "xpos=\"{0}\" ypos=\"{1}\"";
        public static CultureInfo GetCulture() => CultureInfo.InvariantCulture;

        public ModuleSettings(SettingsCollections settingsCollections)
        {
            Instance = this;

            _toggleInfoBinding = settings.DefineSetting("ToggleInfoBinding", new KeyBinding(Keys.OemPlus),
                () => "Toggle display", 
                () => "Toggles the display of data.");

            _showCursorPosition = settings.DefineSetting("ShowCursorPosition", false,
                () => "Show cursor position",
                () => "Whether the cursor's current interface-relative position should be displayed.\nUse [Left Alt] to copy it.");

            _enablePerformanceCounters = settings.DefineSetting("PerfCountersEnabled", false,
                () => "Show performance counters",
                () => "Whether performance counters such as RAM and CPU utilization of the Guild Wars 2 process should be displayed.");

            _swapYZAxes = settings.DefineSetting("SwapYZAxes", true, 
                () => "Swap YZ Axes",
                () => "Swaps the values of the Y and Z axes if enabled.");
        }
    }
}