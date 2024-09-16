// Interfaz Iterator que define las operaciones básicas
interface IIterator<T>
{
    T Current { get; }   // Obtener el elemento actual
    bool MoveNext();     // Moverse al siguiente elemento
    void Reset();        // Reiniciar el iterador
}