using Catel.Data;

namespace CatelFodyNullException
{
    public class MyModel : ModelBase
    {
        public MyAssemblyPair AssemblyPair { get; set; } // this one works fine
        public MyPair Pair { get; set; } // this one fails
    }
}