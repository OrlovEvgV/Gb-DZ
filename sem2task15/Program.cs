var daysOfTheWeek = new Dictionary<int, string>()
{
    {1, "Monday"},
    {2, "Tuуsday"},
    {3, "Wednesday"},
    {4, "Thursday"},
    {5, "Friday"},
    {6, "Saturday"},
    {7, "Sunday"}
};
int digit = int.Parse(Console.ReadLine() ?? "0");
if(digit==6 || digit==7)
{
    Console.WriteLine(daysOfTheWeek[digit] + " day off");
}
else
{
    Console.WriteLine(daysOfTheWeek[digit] + " weekday");
}