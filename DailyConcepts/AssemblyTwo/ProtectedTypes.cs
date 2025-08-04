using AssemblyOne.Types;

namespace AssemblyTwo.ProtectedTypes
{
    /// <summary>
    /// Access Modifiers for Types
    /// </summary>
    public class PublicAccessTwo
    {
        public void Text()
        {
            PublicAccessOne instance = new PublicAccessOne();
            instance.Print1();
        }
    }
}
