using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowArmature : MonoBehaviour
{
    public SkinnedMeshRenderer armature;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SkinnedMeshRenderer>().bones = armature.bones;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
