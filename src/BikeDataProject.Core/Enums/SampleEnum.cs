namespace BikeDataProject.Core.Enums
{
    /// <summary>
    /// Contains the Sample enumeration.
    /// </summary>
    public enum SampleEnum
    {
        None = 0x0,
        User = 0x2,
        VerifiedUser = 0x4,
        Admin = User | VerifiedUser | 0x8,
        SuperAdmin = Admin | 0x16
    }
}
