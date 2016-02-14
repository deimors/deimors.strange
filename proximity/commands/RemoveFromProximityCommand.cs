using deimors.strange.proximity.models;
using deimors.strange.proximity.signals;
using strange.extensions.command.impl;

namespace deimors.strange.proximity.commands {
    public class RemoveFromProximityCommand : Command {
		#region Signal parameters
		[Inject]
		public int ObjectID { get; set; }
		#endregion

		#region Injected dependencies
		[Inject]
		public IObjectProximityModel proximityModel { get; set; }

        [Inject]
        public ProximityExitedSignal exitSignal { get; set; }
		#endregion

		#region Command implementation
		public override void Execute()
		{
			proximityModel.RemoveObjectFromProximity(ObjectID);
            exitSignal.Dispatch(ObjectID);
		}
		#endregion
	}
}