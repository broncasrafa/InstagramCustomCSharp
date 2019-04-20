namespace Instagram.Core.Classes.Interfaces
{
    public interface IResult<out TEntity>
    {
        bool Succeeded { get; }
        TEntity Data { get; }
        ResultInfo ResultInfo { get; }
    }
}
