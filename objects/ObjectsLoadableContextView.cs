using deimors.strange.common.context;
using strange.extensions.context.api;

namespace deimors.strange.objects {
    class ObjectsLoadableContextView : LoadableContextView {
        protected override IContext InstantiateContext() {
            return new ObjectsContext(this, true);
        }
    }
}
