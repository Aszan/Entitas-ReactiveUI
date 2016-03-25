//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        public PauseListenerComponent pauseListener { get { return (PauseListenerComponent)GetComponent(ComponentIds.PauseListener); } }

        public bool hasPauseListener { get { return HasComponent(ComponentIds.PauseListener); } }

        public Entity AddPauseListener(IPauseListener newListener) {
            var component = CreateComponent<PauseListenerComponent>(ComponentIds.PauseListener);
            component.listener = newListener;
            return AddComponent(ComponentIds.PauseListener, component);
        }

        public Entity ReplacePauseListener(IPauseListener newListener) {
            var component = CreateComponent<PauseListenerComponent>(ComponentIds.PauseListener);
            component.listener = newListener;
            ReplaceComponent(ComponentIds.PauseListener, component);
            return this;
        }

        public Entity RemovePauseListener() {
            return RemoveComponent(ComponentIds.PauseListener);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherPauseListener;

        public static IMatcher PauseListener {
            get {
                if (_matcherPauseListener == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.PauseListener);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherPauseListener = matcher;
                }

                return _matcherPauseListener;
            }
        }
    }
}