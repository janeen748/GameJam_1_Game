using UnityEngine;

public class MusicSelection : MonoBehaviour
{
    public AudioSource[] musicSource;

    public int trackSelection;
    public int trackHistory;


    void Start()
    {
        trackSelection = Random.Range(0, musicSource.Length);

        if (trackSelection == 0)
        {
            musicSource[trackSelection].Play();
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (!musicSource[trackSelection].isPlaying)
        {
            trackHistory = trackSelection;
            while (trackHistory == trackSelection && trackHistory != trackSelection)
            {
                trackSelection = Random.Range(0, musicSource.Length);
            }
            musicSource[trackSelection].Play();
        }





    }

}
