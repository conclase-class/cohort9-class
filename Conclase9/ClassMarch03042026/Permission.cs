namespace Conclase9.ClassMarch03042026
{
    [Flags]
    public enum Permission
    {
        None,
        Read = 1 << 1, //2^1 - 0010
        Create = 1 << 2, //2^2 - 0100
        Update = 1 << 3, //2^3 - 1000
        Delete = 1 << 4 //2^4 - 0001 0000
    }
}