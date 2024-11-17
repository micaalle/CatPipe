using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Project1CatScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float fly;
    public bool catAlive = true;
    public LogicScript logic;
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    public AudioClip gameOverClip; 

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && catAlive)
        {
            myRigidbody.velocity = Vector2.up * fly;
            PlayRandomAudio(); // Play random audio clip when space is pressed
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOverS();
        audioSource.PlayOneShot(gameOverClip);
        catAlive = false;
    }

    void PlayRandomAudio()
    {
        if (audioClips.Length == 0) return; // Exit if no audio clips are set

        // Select a random audio clip from the array
        int randomIndex = Random.Range(0, audioClips.Length);
        AudioClip randomClip = audioClips[randomIndex];

        // Play the selected audio clip
        audioSource.PlayOneShot(randomClip);
    }
}
