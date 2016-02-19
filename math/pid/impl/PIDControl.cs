namespace deimors.strange.math.pid.impl {
    public abstract class PIDControl<T> : IPIDControl<T> {
        public PIDControlVars ControlVars { get; set; }

        public PIDData<T> State { get; private set; }

        public PIDControl() { }

        public T Step(float deltaTime, T currentVal, T targetVal) {
            State = NextState(deltaTime, currentVal, targetVal);

            return State.Output;
        }

        private PIDData<T> NextState(float deltaTime, T currentVal, T targetVal) {
            var error = sub(targetVal, currentVal);

            var integral = add(State.Integral, mul(error, deltaTime));

            var derivative = div(sub(error, State.Error), deltaTime);

            var output = add(add(mul(error, ControlVars.ProportionalGain), mul(integral, ControlVars.IntegralGain)), mul(derivative, ControlVars.DerivativeGain));

            return new PIDData<T>(error, integral, output);
        }

        protected abstract T sub(T v1, T v2);
        protected abstract T add(T v1, T v2);
        protected abstract T mul(T v1, float s);
        protected abstract T div(T v1, float s);
    }
}
