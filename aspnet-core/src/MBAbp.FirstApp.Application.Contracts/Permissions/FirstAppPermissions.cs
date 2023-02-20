namespace MBAbp.FirstApp.Permissions;

public static class FirstAppPermissions
{
    public const string GroupName = "FirstApp";

    public static class Books
    {
        public const string Default = GroupName + ".Books";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
