using deimors.strange.common.context;
using deimors.strange.steering.mediators;
using deimors.strange.steering.signals;
using deimors.strange.steering.views;
using strange.extensions.command.api;
using strange.extensions.injector.api;
using strange.extensions.mediation.api;

namespace deimors.strange.steering {
    public class SteeringContextMapping : IContextMapping {
        public void BindCommands(ICommandBinder commandBinder) {
            
        }

        public void BindModels(IInjectionBinder injectionBinder) {
            
        }

        public void BindSignals(IInjectionBinder injectionBinder) {
            injectionBinder.Bind<SetRotateTargetSignal>().ToSingleton().CrossContext();
            injectionBinder.Bind<SetDirectedForceMagSignal>().ToSingleton().CrossContext();
            injectionBinder.Bind<SetDirectedForceDirSignal>().ToSingleton().CrossContext();
        }

        public void BindViews(IMediationBinder mediationBinder) {
            mediationBinder.Bind<RotateTowardsForce2DView>().To<RotateTowardsForce2DMediator>();
            mediationBinder.Bind<DirectedConstantForce2DView>().To<DirectedConstantForce2DMediator>();
        }
    }
}
