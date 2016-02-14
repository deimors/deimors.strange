using deimors.strange.objects.providers;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace deimors.strange.objects.models.impl {
    public class ObjectTransformModel : IObjectTransformModel {
        private Dictionary<int, IObjectTransformProvider> transformProviders = new Dictionary<int, IObjectTransformProvider>();

        public void AddObjectTransform(int objectID, IObjectTransformProvider transformProvider) {
            Assert.IsFalse(transformProviders.ContainsKey(objectID));

            transformProviders.Add(objectID, transformProvider);
        }

        public Vector3 GetDirection(int objectID) {
            Assert.IsTrue(transformProviders.ContainsKey(objectID));

            return transformProviders[objectID].ObjectDirection;
        }

        public Vector3 GetPosition(int objectID) {
            Assert.IsTrue(transformProviders.ContainsKey(objectID));

            return transformProviders[objectID].ObjectPosition;
        }

        public Quaternion GetRotation(int objectID) {
            Assert.IsTrue(transformProviders.ContainsKey(objectID));

            return transformProviders[objectID].ObjectRotation;
        }
    }
}
