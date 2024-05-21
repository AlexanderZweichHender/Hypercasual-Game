using _Project.Constants;
using UnityEngine.SceneManagement;

namespace _Project.Services
{
    public class SceneLoader
    {
        public static void LoadMenu()
        {
            SceneManager.LoadScene(GlobalConstants.MENU_SCENE);
        }

        public static void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public static void LoadLevel(Dificult dificult)
        {
            switch(dificult)
            {
                case Dificult.Easy:
                    SaveService.Dificult = Dificult.Easy;
                    SceneManager.LoadScene("Level");
                    break;
                case Dificult.Middle:
                    SaveService.Dificult = Dificult.Middle;
                    SceneManager.LoadScene("Level1");
                    break;
                case Dificult.Hard:
                    SaveService.Dificult = Dificult.Hard;
                    SceneManager.LoadScene("Level2");
                    break;
            }
        }
    }
}
