using deimors.strange.proximity.models;
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
		#endregion

		#region Command implementation
		public override void Execute()
		{
			proximityModel.AddObjectInProximity(ObjectID);
		}
		#endregion
	}
}