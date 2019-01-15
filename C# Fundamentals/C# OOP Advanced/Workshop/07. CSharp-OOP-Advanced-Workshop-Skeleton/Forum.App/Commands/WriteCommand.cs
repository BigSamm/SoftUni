namespace Forum.App.Commands
{
    using Forum.App.Contracts;
    using System;

    public class WriteCommand : ICommand
    {
        ISession session;

        public WriteCommand(ISession session)
        {
            this.session = session;
        }

        public IMenu Execute(params string[] args)
        {
            ITextAreaMenu currentMenu = (ITextAreaMenu)this.session.CurrentMenu;
            currentMenu.TextArea.Write();

            return currentMenu;
        }
    }
}
