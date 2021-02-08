namespace CommandParam
{
    public static class ArrayParameterHelper
    {
        public static bool TryGetParameters<T>(object[] parameter, out T parameter1)
        {
            bool result= TryGetParameters(parameter, out T _parameter1);
            parameter1 = _parameter1;

            return result;
        }

        public static bool TryGetParameters<T>(object parameter, out T parameter1)
        {
            if (!(parameter is object[]))
            {
                parameter1 = default;
                return false;
            }

            object[] _parameter = (object[])parameter;

            if (_parameter.Length <= 0)
            {
                parameter1 = default;
                return false;
            }

            if (!(_parameter[0] is T))
            {
                parameter1 = default;
                return false;
            }

            parameter1 = (T)_parameter[0];

            return true;
        }
    }
}
