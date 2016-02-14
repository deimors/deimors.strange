using System;

namespace deimors.strange.proximity.models {
    public interface IObjectProximityModel {
		void AddObjectInProximity(int objectID);

		void RemoveObjectFromProximity(int objectID);

		void CallbackOnObjectsInProximity(Action<int> callback);

		void Clear();
	}
}