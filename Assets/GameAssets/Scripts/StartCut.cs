using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCut : MonoBehaviour
{
    public GameObject director;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            director.SetActive(true);
        }
    }
}
