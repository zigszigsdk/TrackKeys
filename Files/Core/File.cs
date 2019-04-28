using StaticFile = System.IO.File;

namespace Files.Core
{
    abstract public class File<Payload>
    {
        protected FilePath _path;

        protected Payload _value;

        public File(FilePath path, Payload defaultValue)
        {
            _path = path;

            if (StaticFile.Exists(path.ToString()))
            {
                Load();
                return;
            }

            _value = defaultValue;
            Save();
        }

        public void Set(Payload value)
        {
            _value = value;
            Save();
        }

        public Payload Get() => _value;

        public FilePath GetPath() => _path;

        abstract protected void Load();
        abstract protected void Save();
    }
}
