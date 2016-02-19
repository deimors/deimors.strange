using System;

namespace deimors.strange.math.pid {
    [Serializable]
    public struct PIDData<T> {
        public T Error;
        public T Integral;
        public T Output;

        public PIDData(T error, T integral, T output) {
            Error = error;
            Integral = integral;
            Output = output;
        }
    }
}
