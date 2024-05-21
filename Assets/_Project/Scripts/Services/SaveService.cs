using _Project.Constants;
using UnityEngine;

namespace _Project.Services
{
    public static class SaveService
    {
        public static int Money
        {
            get
            {
                if (!PlayerPrefs.HasKey(GlobalConstants.MONEY_KEY))
                {
                    PlayerPrefs.SetInt(GlobalConstants.MONEY_KEY, 0);
                    PlayerPrefs.Save();

                    return 0;
                }
                else
                {
                    return PlayerPrefs.GetInt(GlobalConstants.MONEY_KEY);
                }
            }

            set
            {
                PlayerPrefs.SetInt(GlobalConstants.MONEY_KEY, value);
                PlayerPrefs.Save();
            }
        }

        public static bool Sound
        {
            get
            {
                if (!PlayerPrefs.HasKey(GlobalConstants.SOUND_KEY))
                {
                    PlayerPrefs.SetInt(GlobalConstants.SOUND_KEY, 0);
                    PlayerPrefs.Save();

                    return false;
                }
                else
                {
                    return PlayerPrefs.GetInt(GlobalConstants.SOUND_KEY) == 1 ? true : false;
                }
            }

            set
            {
                if (value)
                    PlayerPrefs.SetInt(GlobalConstants.SOUND_KEY, 1);
                else
                    PlayerPrefs.SetInt(GlobalConstants.SOUND_KEY, 0);

                PlayerPrefs.Save();
            }
        }

        public static bool Music
        {
            get
            {
                if (!PlayerPrefs.HasKey(GlobalConstants.MUSIC_KEY))
                {
                    PlayerPrefs.SetInt(GlobalConstants.MUSIC_KEY, 0);
                    PlayerPrefs.Save();

                    return false;
                }
                else
                {
                    return PlayerPrefs.GetInt(GlobalConstants.MUSIC_KEY) == 1 ? true : false;
                }
            }

            set
            {
                if (value)
                    PlayerPrefs.SetInt(GlobalConstants.MUSIC_KEY, 1);
                else
                    PlayerPrefs.SetInt(GlobalConstants.MUSIC_KEY, 0);

                PlayerPrefs.Save();
            }
        }

        public static Dificult Dificult
        {
            get
            {
                if (!PlayerPrefs.HasKey(GlobalConstants.DIFICULT_KEY))
                {
                    PlayerPrefs.SetInt(GlobalConstants.DIFICULT_KEY, 0);
                    PlayerPrefs.Save();

                    return Dificult.Easy;
                }
                else
                {
                    switch(PlayerPrefs.GetInt(GlobalConstants.DIFICULT_KEY))
                    {
                        case 0:
                            return Dificult.Easy;
                        case 1:
                            return Dificult.Middle;
                        case 2:
                            return Dificult.Hard;
                        default:
                            return Dificult.Easy;
                    }
                }
            }

            set
            {
                switch(value)
                {
                    case Dificult.Easy:
                        PlayerPrefs.SetInt(GlobalConstants.DIFICULT_KEY, 0);
                        return;
                    case Dificult.Middle:
                        PlayerPrefs.SetInt(GlobalConstants.DIFICULT_KEY, 1);
                        return;
                    case Dificult.Hard:
                        PlayerPrefs.SetInt(GlobalConstants.DIFICULT_KEY, 2);
                        return;
                }
            }
        }

        public static int Reward
        {
            get
            {
                switch(Dificult)
                {
                    case Dificult.Easy:
                        return 10;
                    case Dificult.Middle:
                        return 30;
                    case Dificult.Hard:
                        return 50;
                    default:
                        return 10;
                }
            }
        }

        public static int Skin
        {
            get
            {
                if (!PlayerPrefs.HasKey(GlobalConstants.SKIN_KEY))
                {
                    PlayerPrefs.SetInt(GlobalConstants.SKIN_KEY, 0);
                    PlayerPrefs.Save();

                    return 0;
                }
                else
                {
                    return PlayerPrefs.GetInt(GlobalConstants.SKIN_KEY);
                }
            }

            set
            {
                PlayerPrefs.SetInt(GlobalConstants.SKIN_KEY, value);
                PlayerPrefs.Save();
            }
        }
    }
}

namespace _Project.Constants
{
    public struct GlobalConstants
    {
        public const string MONEY_KEY = "Money";
        public const string SOUND_KEY = "Sound";
        public const string MUSIC_KEY = "Music";
        public const string DIFICULT_KEY = "Dificult";
        public const string SKIN_KEY = "Skin";

        public const string MENU_SCENE = "Menu";
    }

    public enum Dificult
    {
        Easy,
        Middle,
        Hard
    }

    public enum Skin
    {
        Squirrel,
        Panda,
        Tiger
    }
}
