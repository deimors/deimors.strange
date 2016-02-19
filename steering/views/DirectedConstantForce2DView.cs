using deimors.strange.objects.views;
using UnityEngine;
using UnityEngine.Assertions;

namespace deimors.strange.steering.views {
    public class DirectedConstantForce2DView : ObjectChildView {
        public GameObject ControlObject;

        public Vector2 Direction = Vector2.up;
        public float Force = 1.0f;

        private Rigidbody2D _rigidBody2D;
        private Transform _transform;

        protected override void Awake() {
            base.Awake();

            if (ControlObject == null) { ControlObject = gameObject; }

            _rigidBody2D = ControlObject.GetComponent<Rigidbody2D>();
            Assert.IsNotNull(_rigidBody2D);

            _transform = ControlObject.GetComponent<Transform>();
        }

        void FixedUpdate() {
            Direction = Direction.normalized;

            var forceDir = _transform.TransformDirection(Direction);

            _rigidBody2D.AddForce(Force * forceDir * Time.fixedDeltaTime);
        }
    }
}
