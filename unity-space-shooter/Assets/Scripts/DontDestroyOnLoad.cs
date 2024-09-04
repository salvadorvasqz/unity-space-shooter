using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Dont destroy this object
        DontDestroyOnLoad(this.gameObject);
    }
}
