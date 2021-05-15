using System.Linq;
using System.Windows;

namespace CommandParam
{
    /// <summary>
    /// オブジェクト配列からのパラメーター取り出し支援機能を提供します。
    /// </summary>
    public static class ParameterHelper
    {
        #region 定数

        /// <summary>
        /// 型引数 T のインデックスを表します。
        /// </summary>
        private const int INDEX_T = 0;

        /// <summary>
        /// 型引数 U のインデックスを表します。
        /// </summary>
        private const int INDEX_U = 1;

        /// <summary>
        /// 型引数 V のインデックスを表します。
        /// </summary>
        private const int INDEX_V = 2;

        /// <summary>
        /// 型引数 W のインデックスを表します。
        /// </summary>
        private const int INDEX_W = 3;

        /// <summary>
        /// 型引数 X のインデックスを表します。
        /// </summary>
        private const int INDEX_X = 4;

        /// <summary>
        /// 型引数 Y のインデックスを表します。
        /// </summary>
        private const int INDEX_Y = 5;

        /// <summary>
        /// 型引数 Z のインデックスを表します。
        /// </summary>
        private const int INDEX_Z = 6;

        /// <summary>
        /// 型引数 A のインデックスを表します。
        /// </summary>
        private const int INDEX_A = 7;

        /// <summary>
        /// 型引数 B のインデックスを表します。
        /// </summary>
        private const int INDEX_B = 8;

        /// <summary>
        /// 型引数 C のインデックスを表します。
        /// </summary>
        private const int INDEX_C = 9;

        /// <summary>
        /// 型引数 D のインデックスを表します。
        /// </summary>
        private const int INDEX_D = 10;

        /// <summary>
        /// 型引数 E のインデックスを表します。
        /// </summary>
        private const int INDEX_E = 11;

        /// <summary>
        /// 型引数 F のインデックスを表します。
        /// </summary>
        private const int INDEX_F = 12;

        /// <summary>
        /// 型引数 G のインデックスを表します。
        /// </summary>
        private const int INDEX_G = 13;

        /// <summary>
        /// 型引数 H のインデックスを表します。
        /// </summary>
        private const int INDEX_H = 14;

        /// <summary>
        /// 型引数 I のインデックスを表します。
        /// </summary>
        private const int INDEX_I = 15;

        #endregion

        /// <summary>
        /// オブジェクト配列からパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <param name="parameter">オブジェクト配列。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
        public static bool TryGetParameters<T>(object[] parameter, out T parameter1)
        {
            bool result = TryGetParameters((object)parameter, out T _parameter1);
            parameter1 = _parameter1;
            return result;
        }

        /// <summary>
        /// オブジェクトからパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <param name="parameter">オブジェクト。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
        public static bool TryGetParameters<T>(object parameter, out T parameter1)
        {
            // 汎用コマンドパラメーターの場合は値を取り出す
            if (parameter is CommandParameter commandParameter)
            {
                parameter = commandParameter.Value;
            }

            // パラメーターが単一オブジェクトの場合
            if (parameter is T t)
            {
                parameter1 = t;
                return true;
            }

            if ((parameter is object[]) == false)
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

            if ((_parameter[INDEX_T] is T) == false)
            {
                parameter1 = default;
                return false;
            }

            parameter1 = (T)_parameter[INDEX_T];

            return true;
        }

        /// <summary>
        /// オブジェクト配列からパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <param name="parameter">オブジェクト配列。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
        public static bool TryGetParameters<T, U>(object[] parameter, out T parameter1, out U parameter2)
        {
            bool result = TryGetParameters((object)parameter, out T _parameter1, out U _parameter2);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            return result;
        }

        /// <summary>
        /// オブジェクトからパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <param name="parameter">オブジェクト。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
        public static bool TryGetParameters<T, U>(object parameter, out T parameter1, out U parameter2)
        {
            // 汎用コマンドパラメーターの場合は値を取り出す
            if (parameter is CommandParameter commandParameter)
            {
                parameter = commandParameter.Value;
            }

            if ((parameter is object[]) == false)
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

            if ((_parameter[INDEX_T] is T) == false)
            {
                parameter1 = default;
                parameter2 = default;
                return false;
            }

            parameter1 = (T)_parameter[INDEX_T];

            if ((_parameter[INDEX_U] is U) == false)
            {
                parameter2 = default;
                return false;
            }

            parameter2 = (U)_parameter[INDEX_U];

            return true;
        }

        /// <summary>
        /// オブジェクト配列からパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <param name="parameter">オブジェクト配列。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
        public static bool TryGetParameters<T, U, V>(object[] parameter, out T parameter1, out U parameter2, out V parameter3)
        {
            bool result = TryGetParameters((object)parameter, out T _parameter1, out U _parameter2, out V _parameter3);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            parameter3 = _parameter3;
            return result;
        }

        /// <summary>
        /// オブジェクトからパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <param name="parameter">オブジェクト。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
        public static bool TryGetParameters<T, U, V>(object parameter, out T parameter1, out U parameter2, out V parameter3)
        {
            // 汎用コマンドパラメーターの場合は値を取り出す
            if (parameter is CommandParameter commandParameter)
            {
                parameter = commandParameter.Value;
            }

            if ((parameter is object[]) == false)
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

            if ((_parameter[INDEX_T] is T) == false)
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                return false;
            }

            parameter1 = (T)_parameter[INDEX_T];

            if ((_parameter[INDEX_U] is U) == false)
            {
                parameter2 = default;
                parameter3 = default;
                return false;
            }

            parameter2 = (U)_parameter[INDEX_U];

            if ((_parameter[INDEX_V] is V) == false)
            {
                parameter3 = default;
                return false;
            }

            parameter3 = (V)_parameter[INDEX_V];

            return true;
        }

        /// <summary>
        /// オブジェクト配列からパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <param name="parameter">オブジェクト配列。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
        public static bool TryGetParameters<T, U, V, W>(object[] parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4)
        {
            bool result = TryGetParameters((object)parameter, out T _parameter1, out U _parameter2, out V _parameter3, out W _parameter4);
            parameter1 = _parameter1;
            parameter2 = _parameter2;
            parameter3 = _parameter3;
            parameter4 = _parameter4;
            return result;
        }

        /// <summary>
        /// オブジェクトからパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <param name="parameter">オブジェクト。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
        public static bool TryGetParameters<T, U, V, W>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4)
        {
            // 汎用コマンドパラメーターの場合は値を取り出す
            if (parameter is CommandParameter commandParameter)
            {
                parameter = commandParameter.Value;
            }

            if ((parameter is object[]) == false)
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

            if ((_parameter[INDEX_T] is T) == false)
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                return false;
            }

            parameter1 = (T)_parameter[INDEX_T];

            if ((_parameter[INDEX_U] is U) == false)
            {
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                return false;
            }

            parameter2 = (U)_parameter[INDEX_U];

            if ((_parameter[INDEX_V] is V) == false)
            {
                parameter3 = default;
                parameter4 = default;
                return false;
            }

            parameter3 = (V)_parameter[INDEX_V];

            if ((_parameter[INDEX_W] is W) == false)
            {
                parameter4 = default;
                return false;
            }

            parameter4 = (W)_parameter[INDEX_W];

            return true;
        }

        /// <summary>
        /// オブジェクト配列からパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <param name="parameter">オブジェクト配列。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
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

        /// <summary>
        /// オブジェクトからパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <param name="parameter">オブジェクト。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
        public static bool TryGetParameters<T, U, V, W, X>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5)
        {
            // 汎用コマンドパラメーターの場合は値を取り出す
            if (parameter is CommandParameter commandParameter)
            {
                parameter = commandParameter.Value;
            }

            if ((parameter is object[]) == false)
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

            if ((_parameter[INDEX_T] is T) == false)
            {
                parameter1 = default;
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                return false;
            }

            parameter1 = (T)_parameter[INDEX_T];

            if ((_parameter[INDEX_U] is U) == false)
            {
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                return false;
            }

            parameter2 = (U)_parameter[INDEX_U];

            if ((_parameter[INDEX_V] is V) == false)
            {
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                return false;
            }

            parameter3 = (V)_parameter[INDEX_V];

            if ((_parameter[INDEX_W] is W) == false)
            {
                parameter4 = default;
                parameter5 = default;
                return false;
            }

            parameter4 = (W)_parameter[INDEX_W];

            if ((_parameter[INDEX_X] is X) == false)
            {
                parameter5 = default;
                return false;
            }

            parameter5 = (X)_parameter[INDEX_X];

            return true;
        }

        /// <summary>
        /// オブジェクト配列からパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <typeparam name="Y">パラメーター 6 の型。</typeparam>
        /// <param name="parameter">オブジェクト配列。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <param name="parameter6">パラメーター 6。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
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

        /// <summary>
        /// オブジェクトからパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <typeparam name="Y">パラメーター 6 の型。</typeparam>
        /// <param name="parameter">オブジェクト。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <param name="parameter6">パラメーター 6。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
        public static bool TryGetParameters<T, U, V, W, X, Y>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6)
        {
            // 汎用コマンドパラメーターの場合は値を取り出す
            if (parameter is CommandParameter commandParameter)
            {
                parameter = commandParameter.Value;
            }

            if ((parameter is object[]) == false)
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

            if ((_parameter[INDEX_T] is T) == false)
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

            if ((_parameter[INDEX_U] is U) == false)
            {
                parameter2 = default;
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                return false;
            }

            parameter2 = (U)_parameter[INDEX_U];

            if ((_parameter[INDEX_V] is V) == false)
            {
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                return false;
            }

            parameter3 = (V)_parameter[INDEX_V];

            if ((_parameter[INDEX_W] is W) == false)
            {
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                return false;
            }

            parameter4 = (W)_parameter[INDEX_W];

            if ((_parameter[INDEX_X] is X) == false)
            {
                parameter5 = default;
                parameter6 = default;
                return false;
            }

            parameter5 = (X)_parameter[INDEX_X];

            if ((_parameter[INDEX_Y] is Y) == false)
            {
                parameter6 = default;
                return false;
            }

            parameter6 = (Y)_parameter[INDEX_Y];

            return true;
        }

        /// <summary>
        /// オブジェクト配列からパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <typeparam name="Y">パラメーター 6 の型。</typeparam>
        /// <typeparam name="Z">パラメーター 7 の型。</typeparam>
        /// <param name="parameter">オブジェクト配列。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <param name="parameter6">パラメーター 6。</param>
        /// <param name="parameter7">パラメーター 7。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
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

        /// <summary>
        /// オブジェクトからパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <typeparam name="Y">パラメーター 6 の型。</typeparam>
        /// <typeparam name="Z">パラメーター 7 の型。</typeparam>
        /// <param name="parameter">オブジェクト。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <param name="parameter6">パラメーター 6。</param>
        /// <param name="parameter7">パラメーター 7。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
        public static bool TryGetParameters<T, U, V, W, X, Y, Z>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7)
        {
            // 汎用コマンドパラメーターの場合は値を取り出す
            if (parameter is CommandParameter commandParameter)
            {
                parameter = commandParameter.Value;
            }

            if ((parameter is object[]) == false)
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

            if ((_parameter[INDEX_T] is T) == false)
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

            if ((_parameter[INDEX_U] is U) == false)
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

            if ((_parameter[INDEX_V] is V) == false)
            {
                parameter3 = default;
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                return false;
            }

            parameter3 = (V)_parameter[INDEX_V];

            if ((_parameter[INDEX_W] is W) == false)
            {
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                return false;
            }

            parameter4 = (W)_parameter[INDEX_W];

            if ((_parameter[INDEX_X] is X) == false)
            {
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                return false;
            }

            parameter5 = (X)_parameter[INDEX_X];

            if ((_parameter[INDEX_Y] is Y) == false)
            {
                parameter6 = default;
                parameter7 = default;
                return false;
            }

            parameter6 = (Y)_parameter[INDEX_Y];

            if ((_parameter[INDEX_Z] is Z) == false)
            {
                parameter7 = default;
                return false;
            }

            parameter7 = (Z)_parameter[INDEX_Z];

            return true;
        }

        /// <summary>
        /// オブジェクト配列からパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <typeparam name="Y">パラメーター 6 の型。</typeparam>
        /// <typeparam name="Z">パラメーター 7 の型。</typeparam>
        /// <typeparam name="A">パラメーター 8 の型。</typeparam>
        /// <param name="parameter">オブジェクト配列。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <param name="parameter6">パラメーター 6。</param>
        /// <param name="parameter7">パラメーター 7。</param>
        /// <param name="parameter8">パラメーター 8。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
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

        /// <summary>
        /// オブジェクトからパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <typeparam name="Y">パラメーター 6 の型。</typeparam>
        /// <typeparam name="Z">パラメーター 7 の型。</typeparam>
        /// <typeparam name="A">パラメーター 8 の型。</typeparam>
        /// <param name="parameter">オブジェクト。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <param name="parameter6">パラメーター 6。</param>
        /// <param name="parameter7">パラメーター 7。</param>
        /// <param name="parameter8">パラメーター 8。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8)
        {
            // 汎用コマンドパラメーターの場合は値を取り出す
            if (parameter is CommandParameter commandParameter)
            {
                parameter = commandParameter.Value;
            }

            if ((parameter is object[]) == false)
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

            if ((_parameter[INDEX_T] is T) == false)
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

            if ((_parameter[INDEX_U] is U) == false)
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

            if ((_parameter[INDEX_V] is V) == false)
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

            if ((_parameter[INDEX_W] is W) == false)
            {
                parameter4 = default;
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                return false;
            }

            parameter4 = (W)_parameter[INDEX_W];

            if ((_parameter[INDEX_X] is X) == false)
            {
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                return false;
            }

            parameter5 = (X)_parameter[INDEX_X];

            if ((_parameter[INDEX_Y] is Y) == false)
            {
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                return false;
            }

            parameter6 = (Y)_parameter[INDEX_Y];

            if ((_parameter[INDEX_Z] is Z) == false)
            {
                parameter7 = default;
                parameter8 = default;
                return false;
            }

            parameter7 = (Z)_parameter[INDEX_Z];

            if ((_parameter[INDEX_A] is A) == false)
            {
                parameter8 = default;
                return false;
            }

            parameter8 = (A)_parameter[INDEX_A];

            return true;
        }

        /// <summary>
        /// オブジェクト配列からパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <typeparam name="Y">パラメーター 6 の型。</typeparam>
        /// <typeparam name="Z">パラメーター 7 の型。</typeparam>
        /// <typeparam name="A">パラメーター 8 の型。</typeparam>
        /// <typeparam name="B">パラメーター 9 の型。</typeparam>
        /// <param name="parameter">オブジェクト配列。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <param name="parameter6">パラメーター 6。</param>
        /// <param name="parameter7">パラメーター 7。</param>
        /// <param name="parameter8">パラメーター 8。</param>
        /// <param name="parameter9">パラメーター 9。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
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

        /// <summary>
        /// オブジェクトからパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <typeparam name="Y">パラメーター 6 の型。</typeparam>
        /// <typeparam name="Z">パラメーター 7 の型。</typeparam>
        /// <typeparam name="A">パラメーター 8 の型。</typeparam>
        /// <typeparam name="B">パラメーター 9 の型。</typeparam>
        /// <param name="parameter">オブジェクト。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <param name="parameter6">パラメーター 6。</param>
        /// <param name="parameter7">パラメーター 7。</param>
        /// <param name="parameter8">パラメーター 8。</param>
        /// <param name="parameter9">パラメーター 9。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9)
        {
            // 汎用コマンドパラメーターの場合は値を取り出す
            if (parameter is CommandParameter commandParameter)
            {
                parameter = commandParameter.Value;
            }

            if ((parameter is object[]) == false)
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

            if ((_parameter[INDEX_T] is T) == false)
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

            if ((_parameter[INDEX_U] is U) == false)
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

            if ((_parameter[INDEX_V] is V) == false)
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

            if ((_parameter[INDEX_W] is W) == false)
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

            if ((_parameter[INDEX_X] is X) == false)
            {
                parameter5 = default;
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                return false;
            }

            parameter5 = (X)_parameter[INDEX_X];

            if ((_parameter[INDEX_Y] is Y) == false)
            {
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                return false;
            }

            parameter6 = (Y)_parameter[INDEX_Y];

            if ((_parameter[INDEX_Z] is Z) == false)
            {
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                return false;
            }

            parameter7 = (Z)_parameter[INDEX_Z];

            if ((_parameter[INDEX_A] is A) == false)
            {
                parameter8 = default;
                parameter9 = default;
                return false;
            }

            parameter8 = (A)_parameter[INDEX_A];

            if ((_parameter[INDEX_B] is B) == false)
            {
                parameter9 = default;
                return false;
            }

            parameter9 = (B)_parameter[INDEX_B];

            return true;
        }

        /// <summary>
        /// オブジェクト配列からパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <typeparam name="Y">パラメーター 6 の型。</typeparam>
        /// <typeparam name="Z">パラメーター 7 の型。</typeparam>
        /// <typeparam name="A">パラメーター 8 の型。</typeparam>
        /// <typeparam name="B">パラメーター 9 の型。</typeparam>
        /// <typeparam name="C">パラメーター 10 の型。</typeparam>
        /// <param name="parameter">オブジェクト配列。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <param name="parameter6">パラメーター 6。</param>
        /// <param name="parameter7">パラメーター 7。</param>
        /// <param name="parameter8">パラメーター 8。</param>
        /// <param name="parameter9">パラメーター 9。</param>
        /// <param name="parameter10">パラメーター 10。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
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

        /// <summary>
        /// オブジェクトからパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <typeparam name="Y">パラメーター 6 の型。</typeparam>
        /// <typeparam name="Z">パラメーター 7 の型。</typeparam>
        /// <typeparam name="A">パラメーター 8 の型。</typeparam>
        /// <typeparam name="B">パラメーター 9 の型。</typeparam>
        /// <typeparam name="C">パラメーター 10 の型。</typeparam>
        /// <param name="parameter">オブジェクト。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <param name="parameter6">パラメーター 6。</param>
        /// <param name="parameter7">パラメーター 7。</param>
        /// <param name="parameter8">パラメーター 8。</param>
        /// <param name="parameter9">パラメーター 9。</param>
        /// <param name="parameter10">パラメーター 10。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B, C>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9, out C parameter10)
        {
            // 汎用コマンドパラメーターの場合は値を取り出す
            if (parameter is CommandParameter commandParameter)
            {
                parameter = commandParameter.Value;
            }

            if ((parameter is object[]) == false)
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

            if ((_parameter[INDEX_T] is T) == false)
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

            if ((_parameter[INDEX_U] is U) == false)
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

            if ((_parameter[INDEX_V] is V) == false)
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

            if ((_parameter[INDEX_W] is W) == false)
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

            if ((_parameter[INDEX_X] is X) == false)
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

            if ((_parameter[INDEX_Y] is Y) == false)
            {
                parameter6 = default;
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                return false;
            }

            parameter6 = (Y)_parameter[INDEX_Y];

            if ((_parameter[INDEX_Z] is Z) == false)
            {
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                return false;
            }

            parameter7 = (Z)_parameter[INDEX_Z];

            if ((_parameter[INDEX_A] is A) == false)
            {
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                return false;
            }

            parameter8 = (A)_parameter[INDEX_A];

            if ((_parameter[INDEX_B] is B) == false)
            {
                parameter9 = default;
                parameter10 = default;
                return false;
            }

            parameter9 = (B)_parameter[INDEX_B];

            if ((_parameter[INDEX_C] is C) == false)
            {
                parameter10 = default;
                return false;
            }

            parameter10 = (C)_parameter[INDEX_C];

            return true;
        }

        /// <summary>
        /// オブジェクト配列からパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <typeparam name="Y">パラメーター 6 の型。</typeparam>
        /// <typeparam name="Z">パラメーター 7 の型。</typeparam>
        /// <typeparam name="A">パラメーター 8 の型。</typeparam>
        /// <typeparam name="B">パラメーター 9 の型。</typeparam>
        /// <typeparam name="C">パラメーター 10 の型。</typeparam>
        /// <typeparam name="D">パラメーター 11 の型。</typeparam>
        /// <param name="parameter">オブジェクト配列。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <param name="parameter6">パラメーター 6。</param>
        /// <param name="parameter7">パラメーター 7。</param>
        /// <param name="parameter8">パラメーター 8。</param>
        /// <param name="parameter9">パラメーター 9。</param>
        /// <param name="parameter10">パラメーター 10。</param>
        /// <param name="parameter11">パラメーター 11。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
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

        /// <summary>
        /// オブジェクトからパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <typeparam name="Y">パラメーター 6 の型。</typeparam>
        /// <typeparam name="Z">パラメーター 7 の型。</typeparam>
        /// <typeparam name="A">パラメーター 8 の型。</typeparam>
        /// <typeparam name="B">パラメーター 9 の型。</typeparam>
        /// <typeparam name="C">パラメーター 10 の型。</typeparam>
        /// <typeparam name="D">パラメーター 11 の型。</typeparam>
        /// <param name="parameter">オブジェクト。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <param name="parameter6">パラメーター 6。</param>
        /// <param name="parameter7">パラメーター 7。</param>
        /// <param name="parameter8">パラメーター 8。</param>
        /// <param name="parameter9">パラメーター 9。</param>
        /// <param name="parameter10">パラメーター 10。</param>
        /// <param name="parameter11">パラメーター 11。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B, C, D>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9, out C parameter10, out D parameter11)
        {
            // 汎用コマンドパラメーターの場合は値を取り出す
            if (parameter is CommandParameter commandParameter)
            {
                parameter = commandParameter.Value;
            }

            if ((parameter is object[]) == false)
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

            if ((_parameter[INDEX_T] is T) == false)
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

            if ((_parameter[INDEX_U] is U) == false)
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

            if ((_parameter[INDEX_V] is V) == false)
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

            if ((_parameter[INDEX_W] is W) == false)
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

            if ((_parameter[INDEX_X] is X) == false)
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

            if ((_parameter[INDEX_Y] is Y) == false)
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

            if ((_parameter[INDEX_Z] is Z) == false)
            {
                parameter7 = default;
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                return false;
            }

            parameter7 = (Z)_parameter[INDEX_Z];

            if ((_parameter[INDEX_A] is A) == false)
            {
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                return false;
            }

            parameter8 = (A)_parameter[INDEX_A];

            if ((_parameter[INDEX_B] is B) == false)
            {
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                return false;
            }

            parameter9 = (B)_parameter[INDEX_B];

            if ((_parameter[INDEX_C] is C) == false)
            {
                parameter10 = default;
                parameter11 = default;
                return false;
            }

            parameter10 = (C)_parameter[INDEX_C];

            if ((_parameter[INDEX_D] is D) == false)
            {
                parameter11 = default;
                return false;
            }

            parameter11 = (D)_parameter[INDEX_D];

            return true;
        }

        /// <summary>
        /// オブジェクト配列からパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <typeparam name="Y">パラメーター 6 の型。</typeparam>
        /// <typeparam name="Z">パラメーター 7 の型。</typeparam>
        /// <typeparam name="A">パラメーター 8 の型。</typeparam>
        /// <typeparam name="B">パラメーター 9 の型。</typeparam>
        /// <typeparam name="C">パラメーター 10 の型。</typeparam>
        /// <typeparam name="D">パラメーター 11 の型。</typeparam>
        /// <typeparam name="E">パラメーター 12 の型。</typeparam>
        /// <param name="parameter">オブジェクト配列。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <param name="parameter6">パラメーター 6。</param>
        /// <param name="parameter7">パラメーター 7。</param>
        /// <param name="parameter8">パラメーター 8。</param>
        /// <param name="parameter9">パラメーター 9。</param>
        /// <param name="parameter10">パラメーター 10。</param>
        /// <param name="parameter11">パラメーター 11。</param>
        /// <param name="parameter12">パラメーター 12。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
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

        /// <summary>
        /// オブジェクトからパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <typeparam name="Y">パラメーター 6 の型。</typeparam>
        /// <typeparam name="Z">パラメーター 7 の型。</typeparam>
        /// <typeparam name="A">パラメーター 8 の型。</typeparam>
        /// <typeparam name="B">パラメーター 9 の型。</typeparam>
        /// <typeparam name="C">パラメーター 10 の型。</typeparam>
        /// <typeparam name="D">パラメーター 11 の型。</typeparam>
        /// <typeparam name="E">パラメーター 12 の型。</typeparam>
        /// <param name="parameter">オブジェクト。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <param name="parameter6">パラメーター 6。</param>
        /// <param name="parameter7">パラメーター 7。</param>
        /// <param name="parameter8">パラメーター 8。</param>
        /// <param name="parameter9">パラメーター 9。</param>
        /// <param name="parameter10">パラメーター 10。</param>
        /// <param name="parameter11">パラメーター 11。</param>
        /// <param name="parameter12">パラメーター 12。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B, C, D, E>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9, out C parameter10, out D parameter11, out E parameter12)
        {
            // 汎用コマンドパラメーターの場合は値を取り出す
            if (parameter is CommandParameter commandParameter)
            {
                parameter = commandParameter.Value;
            }

            if ((parameter is object[]) == false)
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

            if ((_parameter[INDEX_T] is T) == false)
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

            if ((_parameter[INDEX_U] is U) == false)
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

            if ((_parameter[INDEX_V] is V) == false)
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

            if ((_parameter[INDEX_W] is W) == false)
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

            if ((_parameter[INDEX_X] is X) == false)
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

            if ((_parameter[INDEX_Y] is Y) == false)
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

            if ((_parameter[INDEX_Z] is Z) == false)
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

            if ((_parameter[INDEX_A] is A) == false)
            {
                parameter8 = default;
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                return false;
            }

            parameter8 = (A)_parameter[INDEX_A];

            if ((_parameter[INDEX_B] is B) == false)
            {
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                return false;
            }

            parameter9 = (B)_parameter[INDEX_B];

            if ((_parameter[INDEX_C] is C) == false)
            {
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                return false;
            }

            parameter10 = (C)_parameter[INDEX_C];

            if ((_parameter[INDEX_D] is D) == false)
            {
                parameter11 = default;
                parameter12 = default;
                return false;
            }

            parameter11 = (D)_parameter[INDEX_D];

            if ((_parameter[INDEX_E] is E) == false)
            {
                parameter12 = default;
                return false;
            }

            parameter12 = (E)_parameter[INDEX_E];

            return true;
        }

        /// <summary>
        /// オブジェクト配列からパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <typeparam name="Y">パラメーター 6 の型。</typeparam>
        /// <typeparam name="Z">パラメーター 7 の型。</typeparam>
        /// <typeparam name="A">パラメーター 8 の型。</typeparam>
        /// <typeparam name="B">パラメーター 9 の型。</typeparam>
        /// <typeparam name="C">パラメーター 10 の型。</typeparam>
        /// <typeparam name="D">パラメーター 11 の型。</typeparam>
        /// <typeparam name="E">パラメーター 12 の型。</typeparam>
        /// <typeparam name="F">パラメーター 13 の型。</typeparam>
        /// <param name="parameter">オブジェクト配列。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <param name="parameter6">パラメーター 6。</param>
        /// <param name="parameter7">パラメーター 7。</param>
        /// <param name="parameter8">パラメーター 8。</param>
        /// <param name="parameter9">パラメーター 9。</param>
        /// <param name="parameter10">パラメーター 10。</param>
        /// <param name="parameter11">パラメーター 11。</param>
        /// <param name="parameter12">パラメーター 12。</param>
        /// <param name="parameter13">パラメーター 13。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
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

        /// <summary>
        /// オブジェクトからパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <typeparam name="Y">パラメーター 6 の型。</typeparam>
        /// <typeparam name="Z">パラメーター 7 の型。</typeparam>
        /// <typeparam name="A">パラメーター 8 の型。</typeparam>
        /// <typeparam name="B">パラメーター 9 の型。</typeparam>
        /// <typeparam name="C">パラメーター 10 の型。</typeparam>
        /// <typeparam name="D">パラメーター 11 の型。</typeparam>
        /// <typeparam name="E">パラメーター 12 の型。</typeparam>
        /// <typeparam name="F">パラメーター 13 の型。</typeparam>
        /// <param name="parameter">オブジェクト。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <param name="parameter6">パラメーター 6。</param>
        /// <param name="parameter7">パラメーター 7。</param>
        /// <param name="parameter8">パラメーター 8。</param>
        /// <param name="parameter9">パラメーター 9。</param>
        /// <param name="parameter10">パラメーター 10。</param>
        /// <param name="parameter11">パラメーター 11。</param>
        /// <param name="parameter12">パラメーター 12。</param>
        /// <param name="parameter13">パラメーター 13。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B, C, D, E, F>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9, out C parameter10, out D parameter11, out E parameter12, out F parameter13)
        {
            // 汎用コマンドパラメーターの場合は値を取り出す
            if (parameter is CommandParameter commandParameter)
            {
                parameter = commandParameter.Value;
            }

            if ((parameter is object[]) == false)
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

            if ((_parameter[INDEX_T] is T) == false)
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

            if ((_parameter[INDEX_U] is U) == false)
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

            if ((_parameter[INDEX_V] is V) == false)
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

            if ((_parameter[INDEX_W] is W) == false)
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

            if ((_parameter[INDEX_X] is X) == false)
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

            if ((_parameter[INDEX_Y] is Y) == false)
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

            if ((_parameter[INDEX_Z] is Z) == false)
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

            if ((_parameter[INDEX_A] is A) == false)
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

            if ((_parameter[INDEX_B] is B) == false)
            {
                parameter9 = default;
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                return false;
            }

            parameter9 = (B)_parameter[INDEX_B];

            if ((_parameter[INDEX_C] is C) == false)
            {
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                return false;
            }

            parameter10 = (C)_parameter[INDEX_C];

            if ((_parameter[INDEX_D] is D) == false)
            {
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                return false;
            }

            parameter11 = (D)_parameter[INDEX_D];

            if ((_parameter[INDEX_E] is E) == false)
            {
                parameter12 = default;
                parameter13 = default;
                return false;
            }

            parameter12 = (E)_parameter[INDEX_E];

            if ((_parameter[INDEX_F] is F) == false)
            {
                parameter13 = default;
                return false;
            }

            parameter13 = (F)_parameter[INDEX_F];

            return true;
        }

        /// <summary>
        /// オブジェクト配列からパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <typeparam name="Y">パラメーター 6 の型。</typeparam>
        /// <typeparam name="Z">パラメーター 7 の型。</typeparam>
        /// <typeparam name="A">パラメーター 8 の型。</typeparam>
        /// <typeparam name="B">パラメーター 9 の型。</typeparam>
        /// <typeparam name="C">パラメーター 10 の型。</typeparam>
        /// <typeparam name="D">パラメーター 11 の型。</typeparam>
        /// <typeparam name="E">パラメーター 12 の型。</typeparam>
        /// <typeparam name="F">パラメーター 13 の型。</typeparam>
        /// <typeparam name="G">パラメーター 14 の型。</typeparam>
        /// <param name="parameter">オブジェクト配列。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <param name="parameter6">パラメーター 6。</param>
        /// <param name="parameter7">パラメーター 7。</param>
        /// <param name="parameter8">パラメーター 8。</param>
        /// <param name="parameter9">パラメーター 9。</param>
        /// <param name="parameter10">パラメーター 10。</param>
        /// <param name="parameter11">パラメーター 11。</param>
        /// <param name="parameter12">パラメーター 12。</param>
        /// <param name="parameter13">パラメーター 13。</param>
        /// <param name="parameter14">パラメーター 14。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
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

        /// <summary>
        /// オブジェクトからパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <typeparam name="Y">パラメーター 6 の型。</typeparam>
        /// <typeparam name="Z">パラメーター 7 の型。</typeparam>
        /// <typeparam name="A">パラメーター 8 の型。</typeparam>
        /// <typeparam name="B">パラメーター 9 の型。</typeparam>
        /// <typeparam name="C">パラメーター 10 の型。</typeparam>
        /// <typeparam name="D">パラメーター 11 の型。</typeparam>
        /// <typeparam name="E">パラメーター 12 の型。</typeparam>
        /// <typeparam name="F">パラメーター 13 の型。</typeparam>
        /// <typeparam name="G">パラメーター 14 の型。</typeparam>
        /// <param name="parameter">オブジェクト。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <param name="parameter6">パラメーター 6。</param>
        /// <param name="parameter7">パラメーター 7。</param>
        /// <param name="parameter8">パラメーター 8。</param>
        /// <param name="parameter9">パラメーター 9。</param>
        /// <param name="parameter10">パラメーター 10。</param>
        /// <param name="parameter11">パラメーター 11。</param>
        /// <param name="parameter12">パラメーター 12。</param>
        /// <param name="parameter13">パラメーター 13。</param>
        /// <param name="parameter14">パラメーター 14。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B, C, D, E, F, G>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9, out C parameter10, out D parameter11, out E parameter12, out F parameter13, out G parameter14)
        {
            // 汎用コマンドパラメーターの場合は値を取り出す
            if (parameter is CommandParameter commandParameter)
            {
                parameter = commandParameter.Value;
            }

            if ((parameter is object[]) == false)
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

            if ((_parameter[INDEX_T] is T) == false)
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

            if ((_parameter[INDEX_U] is U) == false)
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

            if ((_parameter[INDEX_V] is V) == false)
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

            if ((_parameter[INDEX_W] is W) == false)
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

            if ((_parameter[INDEX_X] is X) == false)
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

            if ((_parameter[INDEX_Y] is Y) == false)
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

            if ((_parameter[INDEX_Z] is Z) == false)
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

            if ((_parameter[INDEX_A] is A) == false)
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

            if ((_parameter[INDEX_B] is B) == false)
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

            if ((_parameter[INDEX_C] is C) == false)
            {
                parameter10 = default;
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                return false;
            }

            parameter10 = (C)_parameter[INDEX_C];

            if ((_parameter[INDEX_D] is D) == false)
            {
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                return false;
            }

            parameter11 = (D)_parameter[INDEX_D];

            if ((_parameter[INDEX_E] is E) == false)
            {
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                return false;
            }

            parameter12 = (E)_parameter[INDEX_E];

            if ((_parameter[INDEX_F] is F) == false)
            {
                parameter13 = default;
                parameter14 = default;
                return false;
            }

            parameter13 = (F)_parameter[INDEX_F];

            if ((_parameter[INDEX_G] is G) == false)
            {
                parameter14 = default;
                return false;
            }

            parameter14 = (G)_parameter[INDEX_G];

            return true;
        }

        /// <summary>
        /// オブジェクト配列からパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <typeparam name="Y">パラメーター 6 の型。</typeparam>
        /// <typeparam name="Z">パラメーター 7 の型。</typeparam>
        /// <typeparam name="A">パラメーター 8 の型。</typeparam>
        /// <typeparam name="B">パラメーター 9 の型。</typeparam>
        /// <typeparam name="C">パラメーター 10 の型。</typeparam>
        /// <typeparam name="D">パラメーター 11 の型。</typeparam>
        /// <typeparam name="E">パラメーター 12 の型。</typeparam>
        /// <typeparam name="F">パラメーター 13 の型。</typeparam>
        /// <typeparam name="G">パラメーター 14 の型。</typeparam>
        /// <typeparam name="H">パラメーター 15 の型。</typeparam>
        /// <param name="parameter">オブジェクト配列。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <param name="parameter6">パラメーター 6。</param>
        /// <param name="parameter7">パラメーター 7。</param>
        /// <param name="parameter8">パラメーター 8。</param>
        /// <param name="parameter9">パラメーター 9。</param>
        /// <param name="parameter10">パラメーター 10。</param>
        /// <param name="parameter11">パラメーター 11。</param>
        /// <param name="parameter12">パラメーター 12。</param>
        /// <param name="parameter13">パラメーター 13。</param>
        /// <param name="parameter14">パラメーター 14。</param>
        /// <param name="parameter15">パラメーター 15。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
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

        /// <summary>
        /// オブジェクトからパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <typeparam name="Y">パラメーター 6 の型。</typeparam>
        /// <typeparam name="Z">パラメーター 7 の型。</typeparam>
        /// <typeparam name="A">パラメーター 8 の型。</typeparam>
        /// <typeparam name="B">パラメーター 9 の型。</typeparam>
        /// <typeparam name="C">パラメーター 10 の型。</typeparam>
        /// <typeparam name="D">パラメーター 11 の型。</typeparam>
        /// <typeparam name="E">パラメーター 12 の型。</typeparam>
        /// <typeparam name="F">パラメーター 13 の型。</typeparam>
        /// <typeparam name="G">パラメーター 14 の型。</typeparam>
        /// <typeparam name="H">パラメーター 15 の型。</typeparam>
        /// <param name="parameter">オブジェクト。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <param name="parameter6">パラメーター 6。</param>
        /// <param name="parameter7">パラメーター 7。</param>
        /// <param name="parameter8">パラメーター 8。</param>
        /// <param name="parameter9">パラメーター 9。</param>
        /// <param name="parameter10">パラメーター 10。</param>
        /// <param name="parameter11">パラメーター 11。</param>
        /// <param name="parameter12">パラメーター 12。</param>
        /// <param name="parameter13">パラメーター 13。</param>
        /// <param name="parameter14">パラメーター 14。</param>
        /// <param name="parameter15">パラメーター 15。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B, C, D, E, F, G, H>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9, out C parameter10, out D parameter11, out E parameter12, out F parameter13, out G parameter14, out H parameter15)
        {
            // 汎用コマンドパラメーターの場合は値を取り出す
            if (parameter is CommandParameter commandParameter)
            {
                parameter = commandParameter.Value;
            }

            if ((parameter is object[]) == false)
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

            if ((_parameter[INDEX_T] is T) == false)
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

            if ((_parameter[INDEX_U] is U) == false)
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

            if ((_parameter[INDEX_V] is V) == false)
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

            if ((_parameter[INDEX_W] is W) == false)
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

            if ((_parameter[INDEX_X] is X) == false)
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

            if ((_parameter[INDEX_Y] is Y) == false)
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

            if ((_parameter[INDEX_Z] is Z) == false)
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

            if ((_parameter[INDEX_A] is A) == false)
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

            if ((_parameter[INDEX_B] is B) == false)
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

            if ((_parameter[INDEX_C] is C) == false)
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

            if ((_parameter[INDEX_D] is D) == false)
            {
                parameter11 = default;
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                return false;
            }

            parameter11 = (D)_parameter[INDEX_D];

            if ((_parameter[INDEX_E] is E) == false)
            {
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                return false;
            }

            parameter12 = (E)_parameter[INDEX_E];

            if ((_parameter[INDEX_F] is F) == false)
            {
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                return false;
            }

            parameter13 = (F)_parameter[INDEX_F];

            if ((_parameter[INDEX_G] is G) == false)
            {
                parameter14 = default;
                parameter15 = default;
                return false;
            }

            parameter14 = (G)_parameter[INDEX_G];

            if ((_parameter[INDEX_H] is H) == false)
            {
                parameter15 = default;
                return false;
            }

            parameter15 = (H)_parameter[INDEX_H];

            return true;
        }

        /// <summary>
        /// オブジェクト配列からパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <typeparam name="Y">パラメーター 6 の型。</typeparam>
        /// <typeparam name="Z">パラメーター 7 の型。</typeparam>
        /// <typeparam name="A">パラメーター 8 の型。</typeparam>
        /// <typeparam name="B">パラメーター 9 の型。</typeparam>
        /// <typeparam name="C">パラメーター 10 の型。</typeparam>
        /// <typeparam name="D">パラメーター 11 の型。</typeparam>
        /// <typeparam name="E">パラメーター 12 の型。</typeparam>
        /// <typeparam name="F">パラメーター 13 の型。</typeparam>
        /// <typeparam name="G">パラメーター 14 の型。</typeparam>
        /// <typeparam name="H">パラメーター 15 の型。</typeparam>
        /// <typeparam name="I">パラメーター 16 の型。</typeparam>
        /// <param name="parameter">オブジェクト配列。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <param name="parameter6">パラメーター 6。</param>
        /// <param name="parameter7">パラメーター 7。</param>
        /// <param name="parameter8">パラメーター 8。</param>
        /// <param name="parameter9">パラメーター 9。</param>
        /// <param name="parameter10">パラメーター 10。</param>
        /// <param name="parameter11">パラメーター 11。</param>
        /// <param name="parameter12">パラメーター 12。</param>
        /// <param name="parameter13">パラメーター 13。</param>
        /// <param name="parameter14">パラメーター 14。</param>
        /// <param name="parameter15">パラメーター 15。</param>
        /// <param name="parameter16">パラメーター 16。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
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

        /// <summary>
        /// オブジェクトからパラメーターを取り出します。
        /// </summary>
        /// <typeparam name="T">パラメーター 1 の型。</typeparam>
        /// <typeparam name="U">パラメーター 2 の型。</typeparam>
        /// <typeparam name="V">パラメーター 3 の型。</typeparam>
        /// <typeparam name="W">パラメーター 4 の型。</typeparam>
        /// <typeparam name="X">パラメーター 5 の型。</typeparam>
        /// <typeparam name="Y">パラメーター 6 の型。</typeparam>
        /// <typeparam name="Z">パラメーター 7 の型。</typeparam>
        /// <typeparam name="A">パラメーター 8 の型。</typeparam>
        /// <typeparam name="B">パラメーター 9 の型。</typeparam>
        /// <typeparam name="C">パラメーター 10 の型。</typeparam>
        /// <typeparam name="D">パラメーター 11 の型。</typeparam>
        /// <typeparam name="E">パラメーター 12 の型。</typeparam>
        /// <typeparam name="F">パラメーター 13 の型。</typeparam>
        /// <typeparam name="G">パラメーター 14 の型。</typeparam>
        /// <typeparam name="H">パラメーター 15 の型。</typeparam>
        /// <typeparam name="I">パラメーター 16 の型。</typeparam>
        /// <param name="parameter">オブジェクト。</param>
        /// <param name="parameter1">パラメーター 1。</param>
        /// <param name="parameter2">パラメーター 2。</param>
        /// <param name="parameter3">パラメーター 3。</param>
        /// <param name="parameter4">パラメーター 4。</param>
        /// <param name="parameter5">パラメーター 5。</param>
        /// <param name="parameter6">パラメーター 6。</param>
        /// <param name="parameter7">パラメーター 7。</param>
        /// <param name="parameter8">パラメーター 8。</param>
        /// <param name="parameter9">パラメーター 9。</param>
        /// <param name="parameter10">パラメーター 10。</param>
        /// <param name="parameter11">パラメーター 11。</param>
        /// <param name="parameter12">パラメーター 12。</param>
        /// <param name="parameter13">パラメーター 13。</param>
        /// <param name="parameter14">パラメーター 14。</param>
        /// <param name="parameter15">パラメーター 15。</param>
        /// <param name="parameter16">パラメーター 16。</param>
        /// <returns>すべてのパラメーターが正常に取り出せた場合は <c>true</c>。そうでない場合は <c>false</c>。</returns>
        public static bool TryGetParameters<T, U, V, W, X, Y, Z, A, B, C, D, E, F, G, H, I>(object parameter, out T parameter1, out U parameter2, out V parameter3, out W parameter4, out X parameter5, out Y parameter6, out Z parameter7, out A parameter8, out B parameter9, out C parameter10, out D parameter11, out E parameter12, out F parameter13, out G parameter14, out H parameter15, out I parameter16)
        {
            // 汎用コマンドパラメーターの場合は値を取り出す
            if (parameter is CommandParameter commandParameter)
            {
                parameter = commandParameter.Value;
            }

            if ((parameter is object[]) == false)
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

            if ((_parameter[INDEX_T] is T) == false)
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

            if ((_parameter[INDEX_U] is U) == false)
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

            if ((_parameter[INDEX_V] is V) == false)
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

            if ((_parameter[INDEX_W] is W) == false)
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

            if ((_parameter[INDEX_X] is X) == false)
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

            if ((_parameter[INDEX_Y] is Y) == false)
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

            if ((_parameter[INDEX_Z] is Z) == false)
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

            if ((_parameter[INDEX_A] is A) == false)
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

            if ((_parameter[INDEX_B] is B) == false)
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

            if ((_parameter[INDEX_C] is C) == false)
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

            if ((_parameter[INDEX_D] is D) == false)
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

            if ((_parameter[INDEX_E] is E) == false)
            {
                parameter12 = default;
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                parameter16 = default;
                return false;
            }

            parameter12 = (E)_parameter[INDEX_E];

            if ((_parameter[INDEX_F] is F) == false)
            {
                parameter13 = default;
                parameter14 = default;
                parameter15 = default;
                parameter16 = default;
                return false;
            }

            parameter13 = (F)_parameter[INDEX_F];

            if ((_parameter[INDEX_G] is G) == false)
            {
                parameter14 = default;
                parameter15 = default;
                parameter16 = default;
                return false;
            }

            parameter14 = (G)_parameter[INDEX_G];

            if ((_parameter[INDEX_H] is H) == false)
            {
                parameter15 = default;
                parameter16 = default;
                return false;
            }

            parameter15 = (H)_parameter[INDEX_H];

            if ((_parameter[INDEX_I] is I) == false)
            {
                parameter16 = default;
                return false;
            }

            parameter16 = (I)_parameter[INDEX_I];

            return true;
        }
    }
}
