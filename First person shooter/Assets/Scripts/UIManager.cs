using UnityEngine;

public class UIManager : MonoBehaviour
{

    public GameObject MainMenuPanel;    // UI Paneeli Main Menua varten
    public GameObject HUDPanel;         // UI Paneeli HUD:ia varten

    public static UIManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Debug.Log("UIManager created!", this.gameObject);
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Debug.LogError("UIManager exists already! Destroying duplicate!");
            Destroy(gameObject);
        }
    }

    public void ShowMainMenuPanel()
    {
        MainMenuPanel.SetActive(true);
        HUDPanel.SetActive(false);
    }

    public void ShowHUDPanel()
    {
        HUDPanel.SetActive(true);
        MainMenuPanel.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}