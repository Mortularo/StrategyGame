<<<<<<< Updated upstream
namespace Abstractions.Commands.CommandInterfaces
{
    public interface IAttackCommand
    {

    }
=======
public interface IAttackCommand : ICommand
{
    public IAttackable Target { get; }
>>>>>>> Stashed changes
}