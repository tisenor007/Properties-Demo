using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Player
    {
        //public readonly string name;

        private string _name = "Player";
        public string Name
        {
            get { return _name; }
        }
        private int health;
        private int _shield;
        
        //Actual GETS AND SETS
        //could also add range checking.....
        public int Shield
        {
            get { return _shield; }
            set { _shield = value; }
        }

        //GET and SET methods
        public int GetHealth()
        {
            return health;
        }

        public void SetHealth(int value)
        {
            health = value;
        }

    }
}
