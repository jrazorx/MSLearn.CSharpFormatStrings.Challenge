using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

string newFinancialProductIntroMessage = "";
newFinancialProductIntroMessage += $"Dear {customerName},\n";
newFinancialProductIntroMessage += $"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\n";
newFinancialProductIntroMessage += $"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n\n";
newFinancialProductIntroMessage += $"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C2}.\n";
Console.WriteLine(newFinancialProductIntroMessage);

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";


Console.WriteLine(comparisonMessage);