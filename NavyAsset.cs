using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmithBattleShips
{
    //heavily stolen from
    //https://github.com/ngcheehou/BattleShipConsole/tree/master
    public class NavyAsset
    {
        private const int CARRIER = 5;
        private const int BATTLESHIP = 4;
        private const int DESTROYER = 3;
        private const int SUBMARINE = 3;
        private const int PATROLBOAT = 2;
        private Random random = new Random();

        public NavyAsset()
        {
            Carrier = GeneratePosistion(CARRIER, AllShipsPosition);
            Battleship = GeneratePosistion(BATTLESHIP, AllShipsPosition);
            Destroyer = GeneratePosistion(DESTROYER, AllShipsPosition);
            Submarine = GeneratePosistion(SUBMARINE, AllShipsPosition);
            PatrolBoat = GeneratePosistion(PATROLBOAT, AllShipsPosition);
        }

        public List<Position> Carrier { get; set; }//5
        public List<Position> Battleship { get; set; }//4
        public List<Position> Destroyer { get; set; }//3
        public List<Position> Submarine { get; set; }//3
        public List<Position> PatrolBoat { get; set; }//2

        public List<Position> AllShipsPosition { get; set; } = new List<Position>();

        public bool IsCarrierSunk { get; set; } = false;
        public bool IsBattleshipSunk { get; set; } = false;
        public bool IsDestroyerSunk { get; set; } = false;
        public bool IsSubmarineSunk { get; set; } = false;
        public bool IsPatrolBoatSunk { get; set; } = false;
        public bool IsObliteratedAll { get; set; } = false;

        public List<Position> GeneratePosistion(int size, List<Position> AllPosition)
        {
            List<Position> positions = new List<Position>();

            bool IsExist = false;

            do
            {
                positions = GeneratePositionRandomly(size);
                //checks to see if any positions are already taken (overlaps) and returns true if they are
                //works by looking for duplicates in the list - if there are any, then it returns true
                //if false, loop will end
                IsExist = positions.Where(AP => AllPosition.Exists(ShipPos => ShipPos.x == AP.x && ShipPos.y == AP.y)).Any();
            }
            while (IsExist);//if the IsExist = true, then redo it.

            AllPosition.AddRange(positions);

            return positions;
        }

        public List<Position> GeneratePositionRandomly(int sizeOfVessel)
        {
            List<Position> positions = new List<Position>();

            int direction = random.Next(1, sizeOfVessel);//odd for horizontal and even for vertical
                                                         //pick row and column
            int rowNumber = random.Next(1, 11);
            int colNumber = random.Next(1, 11);

            if (direction % 2 != 0)
            {
                //left first, then right
                if (rowNumber - sizeOfVessel > 0)
                {
                    for (int i = 0; i < sizeOfVessel; i++)
                    {
                        Position temporaryPositionVariable = new Position();
                        temporaryPositionVariable.x = rowNumber - i;
                        temporaryPositionVariable.y = colNumber;
                        positions.Add(temporaryPositionVariable);
                    }
                }
                else // row
                {
                    for (int i = 0; i < sizeOfVessel; i++)
                    {
                        Position pos = new Position();
                        pos.x = rowNumber + i;
                        pos.y = colNumber;
                        positions.Add(pos);
                    }
                }
            }
            else
            {
                //top first, then bottom
                if (colNumber - sizeOfVessel > 0)
                {
                    for (int i = 0; i < sizeOfVessel; i++)
                    {
                        Position pos = new Position();
                        pos.x = rowNumber;
                        pos.y = colNumber - i;
                        positions.Add(pos);
                    }
                }
                else // row
                {
                    for (int i = 0; i < sizeOfVessel; i++)
                    {
                        Position pos = new Position();
                        pos.x = rowNumber;
                        pos.y = colNumber + i;
                        positions.Add(pos);
                    }
                }
            }
            return positions;
        }
    }
}