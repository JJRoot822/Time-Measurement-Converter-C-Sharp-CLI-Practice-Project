using System;
using System.Collections.Generic;
using System.Text;

namespace Time_Measurement_Converter
{
    class ConversionUtil
    {
        public static double ConvertMilisecondsToSeconds(double miliseconds) { return miliseconds / 1_000; }
        public static double ConvertMilisecondsToMinutes(double miliseconds) { return miliseconds / 60_000; }
        public static double ConvertMilisecondsToHours(double miliseconds) { return miliseconds / 3_600_000; }
        public static double ConvertMilisecondsToDays(double miliseconds) { return miliseconds / 86_400_000; }
        public static double ConvertMilisecondsToWeeks(double miliseconds) { return miliseconds / 604_800_000; }
        public static double ConvertMilisecondsToMonths(double miliseconds) { return miliseconds / 2_629_746_000; }
        public static double ConvertMilisecondsToYears(double miliseconds) { return miliseconds / 31_556_952_000; }


        public static double ConvertSecondsToMiliseconds(double seconds) { return seconds * 1_000; }
        public static double ConvertSecondsToMinutes(double seconds) { return seconds / 60); }
        public static double ConvertSecondstoHours(double seconds) { return seconds / 3_600; }
        public static double ConvertSecondsToDays(double seconds) { return seconds / 86_400); }
        public static double ConvertSecondsToWeeks(double seconds) { return seconds / 604_800; }
        public static double ConvertSecondsToMonths(double seconds) { return seconds / 2_629_746; }
        public static double ConvertSecondsToYears(double seconds) { return seconds / 31_556_952; }
        
        
        public static double ConvertMinutesToMiliseconds(double minutes) { return minutes * 60_000; }
        public static double ConvertMinutesToSeconds(double minutes) { return minutes * 60; }
        public static double ConvertMinutesToHours(double minutes) { return minutes / 60; }
        public static double ConvertMinutesToDays(double minutes) { return minutes / 1_440; }
        public static double ConvertMinutesToWeeks(double minutes) { return minutes / 10_080; }
        public static double ConvertMinutesToMonths(double minutes) { return minutes / 43_829.1; }
        public static double ConvertMinutesToYears(double minutes) { return minutes / 525_949.2; }


        public static double ConvertHoursToMiliseconds(double hours) { return hours * 3_600_000; }
        public static double ConvertHoursToSeconds(double hours) { return hours * 3_600; }
        public static double ConvertHoursToMinutes(double hours) { return hours * 60; }
        public static double ConvertHoursToDays(double hours) { return hours / 24; }
        public static double ConvertHoursToWeeks(double hours) { return hours / 168; }
        public static double ConvertHoursToMonths(double hours) { return hours / 730.49; }
        public static double ConvertHoursToYears(double hours) { return hours / 8_765.82; }


        public static double ConvertDaysToMiliseconds(double days) { return days * 86_400_000; }
        public static double ConvertDaysToSeconds(double days) { return days * 86_400; }
        public static double ConvertDaysToMinutes(double days) { return days * 1_440; }
        public static double ConvertDaysToHours(double days) { return days * 24; }
        public static double ConvertDaysToWeeks(double days) { return days / 7; }
        public static double ConvertDaysToMonths(double days) { return days / 31; }
        public static double ConvertDaysToYears(double days) { return days / 365; }


        public static double ConvertWeeksToMiliseconds(double weeks) { return weeks * 604_800_000; }
        public static double ConvertWeeksToSeconds(double weeks) { return weeks * 604_800; }
        public static double ConvertWeeksToMinutes(double weeks) { return weeks * 10_080; }
        public static double ConvertWeeksToHours(double weeks) { return weeks * 168; }
        public static double ConvertWeeksToDays(double weeks) { return weeks * 7; }
        public static double ConvertWeeksToMonths(double weeks) { return weeks / 4.35; }
        public static double ConvertWeeksToYears(double weeks) { return weeks / 52.18; }
        

        public static double ConvertMonthsToMiliseconds(double months) { return months * 2_629_746_000 }
        public static double ConvertMonthsToSeconds(double months) { return months * 2_629_745; }
        public static double ConvertMonthsToMinutes(double months) { return months * 43_829.1; }
        public static double ConvertMonthsToHours(double months) { return months * 730.49; }
        public static double ConvertMonthsToDays(double months) { return months * 31; }
        public static double ConvertMonthsToWeeks(double months) { return months * 52.18; }
        public static double ConvertMonthsToYears(double months) { return months / 365; }


        public static double ConvertYearsToMiliseconds(double years) { return years * 31_556_952_000; }
        public static double ConvertYearsToSeconds(double years) { return years * 31_556_952 }
        public static double ConvertYearsToMinutes(double years) { return years * 525_949.2; }
        public static double ConvertYearsToHours(double years) { return years * 8_765.82 }
        public static double ConvertYearsToDays(double years) { return years * 365; }
        public static double ConvertYearsToWeeks(double years) { return years * 52.18; }
        public static double ConvertYearsToMonths(double years) { return years * 12; }
    }
}
