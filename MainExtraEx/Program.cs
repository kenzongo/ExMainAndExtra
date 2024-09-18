// Main Excercise
#region Ex1: Tính số ngày trong tuần và số ngày lẻ
// Console.WriteLine("Enter number of days:");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num <= 0)
// {
//     Console.WriteLine("Invalid day!!!");
//     return;
// }
// int weeks = num / 7;
// int remainingdays = num % 7;
// Console.WriteLine($"{num} {(num <= 1 ? "day" : "days")} equals {weeks} {(weeks <= 1 ? "week" : "weeks")} and {remainingdays} {(remainingdays <= 1 ? "day" : "days")} ");
#endregion

#region Ex2: Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá
// using System.Globalization;

// Console.Write("Enter order value: ");
// decimal orderValue = Convert.ToDecimal(Console.ReadLine());
// if(orderValue < 0) {
//     Console.WriteLine("Invalid order value... !!!");
//     return;
// }
// if(orderValue == 0) Console.WriteLine("Order free...");
// else {
//     Console.Write("Enter discount percentage(%): ");
//     decimal discountPercentage = Convert.ToDecimal(Console.ReadLine());
//     discountPercentage = Math.Clamp(discountPercentage, 0, 100); // Limit 0-100, if < 0 set = 0, > 100 set = 100
//     decimal discountAmount = orderValue * discountPercentage / 100;
//     decimal amountAfterDiscount = orderValue - discountAmount;
//     CultureInfo vnCurrency = new CultureInfo("vi-VN");
//     Console.WriteLine($"Discount Amount: {discountAmount.ToString("C", vnCurrency)}\nAmount after discount: {amountAfterDiscount.ToString("C", vnCurrency)}");
// }
#endregion