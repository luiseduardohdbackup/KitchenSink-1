namespace KitchenSink.Core
{
    //Workarround for c# lack of enum of objects
    public interface IEnum<T> //where T : class
    {
        T getValue();
    }
}