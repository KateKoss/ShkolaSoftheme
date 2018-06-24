namespace HW17
{
    abstract class Iterator //как IEnumerator
    {
        public abstract object First();
        
        public abstract object Next();
        
        public abstract bool IsDone();
        
        public abstract object CurrentItem();
    }
}