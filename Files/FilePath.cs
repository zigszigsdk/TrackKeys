using System.IO;

using Files.Core;

namespace Files
{
    public class FilePath : PathBase
    {
        public FilePath(string path) : base(path) { }

        override protected ValidationResult Validate(string path)
        {
            char last = path[path.Length - 1];
            if (last == Path.DirectorySeparatorChar || last == Path.AltDirectorySeparatorChar)
                return new ValidationResult(ValidationResultStatusCode.Error, "Path string is a dictionary. File path expected.");

            return base.Validate(path);
        }
    }
}
