using deimors.strange.proximity.signals;
using deimors.strange.proximity.views;
using strange.extensions.mediation.impl;

namespace deimors.strange.proximity.mediators {
    public class ProximityCollider2DMediator : Mediator {
		#region View implementation
		[Inject]
		public ProximityCollider2DView View { get; set; }

		[Inject]
		public AddToProximitySignal proximityEnterSignal { get; set; }

		[Inject]
		public RemoveFromProximitySignal proximityExitSignal { get; set; }
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