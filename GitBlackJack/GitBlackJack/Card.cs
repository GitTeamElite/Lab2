using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBlackJack
{
    class Card
    {
        public int _Value { get; set; }
        public string _Type { get; set; }

       public Card(int value,string type)
        {
            this._Type = type;
            this._Value = value;
        }
        public Card()
        { }
    }
}
