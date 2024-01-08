using System.Xml.Linq;

namespace Names;

internal static class HeatmapTask
{
    public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
    {
        double[,] heatMap = new double[30, 12];
        var days = new string[]
        {
            "2","3","4","5","6","7","8","9","10","11",
            "12","13","14","15","16","17","18","19","20","21",
            "22","23","24","25","26","27","28","29","30","31"
        };

        var months = new string[]
        {
            "1","2","3","4","5","6","7","8","9","10","11", "12"
        };

        foreach (var name in names)
        {
            if (name.BirthDate.Day != 1)
            {
                heatMap[name.BirthDate.Day - 2, name.BirthDate.Month- 1]++;
            }
        }
        return new HeatmapData(
            "Карта интенсивностей",
            heatMap, 
            days, 
            months);
    }
}