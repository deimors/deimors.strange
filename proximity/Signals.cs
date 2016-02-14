using strange.extensions.signal.impl;

namespace deimors.strange.proximity.signals {
    public class AddToProximitySignal : Signal<int> { };
    public class RemoveFromProximitySignal : Signal<int> { };

    public class ProximityEnteredSignal : Signal<int> { };
    public class ProximityExitedSignal : Signal<int> { };
}
