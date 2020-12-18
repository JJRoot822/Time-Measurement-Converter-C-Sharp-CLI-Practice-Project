using System;

namespace Time_Measurement_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            int conversionType = GetConversionType();
            double valueToConvertFrom = GetMeasurementValueToConvertFrom();
            
            ConvertMeasurement(conversionType, valueToConvertFrom);
        }

        public static int GetConversionType()
        {
            bool isNotValidValue = false;
            
            Console.WriteLine("1\tMiliseconds to Seconds\n2\tMiliseconds to Minutes\n3\tMiliseconds to Hours\n4\tMiliseconds to Days\n5\tMiliseconds to Weeks\n6\tMiliseconds to Months\n7\tMiliseconds to Years\n8\tSeconds to miliseconds\n9\tSeconds to Minutes\n10\tSeconds to Hours\n11\tSeconds to Days\n12\tSeconds to Weeks\n13\tSeconds to Months\n14\tSeconds to Years\n15\tMinutes to Miliseconds\n16\tMinutes to Seconds\n17\tMinutes to Hours\n18\tMinutes to Days\n19\tMinutes to Weeks\n20\tMiinutes to Months\n21\tMinutes to Years\n22\tHours to Milieconds\n23\tHours to Seconds\n24\tHours to Minutes\n25\tHours to Days\n26\tHours to Weeks\n27\tHours to Months\n28\tHours to Years\n29\tDays to Miliseconds\n30\tDays to Seconds\n31\tDays to Minutes\n32\tDays to Hours\n33\tDays to Weeks\n34\tDays to Months\n35\tDays to Years\n36\tWeeks to Miliseconds\n37\tWeeks to Seconds\n38\tWeeks to Minutes\n39\tWeeks to Hours\n40\tWeeks to Days\n41\tWeeks to Months\n42\tWeeks to Years\n43\tMonths to Miliseconds\n44\tMonths to Seconds\n45\tMonths to Minutes\n46\tMonths to Hours\n47\tMonths to Days\n48\tMonths to Weeks\n49\tMonths to Years\n50\tYears to Miliseconds\n51\tYears to Seconds\n52\tYears to Minutes\n53\tYears to Hours\n54\tYears to Days\n55\tYears to Weeks\n56\tYears to Months\n");

            do
            {
                isNotValidValue = false;

                Console.Write("Choice:\t");

                try
                {
                    int enteredValue = int.Parse(Console.ReadLine());

                    if (enteredValue < 1 || enteredValue > 56)
                    {
                        Console.WriteLine("You entered an incompatible value. Resorting to the default value of 1");

                        enteredValue = 1;
                        isNotValidValue = false;

                        return enteredValue;
                    }
                    else
                    {
                        return enteredValue;
                    }
                }
                catch (FormatException exception)
                {
                    isNotValidValue = true;
                }
            }
            while (isNotValidValue);

            return 0;
        }

        public static double GetMeasurementValueToConvertFrom()
        {
            bool isNotValidValue = false;
            
            do
            {
                isNotValidValue = false;

                Console.Write("Please enter the value you want to convert from:\t");
                
                try
                {
                    double value = Double.Parse(Console.ReadLine());

                    return value;
                }
                catch (FormatException exception)
                {
                    isNotValidValue = true;
                }
            }
            while (isNotValidValue);

            return 0;
        }

        public static void ConvertMeasurement(int conversionType, double convertFrom)
        {
            switch (conversionType)
            {
                case 1:
                    Console.WriteLine("{0} miliseconds is {1} seconds", convertFrom, ConversionUtil.ConvertMilisecondsToSeconds(convertFrom));
                    break;
                case 2:
                    Console.WriteLine("{0} miliseconds is {1} minutes", convertFrom, ConversionUtil.ConvertMilisecondsToMinutes(convertFrom));
                    break;
                case 3:
                    Console.WriteLine("{0} miliseconds is {1} hours", convertFrom, ConversionUtil.ConvertMilisecondsToHours(convertFrom));
                    break;
                case 4:
                    Console.WriteLine("{0} miliseconds is {1} days", convertFrom, ConversionUtil.ConvertMilisecondsToDays(convertFrom));
                    break;
                case 5:
                    Console.WriteLine("{0} miliseconds is {1} weeks", convertFrom, ConversionUtil.ConvertMilisecondsToWeeks(convertFrom));
                    break;
                case 6:
                    Console.WriteLine("{0} miliseconds is {1} months", convertFrom, ConversionUtil.ConvertMilisecondsToMonths(convertFrom));
                    break;
                case 7:
                    Console.WriteLine("{0} miliseconds is {1} years", convertFrom, ConversionUtil.ConvertMilisecondsToYears(convertFrom));
                    break;
                case 8:
                    Console.WriteLine("{0} seconds is {1} miliseconds", convertFrom, ConversionUtil.ConvertSecondsToMiliseconds(convertFrom));
                    break;
                case 9:
                    Console.WriteLine("{0} seconds is {1} minutes", convertFrom, ConversionUtil.ConvertSecondsToMinutes(convertFrom));
                    break;
                case 10:
                    Console.WriteLine("{0} seconds is {1} hours", convertFrom, ConversionUtil.ConvertSecondsToHours(convertFrom));
                    break;
                case 11:
                    Console.WriteLine("{0} seconds is {1} days", convertFrom, ConversionUtil.ConvertSecondsToDays(convertFrom));
                    break;
                case 12:
                    Console.WriteLine("{0} seconds is {1} weeks", convertFrom, ConversionUtil.ConvertSecondsToWeeks(convertFrom));
                    break;
                case 13:
                    Console.WriteLine("{0} seconds is {1} months", convertFrom, ConversionUtil.ConvertSecondsToMonths(convertFrom));
                    break;
                case 14:
                    Console.WriteLine("{0} seconds is {1} years", convertFrom, ConversionUtil.ConvertSecondsToYears(convertFrom));
                    break;
                case 15:
                    Console.WriteLine("{0} minutes is {1} miliseconds", convertFrom, ConversionUtil.ConvertMinutesToMiliseconds(convertFrom));
                    break;
                case 16:
                    Console.WriteLine("{0} minutes is {1} seconds", convertFrom, ConversionUtil.ConvertMinutesToSeconds(convertFrom));
                    break;
                case 17:
                    Console.WriteLine("{0} minutes is {1} hours", convertFrom, ConversionUtil.ConvertMinutesToHours(convertFrom));
                    break;
                case 18:
                    Console.WriteLine("{0} minutes is {1} days", convertFrom, ConversionUtil.ConvertMinutesToDays(convertFrom));
                    break;
                case 19:
                    Console.WriteLine("{0} minutes is {1} weeks", convertFrom, ConversionUtil.ConvertMinutesToWeeks(convertFrom));
                    break;
                case 20:
                    Console.WriteLine("{0} minutes is {1} months", convertFrom, ConversionUtil.ConvertMinutesToMonths(convertFrom));
                    break;
                case 21:
                    Console.WriteLine("{0} minutes is {1} years", convertFrom, ConversionUtil.ConvertMinutesToYears(convertFrom));
                    break;
                case 22:
                    Console.WriteLine("{0} hours is {1} miliseconds", convertFrom, ConversionUtil.ConvertHoursToMiliseconds(convertFrom));
                    break;
                case 23:
                    Console.WriteLine("{0} hours is {1} seconds", convertFrom, ConversionUtil.ConvertHoursToSeconds(convertFrom));
                    break;
                case 24:
                    Console.WriteLine("{0} hours is {1} minutes", convertFrom, ConversionUtil.ConvertHoursToMinutes(convertFrom));
                    break;
                case 25:
                    Console.WriteLine("{0} hours is {1} days", convertFrom, ConversionUtil.ConvertHoursToDays(convertFrom));
                    break;
                case 26:
                    Console.WriteLine("{0} hours is {1} weeks", convertFrom, ConversionUtil.ConvertHoursToWeeks(convertFrom));
                    break;
                case 27:
                    Console.WriteLine("{0} hours is {1} months", convertFrom, ConversionUtil.ConvertHoursToMonths(convertFrom));
                    break;
                case 28:
                    Console.WriteLine("{0} hours is {1} years", convertFrom, ConversionUtil.ConvertHoursToYears(convertFrom));
                    break;
                case 29:
                    Console.WriteLine("{0} days is {1} miliseconds", convertFrom, ConversionUtil.ConvertDaysToMiliseconds(convertFrom));
                    break;
                case 30:
                    Console.WriteLine("{0} days is {1} seconds", convertFrom, ConversionUtil.ConvertDaysToSeconds(convertFrom));
                    break;
                case 31:
                    Console.WriteLine("{0} days is {1} minutes", convertFrom, ConversionUtil.ConvertDaysToMinutes(convertFrom));
                    break;
                case 32:
                    Console.WriteLine("{0} days is {1} hours", convertFrom, ConversionUtil.ConvertDaysToHours(convertFrom));
                    break;
                case 33:
                    Console.WriteLine("{0} days is {1} weeks", convertFrom, ConversionUtil.ConvertDaysToWeeks(convertFrom));
                    break;
                case 34:
                    Console.WriteLine("{0} days is {1} months", convertFrom, ConversionUtil.ConvertDaysToMonths(convertFrom));
                    break;
                case 35:
                    Console.WriteLine("{0} days is {1} years", convertFrom, ConversionUtil.ConvertDaysToYears(convertFrom));
                    break;
                case 36:
                    Console.WriteLine("{0} weeks is {1} miliseconds", convertFrom, ConversionUtil.ConvertWeeksToMiliseconds(convertFrom));
                    break;
                case 37:
                    Console.WriteLine("{0} weeks is {1} seconds", convertFrom, ConversionUtil.ConvertWeeksToSeconds(convertFrom));
                    break;
                case 38:
                    Console.WriteLine("{0} weeks is {1} minutes", convertFrom, ConversionUtil.ConvertWeeksToMinutes(convertFrom));
                    break;
                case 39:
                    Console.WriteLine("{0} weeks is {1} hours", convertFrom, ConversionUtil.ConvertWeeksToHours(convertFrom));
                    break;
                case 40:
                    Console.WriteLine("{0} weeks is {1} days", convertFrom, ConversionUtil.ConvertWeeksToDays(convertFrom));
                    break;
                case 41:
                    Console.WriteLine("{0} weeks is {1} months", convertFrom, ConversionUtil.ConvertWeeksToMonths(convertFrom));
                    break;
                case 42:
                    Console.WriteLine("{0} weeks is {1} years", convertFrom, ConversionUtil.ConvertWeeksToYears(convertFrom));
                    break;
                case 43:
                    Console.WriteLine("{0} months is {1} miliseconds", convertFrom, ConversionUtil.ConvertMonthsToMiliseconds(convertFrom));
                    break;
                case 44:
                    Console.WriteLine("{0} months is {1} seconds", convertFrom, ConversionUtil.ConvertMonthsToSeconds(convertFrom));
                    break;
                case 45:
                    Console.WriteLine("{0} months is {1} minutes", convertFrom, ConversionUtil.ConvertMonthsToMinutes(convertFrom));
                    break;
                case 46:
                    Console.WriteLine("{0} months is {1} hours", convertFrom, ConversionUtil.ConvertMonthsToHours(convertFrom));
                    break;
                case 47:
                    Console.WriteLine("{0} months is {1} days", convertFrom, ConversionUtil.ConvertMonthsToDays(convertFrom));
                    break;
                case 48:
                    Console.WriteLine("{0} months is {1} weeks", convertFrom, ConversionUtil.ConvertMonthsToWeeks(convertFrom));
                    break;
                case 49:
                    Console.WriteLine("{0} months is {1} years", convertFrom, ConversionUtil.ConvertMonthsToYears(convertFrom));
                    break;
                case 50:
                    Console.WriteLine("{0} years is {1} miliseconds", convertFrom, ConversionUtil.ConvertYearsToMiliseconds(convertFrom));
                    break;
                case 51:
                    Console.WriteLine("{0} years is {1} seconds", convertFrom, ConversionUtil.ConvertYearsToSeconds(convertFrom));
                    break;
                case 52:
                    Console.WriteLine("{0} years is {1} minutes", convertFrom, ConversionUtil.ConvertYearsToMinutes(convertFrom));
                    break;
                case 53:
                    Console.WriteLine("{0} years is {1} hours", convertFrom, ConversionUtil.ConvertYearsToHours(convertFrom));
                    break;
                case 54:
                    Console.WriteLine("{0} years is {1} days", convertFrom, ConversionUtil.ConvertYearsToDays(convertFrom));
                    break;
                case 55:
                    Console.WriteLine("{0} years is {1} weeks", convertFrom, ConversionUtil.ConvertYearsToWeeks(convertFrom));
                    break;
                case 56:
                    Console.WriteLine("{0} years is {1} months", convertFrom, ConversionUtil.ConvertYearsToMonths(convertFrom));
                    break;
            }
        }
    }
}
