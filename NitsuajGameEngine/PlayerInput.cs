using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NitsuajGameEngine
{
    class PlayerInput
    {
        ICommand moveRightCommand;
        ICommand moveLeftCommand;
        ICommand moveUpCommand;
        ICommand moveDownCommand;
        ICommand idleCommand;

        public PlayerInput(ICommand moveRightCommand, ICommand moveLeftCommand, ICommand moveUpCommand, ICommand moveDownCommand, ICommand idleCommand)
        {
            this.moveRightCommand = moveRightCommand;
            this.moveLeftCommand = moveLeftCommand;
            this.moveUpCommand = moveUpCommand;
            this.moveDownCommand = moveDownCommand;
            this.idleCommand = idleCommand;
        }

        public void MoveRight()
        {
            moveRightCommand.Execute();
        }

        public void MoveLeft()
        {
            moveLeftCommand.Execute();
        }

        public void MoveUp()
        {
            moveUpCommand.Execute();
        }

        public void MoveDown()
        {
            moveDownCommand.Execute();
        }

        public void Idle()
        {
            idleCommand.Execute();
        }
    }
}
