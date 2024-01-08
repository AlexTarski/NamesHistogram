using System;

namespace Names;

internal static class HistogramTask
{
    public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
    {
        var days = new string[] 
        {
            "1","2","3","4","5","6","7","8","9","10","11",
            "12","13","14","15","16","17","18","19","20","21",
            "22","23","24","25","26","27","28","29","30","31"
        };

        var birthsCounts = new double[31];

        foreach (var namee in names)
        {
            if (namee.Name == name && namee.BirthDate.Day != 1)
            {
                birthsCounts[namee.BirthDate.Day - 1]++;
            }
        }

        return new HistogramData("Рождаемость по дням", days, birthsCounts);
    }
}