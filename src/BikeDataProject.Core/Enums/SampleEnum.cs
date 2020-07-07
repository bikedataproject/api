namespace BikeDataProject.Core.Enums
{
    /// <summary>
    /// Contains the <see cref="SampleEnum"/>.
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
