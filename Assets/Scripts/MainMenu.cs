using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NewGame()
    {
<<<<<<< Updated upstream
        SceneManager.LoadSceneAsync("Cutscene");
=======
        SceneManager.LoadSceneAsync("Cave_1");
>>>>>>> Stashed changes
    }
    public void Options()
    {
        SceneManager.LoadSceneAsync("Options");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
