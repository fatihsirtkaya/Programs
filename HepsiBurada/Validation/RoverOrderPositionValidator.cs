using System.Text.RegularExpressions;

namespace HepsiBurada.Validation
{
    public static class RoverOrderPositionValidator
    {
        public static bool OrderValidate(this string value)
        {
            if (value == null || value == "")
                return false;

            Match match = Regex.Match(value, @"[MLR]");
            if (!match.Success)
                return false;
            return true;
        }
    }
}
