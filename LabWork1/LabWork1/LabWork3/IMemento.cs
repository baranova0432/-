using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
    public interface IMemento
    {
        State GetState();

        void SetState(State state);
    }
}
