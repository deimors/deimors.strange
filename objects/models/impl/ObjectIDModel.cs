namespace deimors.objects.models.impl {
	public class ObjectIDModel : IObjectIDModel {
		private int nextID = 0;

		public int GetNextID()
		{
			return nextID++;
		}
	}
}