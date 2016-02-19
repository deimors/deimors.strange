using deimors.strange.steering.mediators;
using deimors.strange.steering.signals;
using deimors.strange.steering.views;
using strange.extensions.context.impl;
using UnityEngine;

namespace deimors.strange.steering {
    public class SteeringContext : MVCSContext {
        public SteeringContext(MonoBehaviour view, bool autoMap) : base(view, autoMap) { }

        protected override void mapBindings() {
            // signal bindings
            injectionBinder.Bind<SetRotateTargetSignal>().ToSingleton().CrossContext();

            // view bindings
            mediationBinder.Bind<RotateTowardsForce2DView>().To<RotateTowardsForce2DMediator>();
            mediationBinder.Bind<DirectedConstantForce2DView>().To<DirectedConstantForce2DMediator>();
        }
    }
}
