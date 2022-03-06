using System.Runtime.CompilerServices;

namespace AccreditDemoUI.Helpers
{
    public static class MethodName
    {
        public static string GetCallerName([CallerMemberName] string caller = null)
        {
            return caller;
        }
    }
}