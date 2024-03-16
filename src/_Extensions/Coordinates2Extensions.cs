using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nekres.Mumble_Info
{
    public static class Coordinates2Extensions
    {
        public static string ToFormatString(this Coordinates2 coordinates)
        {
            var culture = ModuleSettings.GetCulture();
            return string.Format(ModuleSettings.Coordinates2FormatString, coordinates.X.ToString(culture), coordinates.Y.ToString(culture));
        }
    }
}