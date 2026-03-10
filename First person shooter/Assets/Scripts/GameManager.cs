using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PlayerObj;                // referenssi pelaajaan

    public static GameManager Instance;         // staattinen instanssi GameManagerista

    private void Awake()
    {
        // Tarkistetaan onko GameManager olemassa vai ei
        if (Instance == null)
        {
            Debug.Log("GameManager created!", this.gameObject);
            Instance = this;                    // Asetetaan TÄMÄ GameManager instanssiksi
            DontDestroyOnLoad(gameObject);      // Estetään tämän GameManagerin tuhoutuminen scenejen vaihtuessa
        }
        else
        {
            Debug.LogError("GameManager exists already! Destroying duplicate!");
            Destroy(gameObject);                 // Jos GameManager on jo olemassa, tuhotaan tämä ylimääräinen GameManager
        }

    }


}