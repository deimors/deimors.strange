using System;
using System.Collections.Generic;

namespace deimors.strange.proximity.models.impl {
    public class ObjectProximityModel : IObjectProximityModel {
		private HashSet<int> objectsInProximity = new HashSet<int>();

		public void AddObjectInProximity(int objectID)
		{
			objectsInProximity.Add(objectID);
		}

		public void RemoveObjectFromProximity(int objectID)
		{
			objectsInProximity.Remove(objectID);
		}

		public void CallbackOnObjectsInProximity(Action<int> callback)
		{
			foreach (int objectID in objectsInProximity) {
				callback(objectID);
			}
		}

		public void Clear() {
			objectsInProximity.Clear();
		}
	}
}