using System;

namespace CommandParam
{
    public static class TypeExtension
    {
        public static bool IsSubclassOfRawGeneric(this Type toCheck, Type generic)
        {
            // TODO: 可読性が悪いのでリファクタリング要

            while (toCheck != null && toCheck != typeof(object))
            {
                var cur = toCheck.IsGenericType ? toCheck.GetGenericTypeDefinition() : toCheck;
                if (generic == cur)
                {
                    return true;
                }
                toCheck = toCheck.BaseType;
            }
            return false;
        }

    }
}
