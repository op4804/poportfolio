using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Start is called before the first frame update

    float size = 3f;
    float inputCooltime = 0.1f;
    bool isInputCooltime = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isInputCooltime)
        {
            if (Input.GetKeyDown("w"))
            {
                this.transform.position += new Vector3(0, size, 0);
                isInputCooltime = false;
                StartCoroutine(StartInputCooltime());
            }
            if (Input.GetKeyDown("a"))
            {
                this.transform.position += new Vector3(-size, 0, 0);
                isInputCooltime = false;
                StartCoroutine(StartInputCooltime());
            }
            if (Input.GetKeyDown("s"))
            {
                this.transform.position += new Vector3(0, -size, 0);
                isInputCooltime = false;
                StartCoroutine(StartInputCooltime());
            }
            if (Input.GetKeyDown("d"))
            {
                this.transform.position += new Vector3(size, 0, 0);
                isInputCooltime = false;
                StartCoroutine(StartInputCooltime());
            }
        }

    }
    IEnumerator StartInputCooltime()
    {
        yield return new WaitForSeconds(inputCooltime);
        isInputCooltime = true;
    }
}
