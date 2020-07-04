using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HepsiBurada.Validation
{
    public static class RoverPositionValidator 
    {
        public static bool PositionValidate(this string value)
        {
            if (value == null || value == "")
                return false;

            var list = value.Split(' ');

            if (list.Length != 3)
                return false;

            if (!int.TryParse(list[0], out int xcoordinates))
                return false;

            if (!int.TryParse(list[1], out int ycoordinate))
                return false;

            Match match = Regex.Match(list[2], @"[NSEW]");
            if (!match.Success)
                return false;
            return true;
        }
    }
}
