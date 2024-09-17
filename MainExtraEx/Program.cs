// Main Excercise
#region Tính số ngày trong tuần và số ngày lẻ
Console.WriteLine("Enter number of days:");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 0)
{
    Console.WriteLine("Invalid day!!!");
    return;
}
int weeks = num / 7;
int remainingdays = num % 7;
Console.WriteLine($"{num} {(num <= 1 ? "day" : "days")} equals {weeks} {(weeks <= 1 ? "week" : "weeks")} and {remainingdays} {(remainingdays <= 1 ? "day" : "days")} ");
#endregion