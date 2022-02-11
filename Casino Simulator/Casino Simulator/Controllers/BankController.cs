using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino_Simulator.Models;

namespace Casino_Simulator.Controllers
{
    class BankController
    {
        public static int Cash = 10000;
        public static int Chips = 0;
        // Turn Cash into Chips via int
        public static void CashToChips(int cash)
        {
            Chips += cash;
            Cash -= cash;
        }
        // Turn Chips into Cash via int
        public static void ChipsToCash(int chips)
        {
            Cash += chips;
            Chips -= chips;
        }
        // Takes a bet amount and turns it into a chip color list
        // *If bet is higher than total available chips, will give as many chips as possible*
        public static List<Balls.ChipColor> BetToChips(int bet)
        {
            List<Balls.ChipColor> returnedChips = new();
            for(int i = Balls.ChipValue.Count - 1; i >= 0; i--)
            {
                int currentValue = Balls.ChipValue.ElementAt(i).Value;
                while(bet >= currentValue && Chips >= currentValue)
                {
                    returnedChips.Add(Balls.ChipValue.ElementAt(i).Key);
                    bet -= currentValue;
                    Chips -= currentValue;
                }
            }
            return returnedChips;
        }
        // Will take a chip color list and return it's cash value
        public static int CountChips(List<Balls.ChipColor> chips)
        {
            int totalValue = 0;
            for(int i = 0; i < chips.Count; i++)
            {
                totalValue += Balls.ChipValue[chips[i]];
            }
            return totalValue;
        }
        // Will return true if chip count is at or below 0
        public static bool OutOfChips()
        {
            return Chips <= 0;
        }
    }
}
