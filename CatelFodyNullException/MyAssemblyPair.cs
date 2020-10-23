using DomainLib;

namespace CatelFodyNullException
{
    /// <summary>
    /// No problem when base class is in the local assembly
    /// </summary>
    public class MyAssemblyPair : AssemblyKeyValuePair<int, int>
    {
    }
}