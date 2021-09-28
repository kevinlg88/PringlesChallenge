using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTrigger : MonoBehaviour
{
    public GameObject director;
    bool on = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(!on)
            {
                director.SetActive(true);
            }
            else
            {
                director.SetActive(false);
            }
            on = !on;
        }
    }
}
