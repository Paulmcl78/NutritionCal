﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCal.Common.Abstraction
{
    public interface IAllMeals
    {
        IList<IMeal> meals { get; set; }

        void AddMeal(IMeal meal);

        void SaveChanged();
    }
}
