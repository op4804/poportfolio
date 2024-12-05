using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    void GetInput()
    {
        if (Input.GetKeyDown("w")){
            Debug.Log("up");
        }
        if (Input.GetKeyDown("a"))
        {
            Debug.Log("left");
        }
        if (Input.GetKeyDown("s"))
        {
            Debug.Log("down");
        }
        if (Input.GetKeyDown("d"))
        {
            Debug.Log("right");
        }
    }
}
