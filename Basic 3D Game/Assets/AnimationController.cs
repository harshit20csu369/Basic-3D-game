using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    public Animator dieAnimation;
    void Start()
    {
        dieAnimation = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            dieAnimation.SetBool("die", true);
        }
        if(Input.GetKeyDown("z"))
        {
            dieAnimation.SetBool("die", false);
        }
    }
}
