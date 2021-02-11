using System;

namespace CommandParam
{
    public static class TypeExtension
    {
        public static bool IsSubclassOfGeneric(this Type current, Type compare)
        {
            while ((current != null) && (current != typeof(object)))
            {
                Type checkType;
                if (current.IsGenericType == true)
                {
                    checkType = current.GetGenericTypeDefinition();
                }
                else
                {
                    checkType = current;
                }

                if (compare == checkType)
                {
                    return true;
                }

                current = current.BaseType;
            }

            return false;
        }
    }
}
