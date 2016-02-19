using deimors.strange.common.signals;
using UnityEngine;

namespace deimors.strange.steering.signals {
    public class SetRotateTargetSignal : IndexedSignal<int, Vector2> { }
    public class SetDirectedForceMagSignal : IndexedSignal<int, float> { }
    public class SetDirectedForceDirSignal : IndexedSignal<int, Vector2> { }
}
