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
        ICommand idleRightCommand;
        ICommand idleLeftCommand;
        ICommand idleUpCommand;
        ICommand idleDownCommand;
        ICommand attackRightCommand;
        ICommand attackLeftCommand;
        ICommand attackUpCommand;
        ICommand attackDownCommand;

        enum InputState
        {
            right, left, up, down
        }

        InputState inputState;
        bool idling = true; // this used to keep the setAnimation function from being called
        bool attack = false;

        public PlayerInput(ICommand moveRightCommand, ICommand moveLeftCommand, ICommand moveUpCommand, ICommand moveDownCommand, ICommand idleRightCommand, ICommand idleLeftCommand, ICommand idleUpCommand, ICommand idleDownCommand, ICommand attackRightCommand, ICommand attackLeftCommand, ICommand attackUpCommand, ICommand attackDownCommand)
        {
            this.moveRightCommand = moveRightCommand;
            this.moveLeftCommand = moveLeftCommand;
            this.moveUpCommand = moveUpCommand;
            this.moveDownCommand = moveDownCommand;

            this.idleRightCommand = idleRightCommand;
            this.idleLeftCommand = idleLeftCommand;
            this.idleUpCommand = idleUpCommand;
            this.idleDownCommand = idleDownCommand;

            this.attackRightCommand = attackRightCommand;
            this.attackLeftCommand = attackLeftCommand;
            this.attackUpCommand = attackUpCommand;
            this.attackDownCommand = attackDownCommand;

            inputState = new InputState();
        }

        public void MoveRight()
        {
            moveRightCommand.Execute();
            inputState = InputState.right;
            idling = false;
        }

        public void MoveLeft()
        {
            moveLeftCommand.Execute();
            inputState = InputState.left;
            idling = false;
        }

        public void MoveUp()
        {
            moveUpCommand.Execute();
            inputState = InputState.up;
            idling = false;
        }

        public void MoveDown()
        {
            moveDownCommand.Execute();
            inputState = InputState.down;
            idling = false;
        }

        public void Idle()
        {
            if (idling)
                return;

            idling = false;

            switch(inputState)
            {
                case InputState.right: idleRightCommand.Execute(); break;
                case InputState.left: idleLeftCommand.Execute(); break;
                case InputState.up: idleUpCommand.Execute(); break;
                case InputState.down: idleDownCommand.Execute(); break;
            }
        }

        public void Attack()
        {
            if (attack)
                return;

            attack = true;
            idling = false;

            switch (inputState)
            {
                case InputState.right: attackRightCommand.Execute(); break;
                case InputState.left: attackLeftCommand.Execute(); break;
                case InputState.up: attackUpCommand.Execute(); break;
                case InputState.down: attackDownCommand.Execute(); break;
            }
        }

        public void ResetAttack()
        {
            attack = false;
        }
    }
}
