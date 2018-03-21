using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interface
{
    class Mission:IMission
    {
        public string CodeName { get; private set; }
        public State State { get; private set; }

        public Mission(string codeName,string misionState)
        {
            CodeName = codeName;
            ParsseMissionState(misionState);
        }

        private void ParsseMissionState(string misionState)
        {
            bool valid = Enum.TryParse(typeof(State), misionState, out object validatResult);
            if (!valid)
            {
                throw new ArgumentException("nooso");
            }
            State = (State)validatResult;
        }

        public void Complyte()
        {
            this.State = Interface.State.Finished;
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {State}";
        }
    }
}
