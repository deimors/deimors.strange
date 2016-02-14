using deimors.strange.proximity.commands;
using deimors.strange.proximity.mediators;
using deimors.strange.proximity.models;
using deimors.strange.proximity.models.impl;
using deimors.strange.proximity.signals;
using deimors.strange.proximity.views;
using strange.extensions.context.impl;
using UnityEngine;

namespace deimors.strange.proximity {
    class ProximityContext : MVCSContext {
        public ProximityContext(MonoBehaviour view, bool autoMap) : base(view, autoMap) { }

        protected override void mapBindings() {
            // model bindings
            injectionBinder.Bind<IObjectProximityModel>().To<ObjectProximityModel>().ToSingleton();

            // crosscontext signal bindings
            injectionBinder.Bind<ProximityEnteredSignal>().ToSingleton().CrossContext();
            injectionBinder.Bind<ProximityExitedSignal>().ToSingleton().CrossContext();

            // command bindings
            commandBinder.Bind<AddToProximitySignal>().To<AddToProximityCommand>().Pooled();
            commandBinder.Bind<RemoveFromProximitySignal>().To<RemoveFromProximityCommand>().Pooled();

            // view bindings
            mediationBinder.Bind<ProximityCollider2DView>().To<ProximityCollider2DMediator>();
        }
    }
}
