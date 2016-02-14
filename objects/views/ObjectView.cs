using deimors.strange.objects.providers;
using strange.extensions.mediation.impl;
using UnityEngine;

namespace deimors.strange.objects.views {
    public class ObjectView : View, IObjectProvider {
		public int objectID = -1;
        public int ObjectID { get { return objectID; } set { objectID = value; } }

		public bool autoAssignID = true;
        public bool AutoAssignID { get { return autoAssignID; } }

        private Transform _trans;

        protected override void Awake() {
            base.Awake();

            _trans = GetComponent<Transform>();
        }

        [HideInInspector]
		public bool Initialized = false;

        public Vector3 ObjectPosition {
            get {
                return _trans.position;
            }
        }

        public Vector3 ObjectDirection {
            get {
                return _trans.forward;
            }
        }

        public Quaternion ObjectRotation {
            get {
                return _trans.rotation;
            }
        }
    }
}