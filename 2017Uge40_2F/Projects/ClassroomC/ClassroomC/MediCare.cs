using System;
using System.Collections.Generic;

namespace ClassroomC
{
    public class MediCare
    {
        public double SubsidisedExpense(double expense)
        {
            //if (expense < 0)
            //{
            //    throw new ArgumentException("Beløb må ikke være negativt");
            //}

            //double bracket_0_950_expense = expense > 950 ? (950 - 0) : (expense < 0 ? 0 : expense - 0);
            //double bracket_950_1565_expense = expense > 1565 ? (1565 - 950) : (expense < 950 ? 0 : expense - 950);
            //double bracket_1565_3390_expense = expense > 3390 ? (3390 - 1565) : (expense < 1565 ? 0 : expense - 1565);
            //double bracket_3390_18331_expense = expense > 18331 ? (18331 - 3390) : (expense < 3390 ? 0 : expense - 3390);
            //double bracket_18331_inf_expense = expense > 18331 ? (expense - 18331) : 0;

            //double subsidisedExpense =
            //    bracket_0_950_expense * 1.00 +
            //    bracket_950_1565_expense * 0.50 +
            //    bracket_1565_3390_expense * 0.25 +
            //    bracket_3390_18331_expense * 0.15 +
            //    bracket_18331_inf_expense * 0;

            return BetterSubsidisedExpense(expense);
        }

        public double BetterSubsidisedExpense(double expense)
        {
            if (expense < 0)
            {
                throw new ArgumentException("Beløb må ikke være negativt");
            }

            List<Tuple<int, int>> _expenseTable = new List<Tuple<int, int>>();
            _expenseTable.Add(new Tuple<int, int>(0, 0));
            _expenseTable.Add(new Tuple<int, int>(950, 50));
            _expenseTable.Add(new Tuple<int, int>(1565, 75));
            _expenseTable.Add(new Tuple<int, int>(3390, 85));
            _expenseTable.Add(new Tuple<int, int>(18331, 100));

            double subsidisedExpense = 0;
            for (int i = 0; i < _expenseTable.Count - 1; i++)
            {
                double lower = _expenseTable[i].Item1;
                double upper = _expenseTable[i + 1].Item1;
                double percentage = (100.0 - _expenseTable[i].Item2) / 100.0;
                subsidisedExpense += (expense > upper ? (upper - lower) : (expense < lower ? 0 : expense - lower)) * percentage;
            }

            return subsidisedExpense;
        }
    }
}