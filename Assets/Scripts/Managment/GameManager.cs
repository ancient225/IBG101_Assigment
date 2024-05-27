using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject Player;
    public Text PickUpText;
    public AudioSource[] audioSources;
    public float audioProx = 5.0f;

    public int CurrentPickUps = 0;
    public int MaxPickUps = 7;
    public bool LevelComplete = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LevelCompleteCheck();
        updateGUI();
        PlayAudioSample();
    }

    private void PlayAudioSample()
    {
        for (int i = 0; i < audioSources.Length; i++)
        {
            if (audioSources[i] != null)
            {
                if (Vector3.Distance(Player.transform.position, audioSources[i].transform.position) <= audioProx)
                {
                    if (!audioSources[i].isPlaying)
                    {
                        audioSources[i].Play();
                    }
                }
            }
        }
    }

    private void updateGUI()
    {
        PickUpText.text = "Pickups: " + CurrentPickUps + "/" + MaxPickUps;
    }

    private void LevelCompleteCheck()
    {
        if(CurrentPickUps >= MaxPickUps)
        {
            LevelComplete = true;
        }
        else
        {
            LevelComplete = false;
        }
    }
}
