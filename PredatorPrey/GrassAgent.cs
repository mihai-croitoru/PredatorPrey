using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ActressMas;
using System.Threading.Tasks;

namespace PredatorPrey
{
    class GrassAgent :  CreatureAgent
    {

        public override void Setup()
        {
            _turnsSurvived = 0;

            _worldEnv = (World)this.Environment;

            if (Utils.Verbose)
                Console.WriteLine("AntAgent {0} started in ({1},{2})", this.Name, Line, Column);
        }

        public override void Act(Queue<Message> messages)
        {
            if (messages.Count > 0)
            {
                Message message = messages.Dequeue();
                if (Utils.Verbose)
                    Console.WriteLine("\t[{1} -> {0}]: {2}", this.Name, message.Sender, message.Content);

                GrassAction();
                Send("scheduler", "done");
            }
        }

        private void GrassAction()
        {
            _turnsSurvived++;

            // breed
            if (_turnsSurvived >= Utils.NoTurnsUntilGrassBreeds)
            {
                if (TryToBreed()) // implemented in base class CreatureAgent
                    _turnsSurvived = 0;
            }
        }
    }
}



