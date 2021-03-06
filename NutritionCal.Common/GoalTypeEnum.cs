﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace NutritionCal.Common
{
    public enum GoalTypeEnum
    {
        [Description("Bulking")]
        GainWeight = 1,

        [Description("Cutting")]
        LoseWeight = 2,

        [Description("Cutting more that 25% BF")]
        LoseWeightObese = 3,

        [Description("Maintaining")]
        MaintainWeight = 4
    }

    public static  class Enumerations
    {
            public static string GetEnumDescription(Enum value)
            {
                FieldInfo fi = value.GetType().GetField(value.ToString());

                DescriptionAttribute[] attributes =
                    (DescriptionAttribute[])fi.GetCustomAttributes(
                    typeof(DescriptionAttribute),
                    false);

                return attributes.Length > 0 ? attributes[0].Description : value.ToString();
            }

            public static T GetEmumFromDescription<T>(string enumDescription)
            {
                IEnumerable<T> enumValues = Enum.GetValues(typeof (T)).Cast<T>();

                foreach (T enumValue in enumValues)
                {
                    if (GetEnumDescription(enumValue as Enum) == enumDescription)
                    {
                        return enumValue;
                    }
                }

                throw new NotSupportedException("No enmu found matching description");

            }
    }
}
