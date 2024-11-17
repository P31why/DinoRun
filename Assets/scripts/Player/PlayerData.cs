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
        public PlayerData(int _score,int _money, List<DinoSkin> unlSkins,int skinSet)
        {
            playerData=new Data(_score, _money,unlSkins,skinSet);
        }
        [System.Serializable]
        public struct Data
        {
            public int _score, _money,skinSet;
            public List<DinoSkin> unlockSkins;
            public Data(int _score, int _money, List<DinoSkin> unlockSkins,int skinSet)
            {
                this._score = _score;
                this._money = _money;
                this.skinSet = skinSet;
                this.unlockSkins = unlockSkins;
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
