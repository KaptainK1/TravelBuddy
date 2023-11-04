using System.ComponentModel;

namespace TravelBuddyApi.Model
{
    public enum RoleType
    {
        [Description("regular")]
        Regular = 1,
        [Description("admin")]
        Admin
    }
}
