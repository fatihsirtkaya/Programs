using HepsiBurada.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada.Models
{
    public class Rover
    {
        public int xCoordinate { get; set; }
        public int yCoordinate { get; set; }
        public DirectionEnum direction { get; set; }
    }
}
