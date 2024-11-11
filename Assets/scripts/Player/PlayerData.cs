using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.scripts.Player
{
    public class PlayerData
    {
        private int _score;
        private int _money;
        public PlayerData() { }
        public PlayerData(int _score,int _money)
        {
            this._score = _score;
            this._money = _money;
        }
        public int Score
        {
            get => _score;
            set => _score = value;
        }
        public int Money
        {
            get => _money;
            set => _money = value;
        }
    }
}
