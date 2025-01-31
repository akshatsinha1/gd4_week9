using UnityEngine;
using UnityEngine.Playables;

public class CutsceneTrigger : MonoBehaviour
{
    PlayableDirector _director;
    public GameObject HUD;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        _director = GetComponent<PlayableDirector>();

        _director.played += cutscenePlayed;

        _director.stopped += cutsceneStopped;


    }

    void cutsceneStopped(PlayableDirector dir)
    {
        HUD.SetActive(true);
    }

    void cutscenePlayed(PlayableDirector dir)
    {
        HUD.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _director.Play();
        }
    }

}
