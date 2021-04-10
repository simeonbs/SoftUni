using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Decorations
{
    public class Plant : Decoration
    {
        private const int INITIAL_COMF = 5;
        private const decimal INITIAL_PRICE = 10;
        public Plant()
            : base(INITIAL_COMF, INITIAL_PRICE)
        {
        }
    }
}
