using System.Collections.Generic;
using UnityEngine.Assertions;

namespace deimors.strange.objects.models.impl {
    public class ObjectsModel : IObjectsModel {
        private HashSet<int> _objectIDs = new HashSet<int>();

        public IEnumerable<int> ObjectIDs {
            get {
                return _objectIDs;
            }
        }

        public void AddObject(int objectID) {
            Assert.IsFalse(HasObject(objectID));
            _objectIDs.Add(objectID);
        }

        public void RemoveObject(int objectID) {
            Assert.IsTrue(HasObject(objectID));
            _objectIDs.Remove(objectID);
        }

        public bool HasObject(int objectID) {
            return _objectIDs.Contains(objectID);
        }
    }
}
