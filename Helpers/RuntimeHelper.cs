using System.Runtime.CompilerServices;
using System.Threading;

namespace Helpers
{
    public static class RuntimeHelper
    {
        public static void Init<T>()
        {
            RuntimeHelpers.RunClassConstructor(typeof (T).TypeHandle);
        }

        public static void InitInNewThread<T>()
        {
            new Thread(Init<T>).Start();
        }
    }
}
