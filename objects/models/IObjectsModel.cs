using System.Collections.Generic;

namespace deimors.strange.objects.models {
    public interface IObjectsModel {
        void AddObject(int objectID);
        void RemoveObject(int objectID);
        bool HasObject(int objectID);
        IEnumerable<int> ObjectIDs { get; }
    }
}
