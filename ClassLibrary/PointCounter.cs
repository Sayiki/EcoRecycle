using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzaqLibrary;
public class PointCounter
{
    private Dictionary<string, int> pointValues;

    public PointCounter()
    {
        pointValues = new Dictionary<string, int>();
        pointValues.Add("plastic", 5);
        pointValues.Add("glass", 10);
        pointValues.Add("paper", 3);
        // add more materials and point values as needed
    }

    public int CountPoints(string material)
    {
        if (pointValues.ContainsKey(material))
        {
            return pointValues[material];
        }
        else
        {
            // material not recognized
            return 0;
        }
    }

    public int CountTotalPoints(List<string> materials)
    {
        int totalPoints = 0;
        foreach (string material in materials)
        {
            totalPoints += CountPoints(material);
        }
        return totalPoints;
    }
}

