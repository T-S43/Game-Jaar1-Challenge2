using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float delay = 0.9f;
    private float tijd = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space) && tijd < Time.time)
            {
                tijd = Time.time + delay;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
    }
}
