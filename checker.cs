using System;
using System.Diagnostics;

namespace BatteryManagementSystem
{
    public class Checker
    {
        public static float temparatureMaxLimit = 45;
        public static float temparatureMinLimit = 0;
        public static float socMaxLimit = 20;
        public static float socMinLimit = 80;
        public static float chargeRateMaxLimit = 0.8f;
        public static float chargeRateMinLimit = 0.3f;

        public static void isBatteryOk(float temparature, float soc, float chargeRate)
        {
            checkTemparatureRange(temparature);
            checkSOCRange(soc);
            checkChargeRate(chargeRate);
        }

        public static void checkTemparatureRange(float temparature)
        {
            BatteryThresholdCheck.checkValueLimits("Temparature", temparature, temparatureMaxLimit, temparatureMinLimit);
        }

        public static void checkSOCRange(float soc)
        {
            BatteryThresholdCheck.checkValueLimits("SOC", soc, socMaxLimit, socMinLimit);
        }

        public static void checkChargeRate(float ChargeRate)
        {
            BatteryThresholdCheck.checkValueLimits("ChargeRate", ChargeRate, chargeRateMaxLimit, chargeRateMinLimit);
        }

        static int Main()
        {
            isBatteryOk(25, 70, 0.7f);
            isBatteryOk(50, 85, 0.0f);
            isBatteryOk(-50, 65, 0.2f);
            isBatteryOk(40, 50, 0.5f);
            Console.WriteLine("All ok");
            return 0;
        }
    }
}
