using System;
using System.Collections.Generic;
using System.Text;

namespace LV5_Dizajn_OOP.Kompozit
{
    class ShippingService
    {
        private double ShippingPricepkg = 2.99;

        public double getShippingPricepkg { get { return ShippingPricepkg; } }

        public double ShippingPrice(IShipable package)
        {
            double shippingPrice = 0;
            shippingPrice = package.Weight * ShippingPricepkg;
            return shippingPrice;
        }
    }
}
