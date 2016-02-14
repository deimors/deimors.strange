using deimors.strange.proximity.models;
using deimors.strange.proximity.signals;
using strange.extensions.command.impl;

namespace deimors.strange.proximity.commands {
    public class AddToProximityCommand : Command {
		#region Signal parameters
		[Inject]
		public int ObjectID { get; set; }
		#endregion

		#region Injected dependencies
		[Inject]
		public IObjectProximityModel proximityModel { get; set; }

        [Inject]
        public ProximityEnteredSignal enterSignal { get; set; }
		#endregion

		#region Command implementation
		public override void Execute()
		{
			proximityModel.AddObjectInProximity(ObjectID);
            enterSignal.Dispatch(ObjectID);
		}
		#endregion
	}
}