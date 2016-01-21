namespace Entitas {
    public partial class Entity {
        static readonly ComponentF componentFComponent = new ComponentF();

        public bool isComponentF {
            get { return HasComponent(ComponentIds.ComponentF); }
            set {
                if (value != isComponentF) {
                    if (value) {
                        AddComponent(ComponentIds.ComponentF, componentFComponent);
                    } else {
                        RemoveComponent(ComponentIds.ComponentF);
                    }
                }
            }
        }

        public Entity IsComponentF(bool value) {
            isComponentF = value;
            return this;
        }
    }

    public partial class Matcher {
        static IMatcher _matcherComponentF;

        public static IMatcher ComponentF {
            get {
                if (_matcherComponentF == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.ComponentF);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherComponentF = matcher;
                }

                return _matcherComponentF;
            }
        }
    }
}
