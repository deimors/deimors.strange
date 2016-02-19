using deimors.strange.common.context;
using strange.extensions.context.api;

namespace deimors.strange.steering {
    public class SteeringLoadableContextView : LoadableContextView {
        protected override IContext InstantiateContext() {
            return new SteeringContext(this, true);
        }
    }
}
