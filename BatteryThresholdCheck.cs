using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagementSystem
{
    public class BatteryThresholdCheck
    {
        public static void checkValueLimits(string factor, float factorCurrentValue, float maxThreshold, float minThreshold)
        {
            if (factorCurrentValue > maxThreshold)
                Console.WriteLine("{0} : {1} is higher then maxthreshold value {2}. BreachLevel is High", factor, factorCurrentValue, maxThreshold);
            else if (factorCurrentValue < minThreshold)
                Console.WriteLine("{0} : {1} is lesser then minthreshold value {2}. BreachLevel is Low", factor, factorCurrentValue, minThreshold);
            else
                Console.WriteLine("{0} : {1} is within the threshold limits - MaxThreshold: {2}, MinThreshold: {3}. No breach", factor, factorCurrentValue, maxThreshold, minThreshold);
        }

    }
}
