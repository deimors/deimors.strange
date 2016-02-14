using strange.extensions.mediation.impl;
using UnityEngine;

namespace deimors.strange.camera.views {
    [RequireComponent(typeof(Rigidbody2D))]
	public class CameraFollowView : View {
		public Transform FollowObject;

		public float yFollowMax = 1;
		public float xFollowMax = 1;

		public float baseFollowVelocity = 0.5f;

		private Rigidbody2D _rigidbody;

		#region View implementation
		protected override void Awake()
		{
            base.Awake();
			_rigidbody = GetComponent<Rigidbody2D>();
		}
		#endregion

		#region Unity methods
		void LateUpdate() {
			Vector2 posDiff = FollowObject.position - transform.position;

			var yDiff = Vector2.Dot(posDiff, Vector2.up);
			var xDiff = Vector2.Dot(posDiff, Vector2.right);

			var yAbsDiff = Mathf.Abs(yDiff);
			var xAbsDiff = Mathf.Abs(xDiff);

			Vector2 newVelocity = Vector2.zero;

			if (yAbsDiff > yFollowMax) {
				newVelocity += (Vector2.up * yDiff).normalized * (baseFollowVelocity + (yAbsDiff - yFollowMax) * (yAbsDiff - yFollowMax));
			}

			if (xAbsDiff > xFollowMax) {
				newVelocity += (Vector2.right * xDiff).normalized * (baseFollowVelocity + (xAbsDiff - xFollowMax) * (xAbsDiff - xFollowMax));
			}

			_rigidbody.velocity = newVelocity;
		}
		#endregion

	}
}