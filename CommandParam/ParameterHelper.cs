using System.Linq;
using System.Windows;

namespace CommandParam
{
    public static class ParameterHelper
    {
        private const int INDEX_O = 11;
        private const int INDEX_P = 10;
        private const int INDEX_Q = 9;
        private const int INDEX_R = 8;
        private const int INDEX_S = 7;
        private const int INDEX_T = 6;
        private const int INDEX_U = 5;
        private const int INDEX_V = 4;
        private const int INDEX_W = 3;
        private const int INDEX_X = 2;
        private const int INDEX_Y = 1;
        private const int INDEX_Z = 0;

        public static bool TryGetParameters<Z>(object[] parameter, out Z parameter1)
        {
            bool result = TryGetParameters(parameter, out Z _parameter1);
            parameter1 = _parameter1;
            return result;
        }

        public static bool TryGetParameters<Z>(object parameter, out Z parameter1)
        {
            if (parameter is CommandParameter)
            {
                parameter = ((CommandParameter)parameter).Value;
            }

            // パラメーターが 1 つの場合の特殊処理
            if (parameter is Z)
            {
                parameter1 = (Z)parameter;
                return true;
            }

            if (!(parameter is object[]))
            {
                parameter1 = default;
                return false;
            }

            object[] _parameter = (object[])parameter;

            if (_parameter.Length <= INDEX_Z)
            {
                parameter1 = default;
                return false;
            }

            if (_parameter.Contains(DependencyProperty.UnsetValue) == true)
            {
                parameter1 = default;
                return false;
            }

            if (!(_parameter[INDEX_Z] is Z))
            {
                parameter1 = default;
                return false;
            }

            parameter1 = (Z)_parameter[INDEX_Z];

            return true;
        }

        public static bool TryGetParameters<Z, Y>(object[] parameter, out Z parameter1, out Y parameter2)
        {
            bool result = TryGetParameters(parameter, out Z _parameter1, out Y _parameter2);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            return result;
        }

        public static bool TryGetParameters<Z, Y>(object parameter, out Z parameter1, out Y parameter2)
        {
            if (parameter is CommandParameter)
            {
                parameter = ((CommandParameter)parameter).Value;
            }

            if (!(parameter is object[]))
            {
                parameter1 = default;
                parameter2 = default;
                return false;
            }

            object[] _parameter = (object[])parameter;

            if (_parameter.Length <= INDEX_Y)
            {
                parameter1 = default;
                parameter2 = default;
                return false;
            }

            if (_parameter.Contains(DependencyProperty.UnsetValue) == true)
            {
                parameter1 = default;
                parameter2 = default;
                return false;
            }

            if (!(_parameter[INDEX_Z] is Z))
            {
                parameter1 = default;
                parameter2 = default;
                return false;
            }

            parameter1 = (Z)_parameter[INDEX_Z];

            if (!(_parameter[INDEX_Y] is Y))
            {
                parameter2 = default;
                return false;
            }

            parameter2 = (Y)_parameter[INDEX_Y];

            return true;
        }

        public static bool TryGetParameters<Z, Y, X>(object[] parameter, out Z parameter1, out Y parameter2, out X parameter3)
        {
            bool result = TryGetParameters(parameter, out Z _parameter1, out Y _parameter2, out X _parameter3);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            parameter3 = _parameter3;
            return result;
        }

        public static bool TryGetParameters<Z, Y, X>(object parameter, out Z parameter1, out Y parameter2, out X parameter3)
        {
            if (parameter is CommandParameter)
            {
                parameter = ((CommandParameter)parameter).Value;
            }

            if (!(parameter is object[]))
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                return false;
            }

            object[] _parameter = (object[])parameter;

            if (_parameter.Length <= INDEX_X)
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                return false;
            }

            if (_parameter.Contains(DependencyProperty.UnsetValue) == true)
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                return false;
            }

            if (!(_parameter[INDEX_Z] is Z))
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                return false;
            }

            parameter1 = (Z)_parameter[INDEX_Z];

            if (!(_parameter[INDEX_Y] is Y))
            {
                parameter2 = default;
                parameter3 = default;
                return false;
            }

            parameter2 = (Y)_parameter[INDEX_Y];

            if (!(_parameter[INDEX_X] is X))
            {
                parameter3 = default;
                return false;
            }

            parameter3 = (X)_parameter[INDEX_X];

            return true;
        }

        public static bool TryGetParameters<Z, Y, X, W>(object[] parameter, out Z parameter1, out Y parameter2, out X parameter3, out W parameter4)
        {
            bool result = TryGetParameters(parameter, out Z _parameter1, out Y _parameter2, out X _parameter3, out W _parameter4);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            parameter3 = _parameter3;
            parameter4 = _parameter4;
            return result;
        }

        public static bool TryGetParameters<Z, Y, X, W>(object parameter, out Z parameter1, out Y parameter2, out X parameter3, out W parameter4)
        {
            if (parameter is CommandParameter)
            {
                parameter = ((CommandParameter)parameter).Value;
            }

            if (!(parameter is object[]))
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                return false;
            }

            object[] _parameter = (object[])parameter;

            if (_parameter.Length <= INDEX_W)
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                return false;
            }

            if (_parameter.Contains(DependencyProperty.UnsetValue) == true)
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                return false;
            }

            if (!(_parameter[INDEX_Z] is Z))
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                return false;
            }

            parameter1 = (Z)_parameter[INDEX_Z];

            if (!(_parameter[INDEX_Y] is Y))
            {
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                return false;
            }

            parameter2 = (Y)_parameter[INDEX_Y];

            if (!(_parameter[INDEX_X] is X))
            {
                parameter3 = default;
                parameter4 = default;
                return false;
            }

            parameter3 = (X)_parameter[INDEX_X];

            if (!(_parameter[INDEX_W] is W))
            {
                parameter4 = default;
                return false;
            }

            parameter4 = (W)_parameter[INDEX_W];

            return true;
        }

        public static bool TryGetParameters<Z, Y, X, W, V>(object[] parameter, out Z parameter1, out Y parameter2, out X parameter3, out W parameter4, out V parameter5)
        {
            bool result = TryGetParameters(parameter, out Z _parameter1, out Y _parameter2, out X _parameter3, out W _parameter4, out V _parameter5);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            parameter3 = _parameter3;
            parameter4 = _parameter4;
            parameter5 = _parameter5;
            return result;
        }

        public static bool TryGetParameters<Z, Y, X, W, V>(object parameter, out Z parameter1, out Y parameter2, out X parameter3, out W parameter4, out V parameter5)
        {
            if (parameter is CommandParameter)
            {
                parameter = ((CommandParameter)parameter).Value;
            }

            if (!(parameter is object[]))
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                return false;
            }

            object[] _parameter = (object[])parameter;

            if (_parameter.Length <= INDEX_V)
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                return false;
            }

            if (_parameter.Contains(DependencyProperty.UnsetValue) == true)
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                return false;
            }

            if (!(_parameter[INDEX_Z] is Z))
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                return false;
            }

            parameter1 = (Z)_parameter[INDEX_Z];

            if (!(_parameter[INDEX_Y] is Y))
            {
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                return false;
            }

            parameter2 = (Y)_parameter[INDEX_Y];

            if (!(_parameter[INDEX_X] is X))
            {
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                return false;
            }

            parameter3 = (X)_parameter[INDEX_X];

            if (!(_parameter[INDEX_W] is W))
            {
                parameter4 = default;
                parameter5 = default;
                return false;
            }

            parameter4 = (W)_parameter[INDEX_W];

            if (!(_parameter[INDEX_V] is V))
            {
                parameter5 = default;
                return false;
            }

            parameter5 = (V)_parameter[INDEX_V];

            return true;
        }

        public static bool TryGetParameters<Z, Y, X, W, V, U>(object[] parameter, out Z parameter1, out Y parameter2, out X parameter3, out W parameter4, out V parameter5, out U parameter6)
        {
            bool result = TryGetParameters(parameter, out Z _parameter1, out Y _parameter2, out X _parameter3, out W _parameter4, out V _parameter5, out U _parameter6);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            parameter3 = _parameter3;
            parameter4 = _parameter4;
            parameter5 = _parameter5;
            parameter6 = _parameter6;

            return result;
        }

        public static bool TryGetParameters<Z, Y, X, W, V, U>(object parameter, out Z parameter1, out Y parameter2, out X parameter3, out W parameter4, out V parameter5, out U parameter6)
        {
            if (parameter is CommandParameter)
            {
                parameter = ((CommandParameter)parameter).Value;
            }

            if (!(parameter is object[]))
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                return false;
            }

            object[] _parameter = (object[])parameter;

            if (_parameter.Length <= INDEX_V)
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                return false;
            }

            if (_parameter.Contains(DependencyProperty.UnsetValue) == true)
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                return false;
            }

            if (!(_parameter[INDEX_Z] is Z))
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                return false;
            }

            parameter1 = (Z)_parameter[INDEX_Z];

            if (!(_parameter[INDEX_Y] is Y))
            {
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                return false;
            }

            parameter2 = (Y)_parameter[INDEX_Y];

            if (!(_parameter[INDEX_X] is X))
            {
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                return false;
            }

            parameter3 = (X)_parameter[INDEX_X];

            if (!(_parameter[INDEX_W] is W))
            {
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                return false;
            }

            parameter4 = (W)_parameter[INDEX_W];

            if (!(_parameter[INDEX_V] is V))
            {
                parameter5 = default;
                parameter6 = default;
                return false;
            }

            parameter5 = (V)_parameter[INDEX_V];

            if (!(_parameter[INDEX_U] is U))
            {
                parameter6 = default;
                return false;
            }

            parameter6 = (U)_parameter[INDEX_U];

            return true;
        }

        public static bool TryGetParameters<Z, Y, X, W, V, U, T>(object[] parameter, out Z parameter1, out Y parameter2, out X parameter3, out W parameter4, out V parameter5, out U parameter6, out T parameter7)
        {
            bool result = TryGetParameters(parameter, out Z _parameter1, out Y _parameter2, out X _parameter3, out W _parameter4, out V _parameter5, out U _parameter6, out T _parameter7);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            parameter3 = _parameter3;
            parameter4 = _parameter4;
            parameter5 = _parameter5;
            parameter6 = _parameter6;
            parameter7 = _parameter7;

            return result;
        }

        public static bool TryGetParameters<Z, Y, X, W, V, U, T>(object parameter, out Z parameter1, out Y parameter2, out X parameter3, out W parameter4, out V parameter5, out U parameter6, out T parameter7)
        {
            if (parameter is CommandParameter)
            {
                parameter = ((CommandParameter)parameter).Value;
            }

            if (!(parameter is object[]))
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                return false;
            }

            object[] _parameter = (object[])parameter;

            if (_parameter.Length <= INDEX_V)
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                return false;
            }

            if (_parameter.Contains(DependencyProperty.UnsetValue) == true)
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                return false;
            }

            if (!(_parameter[INDEX_Z] is Z))
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                return false;
            }

            parameter1 = (Z)_parameter[INDEX_Z];

            if (!(_parameter[INDEX_Y] is Y))
            {
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                return false;
            }

            parameter2 = (Y)_parameter[INDEX_Y];

            if (!(_parameter[INDEX_X] is X))
            {
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                return false;
            }

            parameter3 = (X)_parameter[INDEX_X];

            if (!(_parameter[INDEX_W] is W))
            {
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                return false;
            }

            parameter4 = (W)_parameter[INDEX_W];

            if (!(_parameter[INDEX_V] is V))
            {
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                return false;
            }

            parameter5 = (V)_parameter[INDEX_V];

            if (!(_parameter[INDEX_U] is U))
            {
                parameter6 = default;
                parameter7 = default;
                return false;
            }

            parameter6 = (U)_parameter[INDEX_U];

            if (!(_parameter[INDEX_T] is T))
            {
                parameter7 = default;
                return false;
            }

            parameter7= (T)_parameter[INDEX_T];

            return true;
        }

    }
}
