using System;

namespace CommandParam
{
    /// <summary>
    /// <see cref="Type"/> の拡張メソッドを提供します。
    /// </summary>
    public static class TypeExtension
    {
        /// <summary>
        /// チェック対象のクラスのジェネリックのサブクラスかどうかをチェックします。
        /// </summary>
        /// <param name="current">自身の <see cref="Type"/>。</param>
        /// <param name="compare">チェック対象の <see cref="Type"/>。</param>
        /// <returns>自身がチェック対象のジェネリックのサブクラスの場合、<c>true</c>。それ以外の場合 <c>false</c>。</returns>
        public static bool IsSubclassOfGeneric(this Type current, Type compare)
        {
            // チェック用の起点 Type
            Type checkType = current;

            // 自身の Type から BaseType でルートまで探索
            while ((checkType != null) && (checkType != typeof(object)))
            {
                // ジェネリックの場合は、ジェネリックの型を取得
                if (checkType.IsGenericType == true)
                {
                    checkType = checkType.GetGenericTypeDefinition();
                }

                // 型のチェック
                if (checkType == compare)
                {
                    // 一致している
                    return true;
                }

                // 親クラスへ
                checkType = checkType.BaseType;
            }

            return false;
        }
    }
}
