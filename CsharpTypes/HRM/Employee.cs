class Employee
{
    int montlyWage = 1234;
    int months = 12, bonus = 1000;
    bool isActive = true;
    double rating = 99.25;
    public double ratePerHour = 12.34;
    int numberOfHoursWorked = 165;

    public Employee()
    {
        double currentMonthWage = ratePerHour * numberOfHoursWorked;

    }
}