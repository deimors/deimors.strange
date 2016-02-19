using strange.extensions.context.impl;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace deimors.strange.common.context {
    public class MappedContext : MVCSContext {
        protected IEnumerable<IContextMapping> Mappings;

        public MappedContext(MonoBehaviour view, bool autoMap) : base(view, autoMap) { }

        protected override void mapBindings() {
            Assert.IsNotNull(Mappings, "Mappings not assigned in MappedContext");

            foreach (var mapping in Mappings) {
                mapping.BindModels(injectionBinder);
            }

            foreach (var mapping in Mappings) {
                mapping.BindSignals(injectionBinder);
            }

            foreach (var mapping in Mappings) {
                mapping.BindCommands(commandBinder);
            }

            foreach (var mapping in Mappings) {
                mapping.BindViews(mediationBinder);
            }
        }
    }
}
