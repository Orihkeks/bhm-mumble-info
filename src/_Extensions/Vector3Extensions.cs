using System.Numerics;

namespace Nekres.Mumble_Info
{
    internal static class Vector3Extensions
    {
        public static float[] ToArray(this Vector3 v)
        {
            return new[] {v.X, v.Y, v.Z};
        }

        public static string ToFormatString(this Vector3 vector)
        {
            var culture = ModuleSettings.GetCulture();
            return string.Format(ModuleSettings.Vector3FormatString, vector.X.ToString(culture),
                ModuleSettings.SwapYZAxes.Value ? vector.Z.ToString(culture): vector.Y.ToString(culture),
                ModuleSettings.SwapYZAxes.Value ? vector.Y.ToString(culture): vector.Z.ToString(culture)
            );
        }

    }
}
