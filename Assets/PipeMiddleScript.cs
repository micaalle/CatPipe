using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public AudioSource audioSource;
    public LogicScript logic;
    public AudioClip triggerSound;  
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.layer == 3)
       // {
            logic.addScore(1);
            audioSource.PlayOneShot(triggerSound);
        // }
    }
   
}
