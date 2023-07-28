using Models;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***** \t TIME KEEPERS \t *****");

            var watches = new WatchInventory().Inventory;

            Console.WriteLine("ID\tName\t\tUnit Price\tDiscount");
            foreach (var id in watches.Keys)
            {
                Console.WriteLine($"{id}\t" +
                    $"{watches[id].WatchName}\t\t" +
                    $"{watches[id].UnitPrice}\t\t" +
                    $"({watches[id].DiscountQuantity} for {watches[id].DiscountAmount})\n");
            }
            
            Console.WriteLine("Enter IDs of the watches you wish to order.\nPlease separate them by commas\nPress 'Enter' to submit to the order: ");

            var order = new OrderModel();
            while (true)
            {
                var key = Console.ReadKey();
                if (key.KeyChar is (char)ConsoleKey.Enter)
                    break;
                else if (key.KeyChar >= '1' && key.KeyChar <= '4')
                {
                    //var watchId = key.KeyChar.ToString();
                    var watchId = (int)Char.GetNumericValue(key.KeyChar);
                    if(!order.OrderByWatchId.ContainsKey(watchId))
                        order.OrderByWatchId[watchId] = 1;
                    else
                        order.OrderByWatchId[watchId]++;
                }
                else if (key.KeyChar is ',' or (char)ConsoleKey.Spacebar)
                    continue;
                else
                    Console.WriteLine("Enter values between 1 to 4 (inclusive). Try again...");
            }

            var totalCost = order.CalculateTotalCost(watches);
            Console.WriteLine("Total Cost = USD " + totalCost);
        }
    }
}