using deimors.strange.objects.providers;
using UnityEngine;

namespace deimors.strange.objects.models {
    public interface IObjectTransformModel {
        void AddObjectTransform(int objectID, IObjectTransformProvider transformProvider);
        Vector3 GetPosition(int objectID);
        Vector3 GetDirection(int objectID);
        Quaternion GetRotation(int objectID);
    }
}
