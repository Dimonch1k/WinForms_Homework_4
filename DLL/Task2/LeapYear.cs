namespace Task2
{
    public class LeapYear
    {
        public string IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return $"The {year} year is leap!";
            }
            return $"The {year} year isn't leap!";
        }
    }
}
