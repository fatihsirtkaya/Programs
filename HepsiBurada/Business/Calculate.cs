using HepsiBurada.Enums;
using HepsiBurada.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HepsiBurada
{
    public class Calculate : ICalculate
    {
        //calculate Order Final Position
        public string CalculateFinalPosition(string position, string order)
        {
            var rovers = getPosition(position.Split(' '));
            var Orders = getOrders(order);

            foreach (var item in Orders)
            {
                if (rovers.direction == DirectionEnum.N)
                {
                    if (item == OrderEnum.M.ToString())
                        rovers.yCoordinate += 1;
                    else if (item == OrderEnum.L.ToString())
                        rovers.direction = DirectionEnum.W;
                    else if (item == OrderEnum.R.ToString())
                        rovers.direction = DirectionEnum.E;
                }
                else if (rovers.direction == DirectionEnum.E)
                {
                    if (item == OrderEnum.M.ToString())
                        rovers.xCoordinate += 1;
                    else if (item == OrderEnum.L.ToString())
                        rovers.direction = DirectionEnum.N;
                    else if (item == OrderEnum.R.ToString())
                        rovers.direction = DirectionEnum.S;
                }
                else if (rovers.direction == DirectionEnum.S)
                {
                    if (item == OrderEnum.M.ToString())
                        rovers.yCoordinate -= 1;
                    else if (item == OrderEnum.L.ToString())
                        rovers.direction = DirectionEnum.E;
                    else if (item == OrderEnum.R.ToString())
                        rovers.direction = DirectionEnum.W;
                }
                else if (rovers.direction == DirectionEnum.W)
                {
                    if (item == OrderEnum.M.ToString())
                        rovers.xCoordinate -= 1;
                    else if (item == OrderEnum.L.ToString())
                        rovers.direction = DirectionEnum.S;
                    else if (item == OrderEnum.R.ToString())
                        rovers.direction = DirectionEnum.N;
                }
            }

            return rovers.xCoordinate + " " + rovers.yCoordinate + " " + rovers.direction.ToString(); ;
        }
        //Initialize Rovers Position
        private Rover getPosition(string[] position)
        {
            return new Rover
            {
                xCoordinate = Convert.ToInt32(position[0]),
                yCoordinate = Convert.ToInt32(position[1]),
                direction = (DirectionEnum)Enum.Parse(typeof(DirectionEnum), position[2])
        };

    }

        //Get Orders Array
        private string[] getOrders(string order)
        {
            return order.ToCharArray().Select(c => c.ToString()).ToArray();

        }

        
}
}
