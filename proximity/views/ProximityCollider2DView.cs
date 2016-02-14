using System;
using UnityEngine;

using deimors.strange.objects.views;

namespace deimors.strange.proximity.views {
    public class ProximityCollider2DView : ObjectChildView {
		#region Public properties
		public LayerMask TriggerLayers;
		#endregion

		#region Events
		public event Action TriggerEnter = delegate { };
		public event Action TriggerExit = delegate { };
		#endregion

		#region Unity methods
		void OnTriggerEnter2D(Collider2D other) {
			if (IsOnTriggerLayer(other)) TriggerEnter();
		}

		void OnTriggerExit2D(Collider2D other) {
			if (IsOnTriggerLayer(other)) TriggerExit();
		}
		#endregion

		#region Private methods
		private bool IsOnTriggerLayer(Collider2D other) {
			return ((1 << other.gameObject.layer) & TriggerLayers) != 0;
		}
		#endregion
	}
}