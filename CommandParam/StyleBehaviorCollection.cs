using System.Linq;
using System.Windows;
using System.Windows.Interactivity;

namespace CommandParam
{
    // https://blog.okazuki.jp/entry/2016/07/19/192918
    public class StyleBehaviorCollection : FreezableCollection<Behavior>
    {
        public static readonly DependencyProperty BehaviorsProperty =
            DependencyProperty.RegisterAttached(
                "Behaviors",
                typeof(StyleBehaviorCollection),
                typeof(StyleBehaviorCollection),
                new PropertyMetadata((sender, e) =>
                {
                    if (e.OldValue == e.NewValue) 
                    { 
                        return; 
                    }

                    if (!(e.NewValue is StyleBehaviorCollection value))
                    {
                        return;
                    }

                    var behaviors = Interaction.GetBehaviors(sender);
                    behaviors.Clear();
                    
                    foreach (var b in value.Select(x => (Behavior)x.Clone()))
                    {
                        behaviors.Add(b);
                    }
                }));

        public static StyleBehaviorCollection GetBehaviors(DependencyObject obj)
        {
            return (StyleBehaviorCollection)obj.GetValue(BehaviorsProperty);
        }

        public static void SetBehaviors(DependencyObject obj, StyleBehaviorCollection value)
        {
            obj.SetValue(BehaviorsProperty, value);
        }

        protected override Freezable CreateInstanceCore()
        {
            return new StyleBehaviorCollection();
        }
    }
}
