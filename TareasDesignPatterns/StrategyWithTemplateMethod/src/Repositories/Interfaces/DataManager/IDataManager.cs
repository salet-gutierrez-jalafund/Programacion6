namespace StrategyWithTemplateMethod.src.Repositories.Interfaces.DataManager;

public interface IDataManager<T>
{
    List<T> LoadData();

    T SearchById(string attributeName, object id);

    List<T> SearchByAttribute(string attributeName, string value);

    bool AddItem(T item);

    bool RemoveItem(string attributeName, object id);

    bool UpdateItem(string attributeName, object id, T updatedItem);
}
