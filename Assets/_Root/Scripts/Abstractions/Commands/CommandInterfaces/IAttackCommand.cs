namespace Abstractions.Commands.CommandInterfaces
{
    public interface IAttackCommand : ICommand
    {
        public IGetDamage Target { get; }
    }
}