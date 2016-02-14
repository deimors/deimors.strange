using deimors.strange.objects.commands;
using deimors.strange.objects.mediators;
using deimors.strange.objects.models;
using deimors.strange.objects.models.impl;
using deimors.strange.objects.signals;
using deimors.strange.objects.views;
using strange.extensions.context.impl;
using UnityEngine;

namespace deimors.strange.objects {
    public class ObjectsContext : MVCSContext {
        public ObjectsContext(MonoBehaviour view, bool autoMap) : base(view, autoMap) { }

        protected override void mapBindings() {
            // model bindings
            injectionBinder.Bind<IObjectIDModel>().To<ObjectIDModel>().ToSingleton();
            injectionBinder.Bind<IObjectsModel>().To<ObjectsModel>().ToSingleton().CrossContext();
            injectionBinder.Bind<IObjectTransformModel>().To<ObjectTransformModel>().ToSingleton().CrossContext();

            // command bindings
            commandBinder.Bind<InitializeObjectSignal>().To<InitializeObjectCommand>().Pooled();

            // view bindings
            mediationBinder.Bind<ObjectView>().To<ObjectMediator>();
        }
    }
}
