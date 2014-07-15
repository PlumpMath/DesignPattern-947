﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy.Factory_Strategy
{
    class CashRebate:CashSuper
    {
        private double moneyRebate=1d;

        public CashRebate(double moneyRebate)
        {
            this.moneyRebate=moneyRebate;
        }

        public override double acceptCash(double money)
        {
 	        return money*this.moneyRebate;
        }
    }
}
