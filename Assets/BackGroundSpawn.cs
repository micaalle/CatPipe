using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundSpawn : MonoBehaviour
{
    public GameObject back;
    public float spawnRate = 1;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawnBack();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnBack();
            timer = 0;
        }

    }
    void spawnBack()
    {
        Instantiate(back,transform.position, transform.rotation);
    }
}
