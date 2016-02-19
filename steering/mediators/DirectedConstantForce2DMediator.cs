using deimors.strange.steering.signals;
using deimors.strange.steering.views;
using strange.extensions.mediation.impl;
using UnityEngine;

namespace deimors.strange.steering.mediators {
    public class DirectedConstantForce2DMediator : Mediator {
        #region View injection
        [Inject]
        public DirectedConstantForce2DView View { get; set; }
        #endregion

        #region Injected dependencies
        [Inject]
        public SetDirectedForceMagSignal forceMagSignal { get; set; }

        [Inject]
        public SetDirectedForceDirSignal forceDirSignal { get; set; }
        #endregion

        #region Mediator implementation
        public override void OnRegister() {
            forceMagSignal.AddListener(View.ObjectID, SetForceMagHandler);
            forceDirSignal.AddListener(View.ObjectID, SetForceDirHandler);
        }

        public override void OnRemove() {
            forceMagSignal.RemoveListener(View.ObjectID, SetForceMagHandler);
            forceDirSignal.RemoveListener(View.ObjectID, SetForceDirHandler);
        }
        #endregion

        #region Signal handlers
        private void SetForceMagHandler(float amount) {
            View.Force = amount;
        }

        private void SetForceDirHandler(Vector2 dir) {
            View.Direction = dir;
        }
        #endregion
    }
}
