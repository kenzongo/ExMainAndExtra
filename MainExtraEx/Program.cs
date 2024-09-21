// Main Excercise
#region Ex1: Tính số ngày trong tuần và số ngày lẻ
// while (true)
// {
//     Console.Write("Enter number of days: ");
//     string? input = Console.ReadLine();
//     try
//     {
//         if (string.IsNullOrEmpty(input))
//             throw new ArgumentNullException(input, "Input cannot be null or empty.");
//         int num = int.Parse(input);
//         if(num <= 0) {
//             Console.WriteLine("Invalid day...!");
//             continue;
//         }
//         int weeks = num / 7;
//         int remainingdays = num % 7;
//         Console.WriteLine($"{num} {(num <= 1 ? "day" : "days")} equals {weeks} {(weeks <= 1 ? "week" : "weeks")} and {remainingdays} {(remainingdays <= 1 ? "day" : "days")} ");
//         break;
//     }
//     catch (ArgumentNullException e)
//     {
//         Console.WriteLine(e.Message);
//     }
//     catch (FormatException) {
//         Console.WriteLine("Pleae enter a valid integer number...!");
//     }
//     catch (Exception e)
//     {
//         Console.WriteLine($"An unexpected error occurred : {e.Message}");
//     }
// }
#endregion

#region Ex2: Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá
// using System.Globalization;
// //Using TryParse
// decimal orderValue;
// do
// {
//     Console.Write("Enter order value: ");
// } while (!decimal.TryParse(Console.ReadLine(), out orderValue) || orderValue < 0);
// if (orderValue == 0) Console.WriteLine("Order free...");
// else
// {
//     Console.Write("Enter discount percentage(%): ");
//     decimal discountPercentage = Convert.ToDecimal(Console.ReadLine());
//     discountPercentage = Math.Clamp(discountPercentage, 0, 100); // Limit 0-100, if < 0 set = 0, > 100 set = 100
//     decimal discountAmount = orderValue * discountPercentage / 100;
//     decimal amountAfterDiscount = orderValue - discountAmount;
//     CultureInfo vnCurrency = new CultureInfo("vi-VN");
//     Console.WriteLine($"Discount Amount: {discountAmount}\nAmount after discount: {amountAfterDiscount}");
// }
#endregion

#region Ex3: Chuyển đổi thời gian từ phứt sang giờ và phút. Ex: 130p = 2h and 10p 
// while (true)
// {
//     Console.Write("Enter the number of minutes: ");
//     string? input = Console.ReadLine();
//     string result;
//     try
//     {
//         if (string.IsNullOrEmpty(input))
//         {
//             throw new ArgumentNullException(input, "Input cannot be null or empty.");
//         }
//         int totalMinutes = int.Parse(input);
//         if(totalMinutes < 1) {
//             throw new IndexOutOfRangeException("Please enter the minute greater than 0.");
//         }
//         int hours = totalMinutes / 60;
//         int minutes = totalMinutes % 60;
//         Console.WriteLine($"{totalMinutes} {(totalMinutes <= 1 ? "minute" : "minutes")} = {hours} {(hours <= 1 ? "hour" : "hours")} and {minutes} {(minutes <= 1 ? "minute" : "minutes")}");
//         break;
//     }
//     catch (ArgumentNullException e)
//     {
//         result = e.Message;
//     }
//     catch (FormatException)
//     {
//         result = "Please enter the valid number...!";
//     }
//     catch (IndexOutOfRangeException e) {
//         result = e.Message;
//     }
//     catch (Exception e)
//     {
//         result = $"An unexpected error occurred : {e.Message}";
//     }
//     Console.WriteLine(result);
// }
#endregion

#region Ex4:  Tính số tiền sau khi đã thêm VAT
// using System.Globalization;
// decimal original;
// decimal vate;
// while (true)
// {
//     Console.Write("Enter the original amount: ");
//     string? input = Console.ReadLine();
//     if (string.IsNullOrEmpty(input))
//     {
//         Console.WriteLine("Amount cannot null or empty");
//         continue;
//     }
//     if (!decimal.TryParse(input, out original))
//     {
//         Console.WriteLine("Please enter the valid number...!");
//         continue;
//     }
//     if (original < 0)
//     {
//         Console.WriteLine("Please enter amount greater than or equal to 0...!");
//         continue;
//     }
//     break;
// }
// if (original > 0)
// {
//     while (true)
//     {
//         Console.Write("Enter the VATE rate(%): ");
//         string? input = Console.ReadLine();
//         if (string.IsNullOrEmpty(input))
//         {
//             Console.WriteLine("VATE cannot null or empty");
//             continue;
//         }
//         if (!decimal.TryParse(input, out vate))
//         {
//             Console.WriteLine("Please enter the valid number...!");
//             continue;
//         }
//         if (vate < 0)
//         {
//             Console.WriteLine("Please enter amount greater than or equal to 0...!");
//             continue;
//         }
//         vate = Math.Clamp(vate, 0, 100);
//         break;
//     }
// }
// else {
//     Console.WriteLine("It's free....!");
//     return;
// }
// decimal totalAmount = original * (1 + vate / 100);
// CultureInfo cul = new("vi-VN");
// Console.WriteLine($"Total amount after adding {vate}% VAT is: {totalAmount.ToString("C", cul)}");
#endregion

#region  Ex5: Chuyển đổi đơn vị tiền tệ
// using System.Globalization;
// decimal usdAmount;
// decimal exchangeRate;
// while (true)
// {
//     Console.Write("Enter the amount in USD: ");
//     string? input = Console.ReadLine();
//     if (string.IsNullOrEmpty(input))
//     {
//         Console.WriteLine("Amount cannot be null or empty.");
//         continue;
//     }
//     if (!decimal.TryParse(input, out usdAmount))
//     {
//         Console.WriteLine("Please enter the valid number...!");
//         continue;
//     }
//     if (usdAmount < 1)
//     {
//         Console.WriteLine("Please enter amount greater than 0...!");
//         continue;
//     }
//     break;
// }
// while (true) {
//     Console.Write("Enter the exchange rate: ");
//     string? input = Console.ReadLine();
//     if(string.IsNullOrEmpty(input)) {
//         Console.WriteLine("Exchange rate cannot be null or empty.");
//         continue;
//     }
//     if(!decimal.TryParse(input, out exchangeRate)) {
//         Console.WriteLine("Please enter the valid number...!");
//         continue;
//     }
//     if(exchangeRate < 1) {
//         Console.WriteLine("Please enter amount greater than 0...!");
//         continue;
//     }
//     break ;
// }
// decimal vndAmount = usdAmount * exchangeRate;
// CultureInfo vndCur = new ("vi-VN");
// Console.WriteLine($"{usdAmount:C} equivalent to {vndAmount.ToString("C", vndCur)}");
#endregion

//Extra
#region Ex6: Tính số dư sau khi rút tiền từ tài khoản
// using System.Globalization;
// decimal curBalance;
// decimal withdraw;
// while (true)
// {
//     Console.Write("Current account balance: ");
//     string? input = Console.ReadLine();
//     if (string.IsNullOrEmpty(input))
//     {
//         Console.WriteLine("Current balance cannot be null or empty.");
//         continue;
//     }
//     if (!decimal.TryParse(input, out curBalance))
//     {
//         Console.WriteLine("Please enter the valid number...!");
//         continue;
//     }
//     if (curBalance < 0)
//     {
//         Console.WriteLine("Invalid Balance...!");
//         continue;
//     }
//     break;
// }

// while (true)
// {
//     Console.Write("Amount to withdraw: ");
//     string? input = Console.ReadLine();
//     if (string.IsNullOrEmpty(input))
//     {
//         Console.WriteLine("The amount to withdraw cannot be null or empty.");
//         continue;
//     }
//     if (!decimal.TryParse(input, out withdraw))
//     {
//         Console.WriteLine("Please enter the valid number...!");
//         continue;
//     }
//     if (withdraw <= 0)
//     {
//         Console.WriteLine("Withdrawal amount must be greater than 0.");
//         continue;
//     }
//     if (withdraw > curBalance)
//     {
//         Console.WriteLine("Withdrawal amount must be less than or equal to balance.");
//         continue;
//     }
//     break;

// }
// decimal remainingBalance = curBalance - withdraw;
// CultureInfo curVn = new("vi-VN");
// Console.WriteLine($"Your remaining balance after withdrawal is: {remainingBalance.ToString("C", curVn)}");
#endregion

#region  Ex7: Tính tốc độ trung bình
// double distances;
// double time;
// string averageSpeed;
// while (true)
// {
//     Console.Write("Enter the distance traveled (km): ");
//     string? input = Console.ReadLine();
//     if (string.IsNullOrEmpty(input))
//     {
//         Console.WriteLine("Distance cannot be null or empty.");
//         continue;
//     }
//     if (!double.TryParse(input, out distances))
//     {
//         Console.WriteLine("Please input the valid positive number...!!");
//         continue;
//     }
//     if (distances < 0)
//     {
//         Console.WriteLine("Invalid distance....!");
//         continue;
//     }
//     break;
// }
// while (true)
// {
//     Console.Write("Enter the time taken (hour): ");
//     string? input = Console.ReadLine();
//     if (string.IsNullOrEmpty(input))
//     {
//         Console.WriteLine("Time cannot be null or empty.");
//         continue;
//     }
//     if (!double.TryParse(input, out time))
//     {
//         Console.WriteLine("Please input the valid positive number...!");
//         continue;
//     }
//     if (time <= 0)
//     {
//         Console.WriteLine("Invalid time...!");
//         continue;
//     }
//     break;
// }
// if (time > 0) averageSpeed = (distances / time).ToString();
// else averageSpeed = "Infinity";
// bool parseSuccess = double.TryParse(averageSpeed, out double numOfAverageSpeed);
// Console.Write($"The average speed is: {(parseSuccess ? numOfAverageSpeed : averageSpeed):F2} km/h");
#endregion

#region Ex8: Tính tỉ lệ %
// double number;
// double total;

// while(true) {
//     Console.Write("Enter the number: ");
//     string? input = Console.ReadLine();
//     if(string.IsNullOrEmpty(input)) {
//         Console.WriteLine("Number cannot be null or empty.");
//         continue;
//     }
//     if(!double.TryParse(input, out number)) {
//         Console.WriteLine("Please enter the valid number.!");
//         continue;
//     }
//     break;
// }
// while(true) {
//     Console.Write("Enter the total: ");
//     string? input = Console.ReadLine();
//     if(string.IsNullOrEmpty(input)) {
//         Console.WriteLine("Total cannot be null or empty.");
//         continue;
//     }
//     if(!double.TryParse(input, out total)) {
//         Console.WriteLine("Please enter the valid number.!");
//         continue;
//     }
//     break;
// }
// string percentage = total == 0 ? "Infinity" : (number / total * 100).ToString();

// Console.WriteLine($"The percentage is: {(double.TryParse(percentage, out double numOfPercentage) ? numOfPercentage : percentage):F2} {(total == 0 ? "" : "%")}");
#endregion

#region Ex9: Đổi từ km/h -> m/s
// //Using try catch
// while (true)
// {
//     Console.Write("Enter the speed in km/h: ");
//     string? input = Console.ReadLine();
//     string message = "";
//     try
//     {
//         if (string.IsNullOrEmpty(input))
//         {
//             throw new ArgumentNullException(input, "Speed cannot null or empty.");
//         }
//         double speedKmh = double.Parse(input);
//         if (speedKmh < 1)
//         {
//             Console.WriteLine("Please enter speed greater than 0.");
//             continue;
//         }
//         Console.WriteLine($"{speedKmh} km/h = {speedKmh / 3.6:F2} m/s");
//         break;
//     }
//     catch (ArgumentNullException e)
//     {
//         message = e.Message;
//     } catch (FormatException e)
//     {
//         message = e.Message;
//     }
//     catch (Exception e)
//     {
//         message = $"An unpected error occured: {e.Message}";
//     }
//     Console.WriteLine(message);
// }
#endregion

#region Ex10: Tính lượng calo tiêu thụ
// double minute;
// int choose;
// double calPerMinute;
// while (true)
// {
//     Console.Write("Enter the number of minutes: ");
//     if (double.TryParse(Console.ReadLine(), out minute) && minute > 0)
//     {
//         break;
//     }
//     Console.WriteLine("Invalid input. Please enter a valid positive number.");
// }
// Console.WriteLine("Choose the type of exercise:");
// Console.WriteLine("1. Running (10 cal/min)");
// Console.WriteLine("2. Cycling (15 cal/min)");
// Console.WriteLine("3. Swimming (20 cal/min)");
// while (true)
// {
//     Console.Write("Enter the exercise type (1-3): ");
//     if(int.TryParse(Console.ReadLine(), out choose) && choose >= 1 && choose <=3) {
//         break;
//     }
//     Console.WriteLine("Invalid input. Please enter a valid number (1-3).");
// }
// calPerMinute = choose switch
// {
//     1 => 10,
//     2 => 15,
//     3 => 20,
//     _ => 0
// };

// double caloriseBurned = calPerMinute * minute;
// Console.WriteLine($"Result = {caloriseBurned:F2} calo");
#endregion