using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_Lv6
{
    class CareTaker
    {

        private List<Memento> PreviousState = new List<Memento>();

        public Memento GetState(int index)
        {
            return PreviousState[index];
        }
        public Memento GetPreviousState()
        {
            return PreviousState[(PreviousState.Count) - 1];
        }

        public Memento GetFirstState()
        {
            return PreviousState[0];
        }
        public void AddState(Memento state)
        {
            PreviousState.Add(state);
        }

    }

}

