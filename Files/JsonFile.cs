using System;

using Newtonsoft.Json;

namespace Files
{
    public class JsonFileException : Exception
    {
        public JsonFileException(string message, Exception inner) : base(message, inner) { }
    }

    public class JsonFile<T>
    {
        CachedTextFile _file;
        public T value;

        public JsonFile(FilePath path, T defaultValue)
        {
            _file = new CachedTextFile(path, JsonConvert.SerializeObject(defaultValue));
            Load();
        }

        public void Load()
        {
            try
            {
                value = JsonConvert.DeserializeObject<T>(_file.Get());
            }
            catch (Exception e)
            {
                throw new JsonFileException("Could not Load JsonFile from invalid json-file at: " + _file.GetPath().ToString(), e);
            }
        }

        public void Save()
        {
            try
            {
                _file.Set(JsonConvert.SerializeObject(value));
            }
            catch (Exception e)
            {
                throw new JsonFileException("Could not Set JsonFile to invalid or recursive json-value. ", e);
            }
        }
    }
}
