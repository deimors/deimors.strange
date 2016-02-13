using deimors.objects.models;
using deimors.objects.signals;
using deimors.objects.views;
using strange.extensions.mediation.impl;
using UnityEngine.Assertions;

namespace deimors.objects.mediators {
	public class ObjectMediator : Mediator {
		#region View injection
		[Inject]
		public ObjectView View { get; set; }

		[Inject]
		public IObjectIDModel objectIDModel { get; set; }

		[Inject]
		public InitializeObjectSignal initializeObjectSignal { get; set; }
		#endregion

		#region Mediator implementation
		public override void OnEnabled()
		{
			if (!View.Initialized) {
				Assert.IsFalse(!View.AutoAssignID && View.ObjectID >= -1, "Pre-assigned ObjectIDs must be < -1 (not " + View.ObjectID + ")");

				if (View.AutoAssignID) {
					View.ObjectID = objectIDModel.GetNextID();
				}

				initializeObjectSignal.Dispatch(View.ObjectID, gameObject);

				View.Initialized = true;
			}
		}
		#endregion
	}
}