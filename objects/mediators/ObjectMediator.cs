﻿using deimors.strange.objects.signals;
using deimors.strange.objects.views;
using strange.extensions.mediation.impl;

namespace deimors.strange.objects.mediators {
    public class ObjectMediator : Mediator {
		#region View injection
		[Inject]
		public ObjectView View { get; set; }

		[Inject]
		public InitializeObjectSignal initializeObjectSignal { get; set; }
		#endregion

		#region Mediator implementation
		public override void OnEnabled()
		{
            initializeObjectSignal.Dispatch(View);            
		}
		#endregion
	}
}