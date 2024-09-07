using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //Object speed
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy object after 5 seconds
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        //Move object
        transform.position = (Vector2)transform.position + Vector2.down * (speed + GameController.gameSpeed) * Time.deltaTime;
    }
}
