using deimors.strange.common.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using strange.extensions.command.api;
using strange.extensions.injector.api;
using strange.extensions.mediation.api;
using deimors.strange.objects.models;
using deimors.strange.objects.models.impl;
using deimors.strange.objects.signals;
using deimors.strange.objects.commands;
using deimors.strange.objects.views;
using deimors.strange.objects.mediators;

namespace deimors.strange.objects {
    public class ObjectsContextMapping : IContextMapping {
        public void BindCommands(ICommandBinder commandBinder) {
            commandBinder.Bind<InitializeObjectSignal>().To<InitializeObjectCommand>().Pooled();
        }

        public void BindModels(IInjectionBinder injectionBinder) {
            injectionBinder.Bind<IObjectIDModel>().To<ObjectIDModel>().ToSingleton();
            injectionBinder.Bind<IObjectsModel>().To<ObjectsModel>().ToSingleton().CrossContext();
            injectionBinder.Bind<IObjectTransformModel>().To<ObjectTransformModel>().ToSingleton().CrossContext();
        }

        public void BindSignals(IInjectionBinder injectionBinder) {
            
        }

        public void BindViews(IMediationBinder mediationBinder) {
            mediationBinder.Bind<ObjectView>().To<ObjectMediator>();
        }
    }
}
