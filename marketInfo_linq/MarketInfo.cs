using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matvelickov_marketInfo_linq
{
    internal class MarketInfo
    {
        public MarketInfo(string place,
            string seller, string product, string quantity, string unit, string pricPerUnit)
        {
            Place = place;
            Seller = seller;
            Product = product;
            Quantity = Convert.ToInt32(quantity);
            Unit = UnitConverter.fromString(unit);
            PricPerUnit = Convert.ToSingle(pricPerUnit);
        }

        public string Place { get; private set; }
        public string Seller { get; private set; }
        public string Product { get; private set; }
        public int Quantity { get; private set; }

        public Unit Unit { get; private set; }

        public float PricPerUnit { get; private set; }
    }


    enum Unit
    {
        kg, unit, bag
    }

    static class UnitConverter
    {
        public static Unit fromString(string unit)
        {
            switch (unit)
            {
                case "kg": return Unit.kg;
                case "pièce": return Unit.unit;
                case "sac": return Unit.bag;

                default: return Unit.kg;
            }
        }
    }
}
