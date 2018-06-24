namespace HW17
{
    abstract class Aggregate //как IEnumerable
    {
        public abstract Iterator CreateIterator();
    }
}