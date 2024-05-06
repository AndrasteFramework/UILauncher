using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Andraste.UILauncher.Util
{
    public static class AsyncUtils
    {
        public static async Task<string> ReadAllTextAsync(string path)
        {
            using (var file = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var reader = new StreamReader(file))
                {
                    return await reader.ReadToEndAsync();
                }
            }
        }

        public static async Task WriteAllBytesAsync(string path, byte[] value)
        {
            using (var file = File.Open(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                await file.WriteAsync(value, 0, value.Length);
            }
        }
        
        public static async Task WaitForExitAsync(this Process process, CancellationToken cancellationToken = default)
        {
            while (!process.HasExited)
            {
                await Task.Delay(100, cancellationToken);
            }
        }
    }
}