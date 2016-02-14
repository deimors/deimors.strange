using deimors.strange.common.context;
using strange.extensions.context.api;

namespace deimors.strange.proximity {
    class ProximityLoadableContextView : LoadableContextView {
        protected override IContext InstantiateContext() {
            return new ProximityContext(this, true);
        }
    }
}
