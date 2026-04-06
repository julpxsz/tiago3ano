using UnityEngine;



public class AudioManager: MonoBehaviour
{
    #region Private Fields

    private List<AudioSource> systemSourceChannels;
    private List<AudioSource> activeSources;
    
    #endregion
    
    public static AudioManager Instance;

    #region singleton
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            systemSourceChannels = new List<AudioSource>();
            activeSources = new List<AudioSource>();

        }
        else
        {
            Destroy(gameObject);
        }
    }

    #endregion

}

internal class List<T>
{
}