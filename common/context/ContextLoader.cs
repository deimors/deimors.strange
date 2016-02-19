using UnityEngine;

namespace deimors.strange.common.context {
	public class ContextLoader : MonoBehaviour {
		public GameObject[] Contexts;

		private LoadableContextView[] ContextViews;

		public void Start() {
			BuildContextViews();

			BuildContexts();

			StartContexts();
		}

		private void BuildContextViews() {
			if (Contexts == null) {
				throw new UnityException("Context is null");
			}
			
			ContextViews = new LoadableContextView[Contexts.Length];
			
			for (int i = 0; i < Contexts.Length; i++) {
				ContextViews[i] = GetLoadableContextView(i);
			}
		}

		private void BuildContexts() {
			if (ContextViews == null || ContextViews.Length != Contexts.Length) {
				throw new UnityException("ContextViews not initialized");
			}

			for (int i = 0; i < ContextViews.Length; i++) {
				ContextViews[i].BuildContext();
			}
		}

		private void StartContexts() {
			if (ContextViews == null || ContextViews.Length != Contexts.Length) {
				throw new UnityException("ContextViews not initialized");
			}

			for (int i = 0; i < ContextViews.Length; i++) {
				ContextViews[i].StartContext();
			}
		}

		private LoadableContextView GetLoadableContextView(int i) {
			GameObject contextGO = GetContextGameObject(i);
			
			LoadableContextView contextView = contextGO.GetComponent<LoadableContextView>();
			
			if (contextView == null) {
				throw new UnityException(contextGO.name + " does not contain a LoadableContextView");
			}

			return contextView;
		}

		private GameObject GetContextGameObject(int i) {
			if (IsGameObjectInHierarchy(Contexts[i])) {
				return Contexts[i];
			} else {
				return Instantiate<GameObject>(Contexts[i]);
			}
		}

		private bool IsGameObjectInHierarchy(GameObject go) {
			return GameObject.Find(go.name) != null;
		}
	}
}