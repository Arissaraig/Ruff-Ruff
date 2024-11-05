using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public void Pause()
    {
        pauseMenu.SetActive(true);
    }

    public void Home ()
    {
        SceneManager.LoadScene(3);
    }

    public void Play ()
    {
        pauseMenu.SetActive(false);
    }
}
