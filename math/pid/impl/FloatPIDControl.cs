namespace deimors.strange.math.pid.impl {
    public class FloatPIDControl : PIDControl<float> {
        protected override float add(float v1, float v2) {
            return v1 + v2;
        }

        protected override float sub(float v1, float v2) {
            return v1 - v2;
        }

        protected override float mul(float v1, float s) {
            return v1 * s;
        }

        protected override float div(float v1, float s) {
            return v1 / s;
        }
    }
}
