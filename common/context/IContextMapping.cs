using strange.extensions.command.api;
using strange.extensions.injector.api;
using strange.extensions.mediation.api;

namespace deimors.strange.common.context {
    public interface IContextMapping {
        void BindModels(IInjectionBinder injectionBinder);
        void BindSignals(IInjectionBinder injectionBinder);
        void BindCommands(ICommandBinder commandBinder);
        void BindViews(IMediationBinder mediationBinder);
    }
}
