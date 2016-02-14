using strange.extensions.context.api;
using strange.extensions.context.impl;

namespace deimors.strange.common.context {
	public abstract class LoadableContextView : ContextView {
		protected abstract IContext InstantiateContext();

		public void BuildContext() {
			context = InstantiateContext();
		}

		public void StartContext() {
			context.Start();
		}
	}
}