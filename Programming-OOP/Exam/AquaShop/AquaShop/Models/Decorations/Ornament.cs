using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Decorations
{
    public class Ornament : Decoration
    {
        private const int INITIAL_COMF = 1;
        private const decimal INITIAL_PRICE = 5;
        public Ornament() 
            : base(INITIAL_COMF, INITIAL_PRICE)
        {
        }
    }
}
