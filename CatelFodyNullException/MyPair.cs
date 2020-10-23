using DomainLib;

namespace CatelFodyNullException
{
    /// <summary>
    /// This fails when KeyValuePair is not in the local assembly
    /// </summary>
    public class MyPair : KeyValuePair<int, int>
    {
    }
}