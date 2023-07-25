
namespace Task_13
{
    internal class ComparablePair <T,U> where T : IComparable
    {
        public T C { get; init; }
        public U D { get; init; }

        public ComparablePair(T c , U d) 
        {
            C = c;
            D = d;
        }

        public int CompareTo(object? obj)
        {
             if (obj != null)
            {
                var item   = obj.GetType().GetProperty("A");

                return   C.CompareTo(item.GetValue(obj));
            }
            else
            {
                return -1; 
            }
        }

    }
}
