using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.scripts.Player
{
    [System.Serializable]
    public class PlayerData
    {
        public Data playerData;
        public PlayerData() { }
        public PlayerData(int _score,int _money)
        {
            playerData=new Data(_score, _money);
        }
        [System.Serializable]
        public struct Data
        {
            public int _score, _money;
            public Data(int _score, int _money)
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
}
