using System;
using System.Collections.Generic;
using System.Text;

namespace DLAPSS.Entity
{
    public class CardsInfo
    {
        private int cardsId;

        public int CardsId
        {
            get { return cardsId; }
            set { cardsId = value; }
        }
        private string cardsName;

        public string CardsName
        {
            get { return cardsName; }
            set { cardsName = value; }
        }
    }
}
