using System;

namespace Time_Measurement_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("78643564 Miliseconds = {0} seconds", ConversionUtil.ConvertMilisecondsToSeconds(78643564));
            Console.WriteLine("78643564 Miliseconds = {0} minutes", ConversionUtil.ConvertMilisecondsToMinutes(78643564));
            Console.WriteLine("78643564 Miliseconds = {0} hours", ConversionUtil.ConvertMilisecondsToHours(78643564));
            Console.WriteLine("78643564 Miliseconds = {0} days", ConversionUtil.ConvertMilisecondsToDays(78643564));
            Console.WriteLine("78643564 Miliseconds = {0} weeks", ConversionUtil.ConvertMilisecondsToWeeks(78643564));
            Console.WriteLine("78643564 Miliseconds = {0} months", ConversionUtil.ConvertMilisecondsToMonths(78643564));
            Console.WriteLine("78643564 Miliseconds = {0} years", ConversionUtil.ConvertMilisecondsToYears(78643564));
        }
    }
}
