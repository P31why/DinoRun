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
        public PlayerData(int _score,int _money, List<DinoSkin> unlSkins,int skinSet, List<MusicDisk> unlockDisks)
        {
            playerData=new Data(_score, _money,unlSkins,skinSet,unlockDisks);
        }
        [System.Serializable]
        public struct Data
        {
            public int _score, _money,skinSet;
            public List<DinoSkin> unlockSkins;
            public List<MusicDisk> unlockDisks;
            public Data(int _score, int _money, List<DinoSkin> unlockSkins,int skinSet, List<MusicDisk> unlockDisks)
            {
                this._score = _score;
                this._money = _money;
                this.skinSet = skinSet;
                this.unlockSkins = unlockSkins;
                this.unlockDisks = unlockDisks;
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
