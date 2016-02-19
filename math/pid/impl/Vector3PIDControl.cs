using UnityEngine;

namespace deimors.strange.math.pid.impl {
    public class Vector3PIDControl : PIDControl<Vector3> {
        protected override Vector3 add(Vector3 v1, Vector3 v2) {
            return v1 + v2;
        }

        protected override Vector3 sub(Vector3 v1, Vector3 v2) {
            return v1 - v2;
        }

        protected override Vector3 mul(Vector3 v1, float s) {
            return v1 * s;
        }

        protected override Vector3 div(Vector3 v1, float s) {
            return v1 / s;
        }
    }
}
