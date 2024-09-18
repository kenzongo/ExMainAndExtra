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

#region Ex3: Chuyển đổi thời gian từ phứt sang giờ và phút. Ex: 130p = 2h and 10p 
// Console.Write("Enter the number of minutes: ");
// int totalMinutes = Convert.ToInt32(Console.ReadLine());
// if(totalMinutes < 1) {
//     Console.WriteLine("Invalid minutes...!");
//     return;
// }
// int hours = totalMinutes / 60;
// int minutes = totalMinutes % 60;
// Console.WriteLine($"{totalMinutes} {(totalMinutes <= 1 ? "minute" : "minutes")} = {hours} {(hours <= 1 ? "hour" : "hours")} and {minutes} {(minutes <= 1 ? "minute" : "minutes")}");
#endregion

#region Ex4:  Tính số tiền sau khi đã thêm VAT
// using System.Globalization;

// Console.Write("Enter the original amount: ");
// decimal originalAmount = Convert.ToDecimal(Console.ReadLine());
// if (originalAmount < 0)
// {
//     Console.WriteLine("Invalid amount...!");
//     return;
// }
// if(originalAmount == 0) {
//     Console.WriteLine("It's free....!");
//     return;
// }
// Console.Write("Enter the VATE rate(%): ");
// decimal vate = Convert.ToDecimal(Console.ReadLine());
// if (vate < 0)
// {
//     Console.WriteLine("Invalid VATE rate...!");
//     return;
// }
// decimal totalAmount = originalAmount * (1 + vate/100);
// CultureInfo cul = new CultureInfo("vi-VN");
// Console.WriteLine($"Total amount after adding {vate}% VAT is: {totalAmount.ToString("C", cul)}");
#endregion

#region  Ex5: Chuyển đổi đơn vị tiền tệ
// using System.Globalization;

// Console.Write("Enter the amount in USD: ");
// decimal usdAmount = Convert.ToDecimal(Console.ReadLine());
// if (usdAmount < 1)
// {
//     Console.WriteLine("Please enter amount greater than 0...!");
//     return;
// }
// Console.Write("Enter the exchange rate: ");
// decimal exchangeRate = Convert.ToDecimal(Console.ReadLine());
// if (exchangeRate < 1)
// {
//     Console.WriteLine("Please enter exchange rate greater than 0...!");
//     return;
// }
// decimal vndAmount = usdAmount * exchangeRate;
// CultureInfo vndCur = new CultureInfo("vi-VN");
// Console.WriteLine($"{usdAmount:C} equivalent to {vndAmount.ToString("C", vndCur)}");
#endregion

//Extra
#region Ex6: Tính số dư sau khi rút tiền từ tài khoản
// using System.Globalization;

// Console.Write("Current account balance: ");
// decimal curBalance = Convert.ToDecimal(Console.ReadLine());
// if(curBalance < 0) {
//     Console.WriteLine("Invalid Balance...!");
//     return;
// }
// Console.Write("Amount to withdraw: ");
// decimal withdraw = Convert.ToDecimal(Console.ReadLine());
// if(withdraw <= 0) {
//     Console.WriteLine("Withdrawal amount must be greater than 0.");
//     return;  
// }
// if(withdraw > curBalance) {
//     Console.WriteLine("Withdrawal amount must be less than or equal to balance.");
//     return;
// }
// decimal remainingBalance = curBalance - withdraw;
// CultureInfo curVn = new CultureInfo("vi-VN");
// Console.WriteLine($"Your remaining balance after withdrawal is: {remainingBalance.ToString("C", curVn)}");
#endregion

#region  Ex7: Tính tốc độ trung bình
// Console.Write("Enter the distance traveled (km): ");
// double distances = Convert.ToDouble(Console.ReadLine());
// if(distances < 0) {
//     Console.WriteLine("Invalid distance...!");
//     return;
// }
// Console.Write("Enter the time taken (hour): ");
// double time = Convert.ToDouble(Console.ReadLine());
// if(time <= 0) {
//     Console.WriteLine("Invalid time...!");
//     return;
// }
// double averageSpeed = distances / time;
// Console.Write($"The average speed is: {averageSpeed:F2} km/h");
#endregion

#region Ex8: Tính tỉ lệ %
// Console.Write("Enter the number: ");
// double number = Convert.ToDouble(Console.ReadLine());
// Console.Write("Enter the total: ");
// double total = Convert.ToDouble(Console.ReadLine());
// string percentage = total == 0 ? "Infinity" : (number / total * 100).ToString();
// Console.WriteLine($"The percentage is: {percentage:F2} {(total == 0 ? "" : "%")}");
#endregion

