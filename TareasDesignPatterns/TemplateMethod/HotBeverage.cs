// Clase abstracta que define el método template
abstract class HotBeverage
{
    // Método Template que define el esqueleto del algoritmo
    public void PrepareRecipe()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddCondiments();
    }

    // Método común para hervir el agua
    private void BoilWater()
    {
        Console.WriteLine("Hervir el agua");
    }

    // Método común para verter la bebida en la taza
    private void PourInCup()
    {
        Console.WriteLine("Verter en la taza");
    }

    // Métodos abstractos que las subclases deben implementar
    protected abstract void Brew();
    protected abstract void AddCondiments();
}