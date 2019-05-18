namespace Yahtzee.Model
{
    interface IBot : IPlayer
    {
        ICommand DoSomething(IGame game);
    }
}