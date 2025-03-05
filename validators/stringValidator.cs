using System;

namespace Lesson0.validators
{
    class stringValidator
    {
        public static bool Validate(string value)
        {
            return String.IsNullOrWhiteSpace(value);
        }
    }
}
