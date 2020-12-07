

namespace LabWork1
{
    public class Context
    {
        private State state = null;
        private string name = null;

        public Context(State state, string name)
        {
            this.name = name;
            this.Update(state);
        }

        public void Update(State state)
        {
            this.state = state;
            this.state.SetContext(this);
        }

        public void Request()
        {
            this.state.Handle(name);
        }

        public IMemento GetMemento()
        {
            return new Memento.Memento(this.state);
        }
    }
}
