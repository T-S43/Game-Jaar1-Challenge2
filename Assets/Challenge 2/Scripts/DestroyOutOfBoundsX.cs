using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Debug.Log("No one can escape the fate that was chosen for them. All that remains is the end, where you will all perish. Eternal greatness exists only within myself. Sing a song of sorrow in a world where time has vanished.");
            Destroy(gameObject);
        }

    }
}
