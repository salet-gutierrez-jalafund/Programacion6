using CommandRestauranteMenu.src.Commands.Interfaces;
using CommandRestauranteMenu.src.Receivers;

namespace CommandRestauranteMenu.src.Commands;

public class GenerateBillCommand : ICommand
{
    private readonly BillReceiver _billReceiver;

    public GenerateBillCommand(BillReceiver billReceiver)
    {
        _billReceiver = billReceiver;
    }

    public void Execute()
    {
        _billReceiver.GenerateBill();
    }
}
