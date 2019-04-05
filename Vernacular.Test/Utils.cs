using System.IO;

namespace Vernacular.Test
{
    public static class Utils
    {
        public static string GetTestPath (string name) =>
            Path.Combine (Path.GetDirectoryName (typeof (Utils).Assembly.Location), name);
    }
}
