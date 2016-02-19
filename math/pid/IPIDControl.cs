namespace deimors.strange.math.pid {
    public interface IPIDControl<T> {
        PIDControlVars ControlVars { get; set; }
        PIDData<T> State { get; }
        T Step(float deltaTime, T currentVal, T targetVal);
    }
}
