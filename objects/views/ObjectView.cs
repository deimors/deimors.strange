using strange.extensions.mediation.impl;
using UnityEngine;

namespace deimors.strange.objects.views {
	public class ObjectView : View {
		public int ObjectID = -1;

		public bool AutoAssignID = true;

		[HideInInspector]
		public bool Initialized = false;
	}
}