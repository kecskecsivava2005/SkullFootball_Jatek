using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Megmarad Scene váltáskor
        }
        else
        {
            Destroy(gameObject); // Ha már létezik, ne legyen belõle több
        }
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            Destroy(gameObject);
        }
    }
}
