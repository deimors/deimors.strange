using strange.extensions.mediation.impl;
using deimors.strange.objects.views;

namespace deimors.strange.objects.mediators {
    public class ProximityColliderMediator : Mediator {
		#region View implementation
		[Inject]
		public ProximityCollider2DView View { get; set; }

		[Inject]
		public ProximityEnterSignal proximityEnterSignal { get; set; }

		[Inject]
		public ProximityExitSignal proximityExitSignal { get; set; }
		#endregion

		#region Mediator implementation
		public override void OnRegister()
		{
			View.TriggerEnter += OnTriggerEnter;
			View.TriggerExit += OnTriggerExit;
		}

		public override void OnRemove()
		{
			View.TriggerEnter -= OnTriggerEnter;
			View.TriggerExit -= OnTriggerExit;
		}
		#endregion

		#region Internal methods
		private void OnTriggerEnter() {
			proximityEnterSignal.Dispatch(View.ObjectID);
		}

		private void OnTriggerExit() {
			proximityExitSignal.Dispatch(View.ObjectID);
		}
		#endregion
	}
}