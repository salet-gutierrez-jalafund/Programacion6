using CommandRestauranteMenu.src.Commands;
using CommandRestauranteMenu.src.Invokers;
using CommandRestauranteMenu.src.Receivers;
using CommandRestauranteMenu.src.Repositories.Concrets;
using CommandRestauranteMenu.src.Services.Concrets;
using CommandRestauranteMenu.src.Strategies;
using Spectre.Console;

public class Program
{
    public static void Main(string[] args)
    {

        // Crear el invocador
        var invoker = new Invoker();

        // Crear el receptor
        var menuReceiver = new MenuReceiver();
        var orderRepository = new OrderRepository();
        var orderService = new OrderService(orderRepository, menuReceiver);
        var orderReceiver = new OrderReceiver(orderService);

        var calculateTotalStrategy = new SimpleCalculateTotalStrategy();
        var billService = new BillService(orderRepository, calculateTotalStrategy);
        var billReceiver = new BillReceiver(billService);

        var takeOrderCommand = new TakeOrderCommand(orderReceiver);
        var listMenuCommand = new ListMenuCommand(menuReceiver);
        var generateBillCommand = new GenerateBillCommand(billReceiver);

        invoker.SetCommand("TakeOrder", takeOrderCommand);
        invoker.SetCommand("ListMenu", listMenuCommand);
        invoker.SetCommand("GenerateBill", generateBillCommand);

        var running = true;

        while (running)
        {
            var selection = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Select an option:")
                    .AddChoices(new[] { "List Menu", "Take Order", "Generate Account", "Exit" }));

            switch (selection)
            {
                case "List Menu":
                    invoker.ExecuteCommand("ListMenu");
                    break;
                case "Take Order":
                    invoker.ExecuteCommand("TakeOrder");
                    break;
                case "Generate Account":
                    invoker.ExecuteCommand("GenerateBill");
                    break;
                case "Exit":
                    running = false;
                    break;
            }
        }
    }
}
