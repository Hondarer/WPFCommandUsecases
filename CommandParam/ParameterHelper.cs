using System.Linq;
using System.Windows;

namespace CommandParam
{
    public static class ParameterHelper
    {
        private const int INDEX_T = 0;
        private const int INDEX_U = 1;
        private const int INDEX_V = 2;
        private const int INDEX_W = 3;
        private const int INDEX_X = 4;
        private const int INDEX_Y = 5;
        private const int INDEX_Z = 6;
        private const int INDEX_A = 7;
        private const int INDEX_B = 8;
        private const int INDEX_C = 9;
        private const int INDEX_D = 10;
        private const int INDEX_E = 11;
        private const int INDEX_F = 12;
        private const int INDEX_G = 13;
        private const int INDEX_H = 14;
        private const int INDEX_I = 15;

        public static bool TryGetParameters<T>(object[] parameter, out T parameter1)
        {
            bool result = TryGetParameters((object)parameter, out T _parameter1);
            parameter1 = _parameter1;
            return result;
        }

        public static bool TryGetParameters<T>(object parameter, out T parameter1)
        {
            if (parameter is CommandParameter)
            {
                parameter = ((CommandParameter)parameter).Value;
            }

            // パラメーターが 1 つの場合の特殊処理
            if (parameter is T)
            {
                parameter1 = (T)parameter;
                return true;
            }

            if (!(parameter is object[]))
            {
                parameter1 = default;
                return false;
            }

            object[] _parameter = (object[])parameter;

            if (_parameter.Length <= INDEX_T)
            {
                parameter1 = default;
                return false;
            }

            if (_parameter.Contains(DependencyProperty.UnsetValue) == true)
            {
                parameter1 = default;
                return false;
            }

            if (!(_parameter[INDEX_T] is T))
            {
                parameter1 = default;
                return false;
            }

            parameter1 = (T)_parameter[INDEX_T];

            return true;
        }

        public static bool TryGetParameters<T, U>(object[] parameter, out T parameter1, out U parameter2)
        {
            bool result = TryGetParameters((object)parameter, out T _parameter1, out U _parameter2);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            return result;
        }

        public static bool TryGetParameters<T, U>(object parameter, out T parameter1, out U parameter2)
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

            if (_parameter.Length <= INDEX_U)
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

            if (!(_parameter[INDEX_T] is T))
            {
                parameter1 = default;
                parameter2 = default;
                return false;
            }

            parameter1 = (T)_parameter[INDEX_T];

            if (!(_parameter[INDEX_U] is U))
            {
                parameter2 = default;
                return false;
            }

            parameter2 = (U)_parameter[INDEX_U];

            return true;
        }

        public static bool TryGetParameters<T, U, V>(object[] parameter, out T parameter1, out U parameter2, out V parameter3)
        {
            bool result = TryGetParameters((object)parameter, out T _parameter1, out U _parameter2, out V _parameter3);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            parameter3 = _parameter3;
            return result;
        }

        public static bool TryGetParameters<T, U, V>(object parameter, out T parameter1, out U parameter2, out V parameter3)
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

            if (_parameter.Length <= INDEX_V)
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

            if (!(_parameter[INDEX_T] is T))
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                return false;
            }

            parameter1 = (T)_parameter[INDEX_T];

            if (!(_parameter[INDEX_U] is U))
            {
                parameter2 = default;
                parameter3 = default;
                return false;
            }

            parameter2 = (U)_parameter[INDEX_U];

            if (!(_parameter[INDEX_V] is V))
            {
                parameter3 = default;
                return false;
            }

            parameter3 = (V)_parameter[INDEX_V];

            return true;
        }

        public static bool TryGetParameters<T, U, V, W>(object[] parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4)
        {
            bool result = TryGetParameters((object)parameter, out T _parameter1, out U _parameter2, out V _parameter3, out W _parameter4);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            parameter3 = _parameter3;
            parameter4 = _parameter4;
            return result;
        }

        public static bool TryGetParameters<T, U, V, W>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4)
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

            if (!(_parameter[INDEX_T] is T))
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                return false;
            }

            parameter1 = (T)_parameter[INDEX_T];

            if (!(_parameter[INDEX_U] is U))
            {
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                return false;
            }

            parameter2 = (U)_parameter[INDEX_U];

            if (!(_parameter[INDEX_V] is V))
            {
                parameter3 = default;
                parameter4 = default;
                return false;
            }

            parameter3 = (V)_parameter[INDEX_V];

            if (!(_parameter[INDEX_W] is W))
            {
                parameter4 = default;
                return false;
            }

            parameter4 = (W)_parameter[INDEX_W];

            return true;
        }

        public static bool TryGetParameters<T, U, V, W, X>(object[] parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5)
        {
            bool result = TryGetParameters((object)parameter, out T _parameter1, out U _parameter2, out V _parameter3, out W _parameter4, out X _parameter5);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            parameter3 = _parameter3;
            parameter4 = _parameter4;
            parameter5 = _parameter5;
            return result;
        }

        public static bool TryGetParameters<T, U, V, W, X>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5)
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

            if (_parameter.Length <= INDEX_X)
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

            if (!(_parameter[INDEX_T] is T))
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                return false;
            }

            parameter1 = (T)_parameter[INDEX_T];

            if (!(_parameter[INDEX_U] is U))
            {
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                return false;
            }

            parameter2 = (U)_parameter[INDEX_U];

            if (!(_parameter[INDEX_V] is V))
            {
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                return false;
            }

            parameter3 = (V)_parameter[INDEX_V];

            if (!(_parameter[INDEX_W] is W))
            {
                parameter4 = default;
                parameter5 = default;
                return false;
            }

            parameter4 = (W)_parameter[INDEX_W];

            if (!(_parameter[INDEX_X] is X))
            {
                parameter5 = default;
                return false;
            }

            parameter5 = (X)_parameter[INDEX_X];

            return true;
        }

        public static bool TryGetParameters<T, U, V, W, X, Y>(object[] parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6)
        {
            bool result = TryGetParameters((object)parameter, out T _parameter1, out U _parameter2, out V _parameter3, out W _parameter4, out X _parameter5, out Y _parameter6);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            parameter3 = _parameter3;
            parameter4 = _parameter4;
            parameter5 = _parameter5;
            parameter6 = _parameter6;

            return result;
        }

        public static bool TryGetParameters<T, U, V, W, X, Y>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6)
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

            if (_parameter.Length <= INDEX_Y)
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

            if (!(_parameter[INDEX_T] is T))
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                return false;
            }

            parameter1 = (T)_parameter[INDEX_T];

            if (!(_parameter[INDEX_U] is U))
            {
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                return false;
            }

            parameter2 = (U)_parameter[INDEX_U];

            if (!(_parameter[INDEX_V] is V))
            {
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                return false;
            }

            parameter3 = (V)_parameter[INDEX_V];

            if (!(_parameter[INDEX_W] is W))
            {
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                return false;
            }

            parameter4 = (W)_parameter[INDEX_W];

            if (!(_parameter[INDEX_X] is X))
            {
                parameter5 = default;
                parameter6 = default;
                return false;
            }

            parameter5 = (X)_parameter[INDEX_X];

            if (!(_parameter[INDEX_Y] is Y))
            {
                parameter6 = default;
                return false;
            }

            parameter6 = (Y)_parameter[INDEX_Y];

            return true;
        }

        public static bool TryGetParameters<T, U, V, W, X, Y, Z>(object[] parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7)
        {
            bool result = TryGetParameters((object)parameter, out T _parameter1, out U _parameter2, out V _parameter3, out W _parameter4, out X _parameter5, out Y _parameter6, out Z _parameter7);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            parameter3 = _parameter3;
            parameter4 = _parameter4;
            parameter5 = _parameter5;
            parameter6 = _parameter6;
            parameter7 = _parameter7;

            return result;
        }

        public static bool TryGetParameters<T, U, V, W, X, Y, Z>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7)
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

            if (_parameter.Length <= INDEX_Z)
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

            if (!(_parameter[INDEX_T] is T))
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

            parameter1 = (T)_parameter[INDEX_T];

            if (!(_parameter[INDEX_U] is U))
            {
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                return false;
            }

            parameter2 = (U)_parameter[INDEX_U];

            if (!(_parameter[INDEX_V] is V))
            {
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                return false;
            }

            parameter3 = (V)_parameter[INDEX_V];

            if (!(_parameter[INDEX_W] is W))
            {
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                return false;
            }

            parameter4 = (W)_parameter[INDEX_W];

            if (!(_parameter[INDEX_X] is X))
            {
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                return false;
            }

            parameter5 = (X)_parameter[INDEX_X];

            if (!(_parameter[INDEX_Y] is Y))
            {
                parameter6 = default;
                parameter7 = default;
                return false;
            }

            parameter6 = (Y)_parameter[INDEX_Y];

            if (!(_parameter[INDEX_Z] is Z))
            {
                parameter7 = default;
                return false;
            }

            parameter7= (Z)_parameter[INDEX_Z];

            return true;
        }

        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A>(object[] parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8)
        {
            bool result = TryGetParameters((object)parameter, out T _parameter1, out U _parameter2, out V _parameter3, out W _parameter4, out X _parameter5, out Y _parameter6, out Z _parameter7, out A _parameter8);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            parameter3 = _parameter3;
            parameter4 = _parameter4;
            parameter5 = _parameter5;
            parameter6 = _parameter6;
            parameter7 = _parameter7;
            parameter8 = _parameter8;

            return result;
        }

        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8)
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
                parameter8 = default;
                return false;
            }

            object[] _parameter = (object[])parameter;

            if (_parameter.Length <= INDEX_A)
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
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
                parameter8 = default;
                return false;
            }

            if (!(_parameter[INDEX_T] is T))
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                return false;
            }

            parameter1 = (T)_parameter[INDEX_T];

            if (!(_parameter[INDEX_U] is U))
            {
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                return false;
            }

            parameter2 = (U)_parameter[INDEX_U];

            if (!(_parameter[INDEX_V] is V))
            {
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                return false;
            }

            parameter3 = (V)_parameter[INDEX_V];

            if (!(_parameter[INDEX_W] is W))
            {
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                return false;
            }

            parameter4 = (W)_parameter[INDEX_W];

            if (!(_parameter[INDEX_X] is X))
            {
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                return false;
            }

            parameter5 = (X)_parameter[INDEX_X];

            if (!(_parameter[INDEX_Y] is Y))
            {
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                return false;
            }

            parameter6 = (Y)_parameter[INDEX_Y];

            if (!(_parameter[INDEX_Z] is Z))
            {
                parameter7 = default;
                parameter8 = default;
                return false;
            }

            parameter7 = (Z)_parameter[INDEX_Z];

            if (!(_parameter[INDEX_A] is A))
            {
                parameter8 = default;
                return false;
            }

            parameter8 = (A)_parameter[INDEX_A];

            return true;
        }

        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B>(object[] parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9)
        {
            bool result = TryGetParameters((object)parameter, out T _parameter1, out U _parameter2, out V _parameter3, out W _parameter4, out X _parameter5, out Y _parameter6, out Z _parameter7, out A _parameter8, out B _parameter9);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            parameter3 = _parameter3;
            parameter4 = _parameter4;
            parameter5 = _parameter5;
            parameter6 = _parameter6;
            parameter7 = _parameter7;
            parameter8 = _parameter8;
            parameter9 = _parameter9;

            return result;
        }

        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9)
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
                parameter8 = default;
                parameter9 = default;
                return false;
            }

            object[] _parameter = (object[])parameter;

            if (_parameter.Length <= INDEX_B)
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
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
                parameter8 = default;
                parameter9 = default;
                return false;
            }

            if (!(_parameter[INDEX_T] is T))
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                return false;
            }

            parameter1 = (T)_parameter[INDEX_T];

            if (!(_parameter[INDEX_U] is U))
            {
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                return false;
            }

            parameter2 = (U)_parameter[INDEX_U];

            if (!(_parameter[INDEX_V] is V))
            {
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                return false;
            }

            parameter3 = (V)_parameter[INDEX_V];

            if (!(_parameter[INDEX_W] is W))
            {
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                return false;
            }

            parameter4 = (W)_parameter[INDEX_W];

            if (!(_parameter[INDEX_X] is X))
            {
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                return false;
            }

            parameter5 = (X)_parameter[INDEX_X];

            if (!(_parameter[INDEX_Y] is Y))
            {
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                return false;
            }

            parameter6 = (Y)_parameter[INDEX_Y];

            if (!(_parameter[INDEX_Z] is Z))
            {
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                return false;
            }

            parameter7 = (Z)_parameter[INDEX_Z];

            if (!(_parameter[INDEX_A] is A))
            {
                parameter8 = default;
                parameter9 = default;
                return false;
            }

            parameter8 = (A)_parameter[INDEX_A];

            if (!(_parameter[INDEX_B] is B))
            {
                parameter9 = default;
                return false;
            }

            parameter9 = (B)_parameter[INDEX_B];

            return true;
        }

        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B, C>(object[] parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9, out C parameter10)
        {
            bool result = TryGetParameters((object)parameter, out T _parameter1, out U _parameter2, out V _parameter3, out W _parameter4, out X _parameter5, out Y _parameter6, out Z _parameter7, out A _parameter8, out B _parameter9, out C _parameter10);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            parameter3 = _parameter3;
            parameter4 = _parameter4;
            parameter5 = _parameter5;
            parameter6 = _parameter6;
            parameter7 = _parameter7;
            parameter8 = _parameter8;
            parameter9 = _parameter9;
            parameter10 = _parameter10;

            return result;
        }

        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B, C>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9, out C parameter10)
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
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                return false;
            }

            object[] _parameter = (object[])parameter;

            if (_parameter.Length <= INDEX_C)
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
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
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                return false;
            }

            if (!(_parameter[INDEX_T] is T))
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                return false;
            }

            parameter1 = (T)_parameter[INDEX_T];

            if (!(_parameter[INDEX_U] is U))
            {
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                return false;
            }

            parameter2 = (U)_parameter[INDEX_U];

            if (!(_parameter[INDEX_V] is V))
            {
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                return false;
            }

            parameter3 = (V)_parameter[INDEX_V];

            if (!(_parameter[INDEX_W] is W))
            {
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                return false;
            }

            parameter4 = (W)_parameter[INDEX_W];

            if (!(_parameter[INDEX_X] is X))
            {
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                return false;
            }

            parameter5 = (X)_parameter[INDEX_X];

            if (!(_parameter[INDEX_Y] is Y))
            {
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                return false;
            }

            parameter6 = (Y)_parameter[INDEX_Y];

            if (!(_parameter[INDEX_Z] is Z))
            {
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                return false;
            }

            parameter7 = (Z)_parameter[INDEX_Z];

            if (!(_parameter[INDEX_A] is A))
            {
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                return false;
            }

            parameter8 = (A)_parameter[INDEX_A];

            if (!(_parameter[INDEX_B] is B))
            {
                parameter9 = default;
                parameter10 = default;
                return false;
            }

            parameter9 = (B)_parameter[INDEX_B];

            if (!(_parameter[INDEX_C] is C))
            {
                parameter10 = default;
                return false;
            }

            parameter10 = (C)_parameter[INDEX_C];

            return true;
        }

        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B, C, D>(object[] parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9, out C parameter10, out D parameter11)
        {
            bool result = TryGetParameters((object)parameter, out T _parameter1, out U _parameter2, out V _parameter3, out W _parameter4, out X _parameter5, out Y _parameter6, out Z _parameter7, out A _parameter8, out B _parameter9, out C _parameter10, out D _parameter11);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            parameter3 = _parameter3;
            parameter4 = _parameter4;
            parameter5 = _parameter5;
            parameter6 = _parameter6;
            parameter7 = _parameter7;
            parameter8 = _parameter8;
            parameter9 = _parameter9;
            parameter10 = _parameter10;
            parameter11 = _parameter11;

            return result;
        }

        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B, C, D>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9, out C parameter10, out D parameter11)
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
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                return false;
            }

            object[] _parameter = (object[])parameter;

            if (_parameter.Length <= INDEX_D)
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
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
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                return false;
            }

            if (!(_parameter[INDEX_T] is T))
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                return false;
            }

            parameter1 = (T)_parameter[INDEX_T];

            if (!(_parameter[INDEX_U] is U))
            {
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                return false;
            }

            parameter2 = (U)_parameter[INDEX_U];

            if (!(_parameter[INDEX_V] is V))
            {
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                return false;
            }

            parameter3 = (V)_parameter[INDEX_V];

            if (!(_parameter[INDEX_W] is W))
            {
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                return false;
            }

            parameter4 = (W)_parameter[INDEX_W];

            if (!(_parameter[INDEX_X] is X))
            {
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                return false;
            }

            parameter5 = (X)_parameter[INDEX_X];

            if (!(_parameter[INDEX_Y] is Y))
            {
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                return false;
            }

            parameter6 = (Y)_parameter[INDEX_Y];

            if (!(_parameter[INDEX_Z] is Z))
            {
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                return false;
            }

            parameter7 = (Z)_parameter[INDEX_Z];

            if (!(_parameter[INDEX_A] is A))
            {
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                return false;
            }

            parameter8 = (A)_parameter[INDEX_A];

            if (!(_parameter[INDEX_B] is B))
            {
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                return false;
            }

            parameter9 = (B)_parameter[INDEX_B];

            if (!(_parameter[INDEX_C] is C))
            {
                parameter10 = default;
                parameter11 = default;
                return false;
            }

            parameter10 = (C)_parameter[INDEX_C];

            if (!(_parameter[INDEX_D] is D))
            {
                parameter11 = default;
                return false;
            }

            parameter11 = (D)_parameter[INDEX_D];

            return true;
        }

        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B, C, D, E>(object[] parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9, out C parameter10, out D parameter11, out E parameter12)
        {
            bool result = TryGetParameters((object)parameter, out T _parameter1, out U _parameter2, out V _parameter3, out W _parameter4, out X _parameter5, out Y _parameter6, out Z _parameter7, out A _parameter8, out B _parameter9, out C _parameter10, out D _parameter11, out E _parameter12);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            parameter3 = _parameter3;
            parameter4 = _parameter4;
            parameter5 = _parameter5;
            parameter6 = _parameter6;
            parameter7 = _parameter7;
            parameter8 = _parameter8;
            parameter9 = _parameter9;
            parameter10 = _parameter10;
            parameter11 = _parameter11;
            parameter12 = _parameter12;

            return result;
        }

        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B, C, D, E>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9, out C parameter10, out D parameter11, out E parameter12)
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
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                return false;
            }

            object[] _parameter = (object[])parameter;

            if (_parameter.Length <= INDEX_E)
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
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
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                return false;
            }

            if (!(_parameter[INDEX_T] is T))
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                return false;
            }

            parameter1 = (T)_parameter[INDEX_T];

            if (!(_parameter[INDEX_U] is U))
            {
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                return false;
            }

            parameter2 = (U)_parameter[INDEX_U];

            if (!(_parameter[INDEX_V] is V))
            {
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                return false;
            }

            parameter3 = (V)_parameter[INDEX_V];

            if (!(_parameter[INDEX_W] is W))
            {
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                return false;
            }

            parameter4 = (W)_parameter[INDEX_W];

            if (!(_parameter[INDEX_X] is X))
            {
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                return false;
            }

            parameter5 = (X)_parameter[INDEX_X];

            if (!(_parameter[INDEX_Y] is Y))
            {
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                return false;
            }

            parameter6 = (Y)_parameter[INDEX_Y];

            if (!(_parameter[INDEX_Z] is Z))
            {
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                return false;
            }

            parameter7 = (Z)_parameter[INDEX_Z];

            if (!(_parameter[INDEX_A] is A))
            {
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                return false;
            }

            parameter8 = (A)_parameter[INDEX_A];

            if (!(_parameter[INDEX_B] is B))
            {
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                return false;
            }

            parameter9 = (B)_parameter[INDEX_B];

            if (!(_parameter[INDEX_C] is C))
            {
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                return false;
            }

            parameter10 = (C)_parameter[INDEX_C];

            if (!(_parameter[INDEX_D] is D))
            {
                parameter11 = default;
                parameter12 = default;
                return false;
            }

            parameter11 = (D)_parameter[INDEX_D];

            if (!(_parameter[INDEX_E] is E))
            {
                parameter12 = default;
                return false;
            }

            parameter12 = (E)_parameter[INDEX_E];

            return true;
        }

        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B, C, D, E, F>(object[] parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9, out C parameter10, out D parameter11, out E parameter12, out F parameter13)
        {
            bool result = TryGetParameters((object)parameter, out T _parameter1, out U _parameter2, out V _parameter3, out W _parameter4, out X _parameter5, out Y _parameter6, out Z _parameter7, out A _parameter8, out B _parameter9, out C _parameter10, out D _parameter11, out E _parameter12, out F _parameter13);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            parameter3 = _parameter3;
            parameter4 = _parameter4;
            parameter5 = _parameter5;
            parameter6 = _parameter6;
            parameter7 = _parameter7;
            parameter8 = _parameter8;
            parameter9 = _parameter9;
            parameter10 = _parameter10;
            parameter11 = _parameter11;
            parameter12 = _parameter12;
            parameter13 = _parameter13;

            return result;
        }

        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B, C, D, E, F>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9, out C parameter10, out D parameter11, out E parameter12, out F parameter13)
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
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                return false;
            }

            object[] _parameter = (object[])parameter;

            if (_parameter.Length <= INDEX_F)
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
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
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                return false;
            }

            if (!(_parameter[INDEX_T] is T))
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                return false;
            }

            parameter1 = (T)_parameter[INDEX_T];

            if (!(_parameter[INDEX_U] is U))
            {
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                return false;
            }

            parameter2 = (U)_parameter[INDEX_U];

            if (!(_parameter[INDEX_V] is V))
            {
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                return false;
            }

            parameter3 = (V)_parameter[INDEX_V];

            if (!(_parameter[INDEX_W] is W))
            {
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                return false;
            }

            parameter4 = (W)_parameter[INDEX_W];

            if (!(_parameter[INDEX_X] is X))
            {
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                return false;
            }

            parameter5 = (X)_parameter[INDEX_X];

            if (!(_parameter[INDEX_Y] is Y))
            {
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                return false;
            }

            parameter6 = (Y)_parameter[INDEX_Y];

            if (!(_parameter[INDEX_Z] is Z))
            {
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                return false;
            }

            parameter7 = (Z)_parameter[INDEX_Z];

            if (!(_parameter[INDEX_A] is A))
            {
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                return false;
            }

            parameter8 = (A)_parameter[INDEX_A];

            if (!(_parameter[INDEX_B] is B))
            {
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                return false;
            }

            parameter9 = (B)_parameter[INDEX_B];

            if (!(_parameter[INDEX_C] is C))
            {
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                return false;
            }

            parameter10 = (C)_parameter[INDEX_C];

            if (!(_parameter[INDEX_D] is D))
            {
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                return false;
            }

            parameter11 = (D)_parameter[INDEX_D];

            if (!(_parameter[INDEX_E] is E))
            {
                parameter12 = default;
                parameter13 = default;
                return false;
            }

            parameter12 = (E)_parameter[INDEX_E];

            if (!(_parameter[INDEX_F] is F))
            {
                parameter13 = default;
                return false;
            }

            parameter13 = (F)_parameter[INDEX_F];

            return true;
        }

        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B, C, D, E, F, G>(object[] parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9, out C parameter10, out D parameter11, out E parameter12, out F parameter13, out G parameter14)
        {
            bool result = TryGetParameters((object)parameter, out T _parameter1, out U _parameter2, out V _parameter3, out W _parameter4, out X _parameter5, out Y _parameter6, out Z _parameter7, out A _parameter8, out B _parameter9, out C _parameter10, out D _parameter11, out E _parameter12, out F _parameter13, out G _parameter14);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            parameter3 = _parameter3;
            parameter4 = _parameter4;
            parameter5 = _parameter5;
            parameter6 = _parameter6;
            parameter7 = _parameter7;
            parameter8 = _parameter8;
            parameter9 = _parameter9;
            parameter10 = _parameter10;
            parameter11 = _parameter11;
            parameter12 = _parameter12;
            parameter13 = _parameter13;
            parameter14 = _parameter14;

            return result;
        }

        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B, C, D, E, F, G>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9, out C parameter10, out D parameter11, out E parameter12, out F parameter13, out G parameter14)
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
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                return false;
            }

            object[] _parameter = (object[])parameter;

            if (_parameter.Length <= INDEX_G)
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
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
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                return false;
            }

            if (!(_parameter[INDEX_T] is T))
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                return false;
            }

            parameter1 = (T)_parameter[INDEX_T];

            if (!(_parameter[INDEX_U] is U))
            {
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                return false;
            }

            parameter2 = (U)_parameter[INDEX_U];

            if (!(_parameter[INDEX_V] is V))
            {
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                return false;
            }

            parameter3 = (V)_parameter[INDEX_V];

            if (!(_parameter[INDEX_W] is W))
            {
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                return false;
            }

            parameter4 = (W)_parameter[INDEX_W];

            if (!(_parameter[INDEX_X] is X))
            {
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                return false;
            }

            parameter5 = (X)_parameter[INDEX_X];

            if (!(_parameter[INDEX_Y] is Y))
            {
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                return false;
            }

            parameter6 = (Y)_parameter[INDEX_Y];

            if (!(_parameter[INDEX_Z] is Z))
            {
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                return false;
            }

            parameter7 = (Z)_parameter[INDEX_Z];

            if (!(_parameter[INDEX_A] is A))
            {
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                return false;
            }

            parameter8 = (A)_parameter[INDEX_A];

            if (!(_parameter[INDEX_B] is B))
            {
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                return false;
            }

            parameter9 = (B)_parameter[INDEX_B];

            if (!(_parameter[INDEX_C] is C))
            {
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                return false;
            }

            parameter10 = (C)_parameter[INDEX_C];

            if (!(_parameter[INDEX_D] is D))
            {
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                return false;
            }

            parameter11 = (D)_parameter[INDEX_D];

            if (!(_parameter[INDEX_E] is E))
            {
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                return false;
            }

            parameter12 = (E)_parameter[INDEX_E];

            if (!(_parameter[INDEX_F] is F))
            {
                parameter13 = default;
                parameter14 = default;
                return false;
            }

            parameter13 = (F)_parameter[INDEX_F];

            if (!(_parameter[INDEX_G] is G))
            {
                parameter14 = default;
                return false;
            }

            parameter14 = (G)_parameter[INDEX_G];

            return true;
        }

        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B, C, D, E, F, G, H>(object[] parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9, out C parameter10, out D parameter11, out E parameter12, out F parameter13, out G parameter14, out H parameter15)
        {
            bool result = TryGetParameters((object)parameter, out T _parameter1, out U _parameter2, out V _parameter3, out W _parameter4, out X _parameter5, out Y _parameter6, out Z _parameter7, out A _parameter8, out B _parameter9, out C _parameter10, out D _parameter11, out E _parameter12, out F _parameter13, out G _parameter14, out H _parameter15);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            parameter3 = _parameter3;
            parameter4 = _parameter4;
            parameter5 = _parameter5;
            parameter6 = _parameter6;
            parameter7 = _parameter7;
            parameter8 = _parameter8;
            parameter9 = _parameter9;
            parameter10 = _parameter10;
            parameter11 = _parameter11;
            parameter12 = _parameter12;
            parameter13 = _parameter13;
            parameter14 = _parameter14;
            parameter15 = _parameter15;

            return result;
        }

        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B, C, D, E, F, G, H>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9, out C parameter10, out D parameter11, out E parameter12, out F parameter13, out G parameter14, out H parameter15)
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
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                return false;
            }

            object[] _parameter = (object[])parameter;

            if (_parameter.Length <= INDEX_H)
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
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
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                return false;
            }

            if (!(_parameter[INDEX_T] is T))
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                return false;
            }

            parameter1 = (T)_parameter[INDEX_T];

            if (!(_parameter[INDEX_U] is U))
            {
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                return false;
            }

            parameter2 = (U)_parameter[INDEX_U];

            if (!(_parameter[INDEX_V] is V))
            {
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                return false;
            }

            parameter3 = (V)_parameter[INDEX_V];

            if (!(_parameter[INDEX_W] is W))
            {
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                return false;
            }

            parameter4 = (W)_parameter[INDEX_W];

            if (!(_parameter[INDEX_X] is X))
            {
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                return false;
            }

            parameter5 = (X)_parameter[INDEX_X];

            if (!(_parameter[INDEX_Y] is Y))
            {
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                return false;
            }

            parameter6 = (Y)_parameter[INDEX_Y];

            if (!(_parameter[INDEX_Z] is Z))
            {
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                return false;
            }

            parameter7 = (Z)_parameter[INDEX_Z];

            if (!(_parameter[INDEX_A] is A))
            {
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                return false;
            }

            parameter8 = (A)_parameter[INDEX_A];

            if (!(_parameter[INDEX_B] is B))
            {
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                return false;
            }

            parameter9 = (B)_parameter[INDEX_B];

            if (!(_parameter[INDEX_C] is C))
            {
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                return false;
            }

            parameter10 = (C)_parameter[INDEX_C];

            if (!(_parameter[INDEX_D] is D))
            {
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                return false;
            }

            parameter11 = (D)_parameter[INDEX_D];

            if (!(_parameter[INDEX_E] is E))
            {
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                return false;
            }

            parameter12 = (E)_parameter[INDEX_E];

            if (!(_parameter[INDEX_F] is F))
            {
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                return false;
            }

            parameter13 = (F)_parameter[INDEX_F];

            if (!(_parameter[INDEX_G] is G))
            {
                parameter14 = default;
                parameter15 = default;
                return false;
            }

            parameter14 = (G)_parameter[INDEX_G];

            if (!(_parameter[INDEX_H] is H))
            {
                parameter15 = default;
                return false;
            }

            parameter15 = (H)_parameter[INDEX_H];

            return true;
        }

        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B, C, D, E, F, G, H, I>(object[] parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9, out C parameter10, out D parameter11, out E parameter12, out F parameter13, out G parameter14, out H parameter15, out I parameter16)
        {
            bool result = TryGetParameters((object)parameter, out T _parameter1, out U _parameter2, out V _parameter3, out W _parameter4, out X _parameter5, out Y _parameter6, out Z _parameter7, out A _parameter8, out B _parameter9, out C _parameter10, out D _parameter11, out E _parameter12, out F _parameter13, out G _parameter14, out H _parameter15, out I _parameter16);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            parameter3 = _parameter3;
            parameter4 = _parameter4;
            parameter5 = _parameter5;
            parameter6 = _parameter6;
            parameter7 = _parameter7;
            parameter8 = _parameter8;
            parameter9 = _parameter9;
            parameter10 = _parameter10;
            parameter11 = _parameter11;
            parameter12 = _parameter12;
            parameter13 = _parameter13;
            parameter14 = _parameter14;
            parameter15 = _parameter15;
            parameter16 = _parameter16;

            return result;
        }

        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B, C, D, E, F, G, H, I>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9, out C parameter10, out D parameter11, out E parameter12, out F parameter13, out G parameter14, out H parameter15, out I parameter16)
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
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                parameter16 = default;
                return false;
            }

            object[] _parameter = (object[])parameter;

            if (_parameter.Length <= INDEX_I)
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                parameter16 = default;
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
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                parameter16 = default;
                return false;
            }

            if (!(_parameter[INDEX_T] is T))
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                parameter16 = default;
                return false;
            }

            parameter1 = (T)_parameter[INDEX_T];

            if (!(_parameter[INDEX_U] is U))
            {
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                parameter16 = default;
                return false;
            }

            parameter2 = (U)_parameter[INDEX_U];

            if (!(_parameter[INDEX_V] is V))
            {
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                parameter16 = default;
                return false;
            }

            parameter3 = (V)_parameter[INDEX_V];

            if (!(_parameter[INDEX_W] is W))
            {
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                parameter16 = default;
                return false;
            }

            parameter4 = (W)_parameter[INDEX_W];

            if (!(_parameter[INDEX_X] is X))
            {
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                parameter16 = default;
                return false;
            }

            parameter5 = (X)_parameter[INDEX_X];

            if (!(_parameter[INDEX_Y] is Y))
            {
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                parameter16 = default;
                return false;
            }

            parameter6 = (Y)_parameter[INDEX_Y];

            if (!(_parameter[INDEX_Z] is Z))
            {
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                parameter16 = default;
                return false;
            }

            parameter7 = (Z)_parameter[INDEX_Z];

            if (!(_parameter[INDEX_A] is A))
            {
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                parameter16 = default;
                return false;
            }

            parameter8 = (A)_parameter[INDEX_A];

            if (!(_parameter[INDEX_B] is B))
            {
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                parameter16 = default;
                return false;
            }

            parameter9 = (B)_parameter[INDEX_B];

            if (!(_parameter[INDEX_C] is C))
            {
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                parameter16 = default;
                return false;
            }

            parameter10 = (C)_parameter[INDEX_C];

            if (!(_parameter[INDEX_D] is D))
            {
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                parameter16 = default;
                return false;
            }

            parameter11 = (D)_parameter[INDEX_D];

            if (!(_parameter[INDEX_E] is E))
            {
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                parameter16 = default;
                return false;
            }

            parameter12 = (E)_parameter[INDEX_E];

            if (!(_parameter[INDEX_F] is F))
            {
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                parameter16 = default;
                return false;
            }

            parameter13 = (F)_parameter[INDEX_F];

            if (!(_parameter[INDEX_G] is G))
            {
                parameter14 = default;
                parameter15 = default;
                parameter16 = default;
                return false;
            }

            parameter14 = (G)_parameter[INDEX_G];

            if (!(_parameter[INDEX_H] is H))
            {
                parameter15 = default;
                parameter16 = default;
                return false;
            }

            parameter15 = (H)_parameter[INDEX_H];

            if (!(_parameter[INDEX_I] is I))
            {
                parameter16 = default;
                return false;
            }

            parameter16 = (I)_parameter[INDEX_I];

            return true;
        }
    }
}
