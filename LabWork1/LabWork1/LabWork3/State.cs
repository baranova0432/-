using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
    public abstract class State 
    {
        protected Context context;
        protected  ICommand command;

        public ICommand Command
        {
            get => this.command;
            set
            {
                if(value != null)
                {
                    this.command = value;
                }
            }
        }

        public State(ICommand command)
        {
            this.command = command;
        }

        public void SetContext(Context context)
        {
            this.context = context;
        }

        public virtual void Handle(string name)
        {
            Console.WriteLine($"Герой {name}");
            this.command.Execute();
            Console.WriteLine();
        }
    }
}
