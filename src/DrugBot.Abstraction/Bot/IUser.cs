namespace DrugBot.Core.Bot;

public interface IUser
{
    long Id { get; }
    string Status { get; }
}