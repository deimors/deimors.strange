using System;

namespace deimors.strange.math.pid {
    [Serializable]
    public class PIDControlVars {
        public float ProportionalGain;
        public float IntegralGain;
        public float DerivativeGain;
    }
}
