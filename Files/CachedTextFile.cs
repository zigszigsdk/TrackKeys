using Files.Core;

using StaticFile = System.IO.File;

namespace Files
{
    class CachedTextFile : File<string>
    {
        public CachedTextFile(FilePath path, string defaultValue = "") : base(path, defaultValue){}

        override protected void Load() => _value = StaticFile.ReadAllText(_path.ToString());
        override protected void Save() => StaticFile.WriteAllText(_path.ToString(), _value);
    }
}
