namespace deimors.strange.objects.providers {
    public interface IObjectIDProvider {
        int ObjectID { get; set; }
        bool AutoAssignID { get; }
    }
}
