using UnityEngine;

namespace deimors.strange.objects.providers {
    public interface IObjectTransformProvider {
        Vector3 ObjectPosition { get; }
        Vector3 ObjectDirection { get; }
        Quaternion ObjectRotation { get; }
    }
}
