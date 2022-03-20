using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timer = 1.0f;
    private float waitTime = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // Delay Input Timer - only execute the spacebar command if timer has caught up with waitTime
        if (timer < waitTime)
        { }else if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnDogPrefab();
            timer = 0;
        }
        
        // Run Timer every frame
        timer += Time.deltaTime;
        
    }



    void SpawnDogPrefab()
    {
        Instantiate(dogPrefab, dogPrefab.transform.position, dogPrefab.transform.rotation);
    }
}
