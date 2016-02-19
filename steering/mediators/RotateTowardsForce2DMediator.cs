using deimors.strange.steering.signals;
using deimors.strange.steering.views;
using strange.extensions.mediation.impl;
using UnityEngine;

namespace deimors.strange.steering.mediators {
    class RotateTowardsForce2DMediator : Mediator {
        #region View injection
        [Inject]
        public RotateTowardsForce2DView View { get; set; }
        #endregion

        #region Injected dependencies
        [Inject]
        public SetRotateTargetSignal rotateTargetSignal { get; set; }
        #endregion

        #region Mediator implementation
        public override void OnRegister() {
            rotateTargetSignal.AddListener(View.ObjectID, RotateTargetHandler);
        }

        public override void OnRemove() {
            rotateTargetSignal.RemoveListener(View.ObjectID, RotateTargetHandler);
        }
        #endregion

        #region Internal methods
        private void RotateTargetHandler(Vector2 target) {
            View.TargetDir = target;
        }
        #endregion
    }
}
