using deimors.strange.objects.models;
using deimors.strange.objects.providers;
using strange.extensions.command.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deimors.strange.objects.commands {
    public class InitializeObjectCommand : Command {
        #region Signal parameters
        [Inject]
        public IObjectProvider ObjectProvider { get; set; }
        #endregion

        #region Injected dependencies
        [Inject]
        public IObjectIDModel objectIDModel { get; set; }

        [Inject]
        public IObjectTransformModel objectTransformModel { get; set; }

        [Inject]
        public IObjectsModel objectsModel { get; set; }
        #endregion

        #region Command implementation
        public override void Execute() {
            if (objectsModel.HasObject(ObjectProvider.ObjectID)) return;

            if (ObjectProvider.AutoAssignID) {
                ObjectProvider.ObjectID = objectIDModel.GetNextID();
            }

            objectsModel.AddObject(ObjectProvider.ObjectID);

            objectTransformModel.AddObjectTransform(ObjectProvider.ObjectID, ObjectProvider);
        }
        #endregion
    }
}
