using deimors.strange.math.pid;
using deimors.strange.math.pid.impl;
using deimors.strange.objects.views;
using strange.extensions.mediation.impl;
using UnityEngine;
using UnityEngine.Assertions;

namespace deimors.strange.steering.views {
    public class RotateTowardsForce2DView : ObjectChildView {
        public GameObject ControlObject;

        public Vector2 TargetDir = Vector2.up;

        public float MaxForce = 2.0f;

        public PIDControlVars ControlVars = new PIDControlVars { ProportionalGain = 10f, IntegralGain = 0.5f, DerivativeGain = 3f };

        private Rigidbody2D _rigidBody2D;
        private Transform _transform;

        private IPIDControl<float> pidControl;

        protected override void Awake() {
            base.Awake();

            if (ControlObject == null) { ControlObject = gameObject; }

            _rigidBody2D = ControlObject.GetComponent<Rigidbody2D>();
            Assert.IsNotNull(_rigidBody2D);

            _transform = ControlObject.GetComponent<Transform>();

            pidControl = new FloatPIDControl { ControlVars = ControlVars };
        }

        void FixedUpdate() {
            pidControl.ControlVars = ControlVars;

            ApplyTorque(pidControl.Step(Time.fixedDeltaTime, AngleToTarget, 0));
        }

        private void ApplyTorque(float amount) {
            var scaledForce = Mathf.Clamp(amount * Time.fixedDeltaTime, -MaxForce, MaxForce);
            _rigidBody2D.AddTorque(scaledForce);
        }

        private float AngleToTarget {
            get {
                return Vector2.Angle(_transform.up, TargetDir) * -Mathf.Sign(Vector3.Cross(_transform.up, TargetDir).z);
            }
        }
    }
}
