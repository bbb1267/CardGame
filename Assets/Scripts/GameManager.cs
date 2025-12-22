using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject panelSettings;
    void Start()
    {
        if (panelSettings != null)
            panelSettings.SetActive(false);
    }

    public void Play()
    {
        SceneManager.LoadScene("Play");
    }
    
    public void Back()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Settings()
    {
        if (panelSettings.activeSelf == false)
        {
            Debug.Log("false");
            panelSettings.SetActive(true);
        }
        else if (panelSettings.activeSelf == true)
        {
            panelSettings.SetActive(false);
        }
    }

    public void Exit()
    {
        Application.Quit();
    }
}
