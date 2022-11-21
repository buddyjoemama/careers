using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Formula
{
    public Formula() { }

    public Formula(int hearts, int stars, int money)
    {
        Hearts = hearts;
        Stars = stars;
        Money = money;
    }

    public int? Hearts { get; set; }
    public int? Stars { get; set; }
    public int? Money { get; set; }

    public bool IsValid() => Hearts != null && Stars != null && Money != null;  
}