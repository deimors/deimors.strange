using UnityEngine.Assertions;

using strange.extensions.mediation.impl;

namespace deimors.objects.views {
	public class ObjectChildView : View {
		public ObjectView ObjectParent { get; private set; }

		public int ObjectID {
			get { return ObjectParent != null ? ObjectParent.ObjectID : -1; }
		}

		#region View implementation
		protected override void Awake()
		{
			ObjectParent = GetComponentInParent<ObjectView>();

			Assert.IsNotNull(ObjectParent, "Couldn't find ObjectView on " + gameObject);
		}
		#endregion
	}
}