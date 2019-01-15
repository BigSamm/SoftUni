using System;
using System.Collections.Generic;
using System.Text;

public class DateModifier
{
    private DateTime firstDate;
    private DateTime secondDate;

    public DateTime SecondDate
    {
        get { return this.secondDate; }
        set { this.secondDate = value; }
    }

    public DateTime FirstDate
    {
        get { return this.firstDate; }
        set { this.firstDate = value; }
    }

    public DateModifier(string firstInput, string secondInput)
    {
        this.firstDate = DateTime.Parse(firstInput);
        this.secondDate = DateTime.Parse(secondInput);
    }

    public double CalculateDaysDifference()
    {
        var daysDifference = Math.Abs((this.firstDate - this.secondDate).TotalDays);

        return daysDifference;
    }
}
