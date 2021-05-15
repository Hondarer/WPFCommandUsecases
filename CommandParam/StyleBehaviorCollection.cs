// https://blog.okazuki.jp/entry/2016/07/19/192918

using System.Linq;
using System.Windows;
using System.Windows.Interactivity;

namespace CommandParam
{
    /// <summary>
    /// スタイルに定義可能なビヘイビアのコンテナを提供します。
    /// </summary>
    /// <remarks>
    /// ビヘイビアは 1:1 にしか定義できないため、スタイルにそのまま定義することはできません。
    /// このクラスでは、定義されたビヘイビアのクローンを返すことで、スタイルにビヘイビアを定義することを可能にします。
    /// </remarks>
    public class StyleBehaviorCollection : FreezableCollection<Behavior>
    {
        /// <summary>
        /// Behaviors 依存関係プロパティを識別します。このフィールドは読み取り専用です。
        /// </summary>
        public static readonly DependencyProperty BehaviorsProperty =
            DependencyProperty.RegisterAttached("Behaviors", typeof(StyleBehaviorCollection), typeof(StyleBehaviorCollection), new PropertyMetadata(BehaviorsChanged));

        /// <summary>
        /// ビヘイビアを取得します。
        /// </summary>
        /// <param name="obj">対象の <see cref="DependencyObject"/>。</param>
        /// <returns><see cref="StyleBehaviorCollection"/>。</returns>
        public static StyleBehaviorCollection GetBehaviors(DependencyObject obj)
        {
            return (StyleBehaviorCollection)obj.GetValue(BehaviorsProperty);
        }

        /// <summary>
        /// ビヘイビアを設定します。
        /// </summary>
        /// <param name="obj">対象の <see cref="DependencyObject"/>。</param>
        /// <param name="value"><see cref="StyleBehaviorCollection"/>。</param>
        public static void SetBehaviors(DependencyObject obj, StyleBehaviorCollection value)
        {
            obj.SetValue(BehaviorsProperty, value);
        }

        /// <summary>
        /// ビヘイビアが変化した際の処理を行います。
        /// </summary>
        /// <param name="sender">The System.Windows.DependencyObject on which the property has changed value.</param>
        /// <param name="e">Event data that is issued by any event that tracks changes to the effective value of this property.</param>
        protected static void BehaviorsChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            // 前後が同じ値であれば処理しない。
            if (e.OldValue == e.NewValue)
            {
                return;
            }

            // 新しい値が無効な値であれば処理しない。
            if ((e.NewValue is StyleBehaviorCollection) == false)
            {
                return;
            }

            // 現在設定されているビヘイビアを得る。
            BehaviorCollection behaviors = Interaction.GetBehaviors(sender);

            // ビヘイビアを一旦クリアする。
            behaviors.Clear();

            // StyleBehaviorCollection に定義されているビヘイビアのクローンを追加する。
            foreach (var b in (e.NewValue as StyleBehaviorCollection).Select(x => (Behavior)x.Clone()))
            {
                behaviors.Add(b);
            }
        }

        /// <inheritdoc/>
        protected override Freezable CreateInstanceCore()
        {
            return new StyleBehaviorCollection();
        }
    }
}
