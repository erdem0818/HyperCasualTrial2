namespace SlippyRoad
{
    public class PlayerView
    {   
        private int _level;
        public int Level 
        {
            get
            {
                return _level;
            }
            set
            {
                if(value!= _level)
                {
                    _level = value;
                    levelChanged?.Invoke(value);
                    ValueChanged?.Invoke(this);
                }
            }

        }
        private int _highScore;
        public int HighScore 
        {
            get
            {
                return _highScore;
            }
            set
            {
                if(value != _highScore)
                {
                    _highScore = value;
                    highScoreChanged?.Invoke(value);
                    ValueChanged?.Invoke(this);
                }
            }
        }

        public delegate void HighScoreChange(int highScore);
        public event HighScoreChange highScoreChanged;

        public delegate void LevelChange(int level);
        public event LevelChange levelChanged;

        public delegate void ValueChange(PlayerView p);
        public event ValueChange ValueChanged;

        public PlayerView(PlayerData playerData)
        {
            _highScore = playerData.highScore;
            _level = playerData.level;
        }
    }
}


