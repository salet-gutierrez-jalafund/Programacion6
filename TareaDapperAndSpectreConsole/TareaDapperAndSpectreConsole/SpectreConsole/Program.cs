using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public static class Program
{
    public static void Main(string[] args)
    {
        // Hello World
        // AnsiConsole.Markup("[underline red]Hello[/] World!");

        /*******************************************************************************************************************/

        // Text Prompt
        // Prompt para el nombre del usuario
        // var name = AnsiConsole.Prompt(
        //     new TextPrompt<string>("What's your name?")
        //         .PromptStyle("green")
        //         .DefaultValue("Unknown")
        // );

        // // Prompt para el deporte favorito con opciones predefinidas
        // var sports = new[] { "Soccer", "Hockey", "Basketball" };
        // var favoriteSport = AnsiConsole.Prompt(
        //     new SelectionPrompt<string>()
        //         .Title("What's your favorite sport?")
        //         .AddChoices(sports)
        // );

        // // Prompt para la edad con validación
        // int age;
        // while (true)
        // {
        //     var ageInput = AnsiConsole.Prompt(
        //         new TextPrompt<string>("How old are you?")
        //             .PromptStyle("green")
        //     );

        //     if (int.TryParse(ageInput, out age))
        //     {
        //         break;
        //     }
        //     else
        //     {
        //         AnsiConsole.MarkupLine("[red]That's not a valid age[/]");
        //     }
        // }

        // // Prompt para la contraseña (oculta la entrada)
        // var password = AnsiConsole.Prompt(
        //     new TextPrompt<string>("Enter password?")
        //         .PromptStyle("green")
        //         .Secret()
        // );

        // // Prompt opcional para el color favorito
        // var favoriteColor = AnsiConsole.Prompt(
        //     new TextPrompt<string>("What is your favorite color?")
        //         .PromptStyle("green")
        //         .DefaultValue("Unknown")
        // );

        // // Prompt para las frutas favoritas
        // var fruits = AnsiConsole.Prompt(
        //     new MultiSelectionPrompt<string>()
        //         .Title("What are your [green]favorite fruits[/]?")
        //         .NotRequired() // Not required to have a favorite fruit
        //         .PageSize(10)
        //         .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
        //         .InstructionsText(
        //             "[grey](Press [blue]<space>[/] to toggle a fruit, " +
        //             "[green]<enter>[/] to accept)[/]")
        //         .AddChoices(new[] {
        //             "Apple", "Apricot", "Avocado",
        //             "Banana", "Blackcurrant", "Blueberry",
        //             "Cherry", "Cloudberry", "Coconut",
        //         })
        // );

        // // Convertir la lista de frutas a una cadena separada por comas
        // var fruitsString = string.Join(", ", fruits);

        // // Mostrar los resultados
        // AnsiConsole.Write(
        //     new Table()
        //         .AddColumn("Question")
        //         .AddColumn("Answer")
        //         .AddRow("Name", name)
        //         .AddRow("Favorite sport", favoriteSport)
        //         .AddRow("Age", age.ToString())
        //         .AddRow("Password", password)
        //         .AddRow("Favorite color", favoriteColor)
        //         .AddRow("Favorite fruits", fruitsString)
        // );


        /*******************************************************************************************************************/


        // Panel

        // var panel = new Panel(new Markup("[bold]Spaghetti[/]\n[bold]Linguini[/]\n[bold]Fettucine[/]\n[bold]Tortellini[/]\n[bold]Capellini[/]\n[bold]Lasagna[/]"))
        // {
        //     Header = new PanelHeader("[yellow]Pasta Menu[/]", Justify.Center),
        //     Border = BoxBorder.Double,
        //     Padding = new Padding(1, 1, 1, 1),
        //     Expand = true,
        // };

        // // Mostrar el panel
        // AnsiConsole.Write(panel);


        /*******************************************************************************************************************/


        // Create the tree
        // var root = new Tree("Root");

        // // Add some nodes
        // var foo = root.AddNode("[yellow]Foo[/]");
        // var table = foo.AddNode(new Table()
        //     .RoundedBorder()
        //     .AddColumn("First")
        //     .AddColumn("Second")
        //     .AddRow("1", "2")
        //     .AddRow("3", "4")
        //     .AddRow("5", "6"));

        // table.AddNode("[blue]Baz[/]");
        // foo.AddNode("Qux");

        // var bar = root.AddNode("[yellow]Bar[/]");

        //// Calendar
        // bar.AddNode(new Calendar(2020, 12)
        //     .AddCalendarEvent(2020, 12, 12)
        //     .HideHeader());

        // // Render the tree
        // AnsiConsole.Write(root);


        /*******************************************************************************************************************/


        // Bar Chart
        // AnsiConsole.Write(new BarChart()
        //     .Width(60)
        //     .Label("[green bold underline]Number of fruits[/]")
        //     .CenterLabel()
        //     .AddItem("Apple", 12, Color.Yellow)
        //     .AddItem("Orange", 54, Color.Green)
        //     .AddItem("Banana", 33, Color.Red)
        // );

        /*******************************************************************************************************************/
        // Breakdown Chart

        // AnsiConsole.Write(new BreakdownChart()
        //     .Width(60)
        //     // Add item is in the order of label, value, then color.
        //     .AddItem("SCSS", 80, Color.Red)
        //     .AddItem("HTML", 28.3, Color.Blue)
        //     .AddItem("C#", 22.6, Color.Green)
        //     .AddItem("JavaScript", 6, Color.Yellow)
        //     .AddItem("Ruby", 6, Color.LightGreen)
        //     .AddItem("Shell", 0.1, Color.Aqua)
        // );

        /*******************************************************************************************************************/

        // Grid

        // var grid = new Grid();

        // // Add columns 
        // grid.AddColumn();
        // grid.AddColumn();
        // grid.AddColumn();

        // // Add header row 
        // grid.AddRow(new Text[]{
        //     new Text("Header 1", new Style(Color.Red, Color.Black)).LeftJustified(),
        //     new Text("Header 2", new Style(Color.Green, Color.Black)).Centered(),
        //     new Text("Header 3", new Style(Color.Blue, Color.Black)).RightJustified()
        // });

        // // Add content row 
        // grid.AddRow(new Text[]{
        //     new Text("Row 1").LeftJustified(),
        //     new Text("Row 2").Centered(),
        //     new Text("Row 3").RightJustified()
        // });

        // // Write centered cell grid contents to Console
        // AnsiConsole.Write(grid);


        /*******************************************************************************************************************/


        // Create the layout
        // var layout = new Layout("Root")
        //     .SplitColumns(
        //         new Layout("Left"),
        //         new Layout("Right")
        //             .SplitRows(
        //                 new Layout("Top"),
        //                 new Layout("Bottom")));

        // // Update the left column
        // layout["Left"].Update(
        //     new Panel(
        //         Align.Center(
        //             new Markup("Hello [blue]World![/]"),
        //             VerticalAlignment.Middle))
        //         .Expand());

        // // Render the layout
        // AnsiConsole.Write(layout);

        /*******************************************************************************************************************/

        // Figlet
        // AnsiConsole.Write(
        //     new FigletText("Hello I am Salet")
        //         .LeftJustified()
        //         .Color(Color.Red)
        //     );

        /*******************************************************************************************************************/

        // dotnet add package Spectre.Console.ImageSharp
        // Canvas Image

        // Load an image
        // var image = new CanvasImage("dekubebe.jpg");

        // // Set the max width of the image.
        // // If no max width is set, the image will take
        // // up as much space as there is available.
        // image.MaxWidth(50);

        // // Render the image to the console
        // AnsiConsole.Write(image);


        ////// SIMULACION DE PAGINACION 1
        // var items = new List<string>
        // {
        //     "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", 
        //     "Item 6", "Item 7", "Item 8", "Item 9", "Item 10"
        // };

        // int pageSize = 3;
        // int currentPage = 0;
        // bool exit = false;

        // while (!exit)
        // {
        //     AnsiConsole.Clear();
        //     var pageItems = items.GetRange(currentPage * pageSize, Math.Min(pageSize, items.Count - currentPage * pageSize));

        //     AnsiConsole.Write(new Markup($"[bold underline]Page {currentPage + 1}[/]\n\n"));
        //     foreach (var item in pageItems)
        //     {
        //         AnsiConsole.WriteLine(item);
        //     }

        //     var choice = AnsiConsole.Prompt(
        //         new SelectionPrompt<string>()
        //             .AddChoices(new[] { "Next", "Previous", "Exit" }));

        //     switch (choice)
        //     {
        //         case "Next":
        //             if ((currentPage + 1) * pageSize < items.Count)
        //             {
        //                 currentPage++;
        //             }
        //             break;
        //         case "Previous":
        //             if (currentPage > 0)
        //             {
        //                 currentPage--;
        //             }
        //             break;
        //         case "Exit":
        //             exit = true;
        //             break;
        //     }
        // }


        ////// SIMULACION DE PAGINACION 2
        ///
        // var items = new List<string>
        // {
        //     "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", 
        //     "Item 6", "Item 7", "Item 8", "Item 9", "Item 10"
        // };

        // var selection = AnsiConsole.Prompt(
        //     new SelectionPrompt<string>()
        //         .PageSize(3) // Número de elementos por página
        //         .Title("Select an item")
        //         .MoreChoicesText("[grey](Move up and down to reveal more)[/]")
        //         .AddChoices(items));

        // AnsiConsole.WriteLine($"You selected: {selection}");

        //     var data = Enumerable.Range(1, 50).Select(i => $"Item {i}").ToList();
        //     int pageSize = 5;
        //     int currentPage = 1;
        //     int totalPages = (int)Math.Ceiling((double)data.Count / pageSize);

        //     while (true)
        //     {
        //         Console.Clear();
        //         ShowPage(data, currentPage, pageSize);
        //         Console.WriteLine();
        //         Console.WriteLine($"Page {currentPage} of {totalPages}");

        //         var key = Console.ReadKey(true).Key;

        //         if (key == ConsoleKey.RightArrow && currentPage < totalPages)
        //         {
        //             currentPage++;
        //         }
        //         else if (key == ConsoleKey.LeftArrow && currentPage > 1)
        //         {
        //             currentPage--;
        //         }
        //         else if (key == ConsoleKey.Escape)
        //         {
        //             break;
        //         }
        //     }
        // }

        // static void ShowPage(List<string> data, int pageNumber, int pageSize)
        // {
        //     int skip = (pageNumber - 1) * pageSize;
        //     var pageData = data.Skip(skip).Take(pageSize);

        //     var table = new Table();
        //     table.AddColumn("Item");

        //     foreach (var item in pageData)
        //     {
        //         table.AddRow(item);
        //     }

        //     AnsiConsole.Render(table);
        // }

    //     // Lista de elementos para buscar
    //     var items = new List<string>
    //     {
    //         "Apple", "Banana", "Orange", "Grape", "Pineapple", "Mango"
    //     };

    //     // Ciclo para implementar el buscador en tiempo real
    //     while (true)
    //     {
    //         AnsiConsole.Clear();
    //         var input = AnsiConsole.Ask<string>("Enter search term (or 'exit' to quit): ");

    //         if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
    //             break;

    //         // Buscar en tiempo real (case-insensitive)
    //         var results = items.Where(item => item.Contains(input, StringComparison.OrdinalIgnoreCase)).ToList();

    //         if (results.Any())
    //         {
    //             AnsiConsole.MarkupLine("[bold green]Results:[/]");
    //             foreach (var result in results)
    //             {
    //                 AnsiConsole.MarkupLine(result);
    //             }
    //         }
    //         else
    //         {
    //             AnsiConsole.MarkupLine("[bold red]No results found.[/]");
    //         }

    //         // Esperar 3 segundos antes de limpiar la pantalla
    //         Thread.Sleep(3000);
    //     }
    // }

}