using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderSounds : MonoBehaviour
{
    public AudioClip[] invadersounds;
    private AudioSource Sounds;
    private int SwapSound = 4;
    private float timeRemaining = 1;
    private string canPlay = "Yes";

    // Start is called before the first frame update
    void Start()
    {
        Sounds = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }

        else
        {
            timeRemaining = 1;
            SwapSound = SwapSound - 1;
            canPlay = "Yes";
        }

        if (SwapSound == 4 && canPlay == "Yes")
            {
            Sounds.clip = invadersounds[0];
            //Debug.Log(SwapSound);
            Sounds.Play();
            canPlay = "No";
        }

        if (SwapSound == 3 && canPlay == "Yes")
            {
            Sounds.clip = invadersounds[1];
            //Debug.Log(SwapSound);
            Sounds.Play();
            canPlay = "No";
        }

        if (SwapSound == 2 && canPlay == "Yes")
            {
            Sounds.clip = invadersounds[2];
            //Debug.Log(SwapSound);
            Sounds.Play();
            canPlay = "No";
        }

        if (SwapSound == 1 && canPlay == "Yes")
            {
            Sounds.clip = invadersounds[3];
            //Debug.Log(SwapSound);
            Sounds.Play();
            canPlay = "No";
        }

        if (SwapSound <= 0)
        {
            SwapSound = 4;
        }
    }
}
