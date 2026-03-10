
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{

    public string mainMenuScene = "MainMenu";

    public static LevelManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Debug.Log("LevelManager created!", this.gameObject);
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Debug.LogError("LevelManager exists already! Destroying duplicate!");
            Destroy(gameObject);
        }
    }

    private void Start()
    {

        LoadLevel(mainMenuScene);
    }


    public void LoadLevel(string levelName)
    {

        try
        {
            SceneManager.LoadScene(levelName);

        }
        catch (System.Exception ex)
        {

            Debug.LogError("Cannot change into scene '" + levelName + "'");
            Debug.LogError(ex.Message);
        }
    }



}