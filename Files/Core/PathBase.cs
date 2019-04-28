using System;
using StaticPath = System.IO.Path;

namespace Files.Core
{
    public enum ValidationResultStatusCode { OK, Error };
    
    public struct ValidationResult
    {
        public ValidationResultStatusCode statusCode;
        public string errorDescription;

        public ValidationResult(ValidationResultStatusCode statusCode = ValidationResultStatusCode.OK, string errorDescription = "")
        {
            this.statusCode = statusCode;
            this.errorDescription = errorDescription;
        }
    }

    public class PathException : Exception
    {
        public PathException() : base() { }
        public PathException(string message) : base(message) { }
        public PathException(string message, Exception inner) : base(message, inner) { }
    }

    public abstract class PathBase
    {
        protected string _value;

        public PathBase(string path) => Set(path);

        override public string ToString() => _value;

        public void Set(string path)
        {
            ValidationResult result = Validate(path);
            if (result.statusCode != ValidationResultStatusCode.OK)
                throw new PathException(result.errorDescription);
            
            _value = path;
        }

        virtual protected ValidationResult Validate(string path)
        {
            if (path.IndexOfAny(StaticPath.GetInvalidPathChars()) != -1)
                return new ValidationResult(ValidationResultStatusCode.Error, "Contains invalid characters.");

            return new ValidationResult();
        }
    }
}
