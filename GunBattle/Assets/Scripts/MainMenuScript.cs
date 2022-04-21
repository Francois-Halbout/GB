using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    
    public void LOAD_SCENE()
    {
        SceneManager.LoadScene("SampleScene");
    }

    
    public void QUIT_GAME()
    {
        Application.Quit();
    }
}
