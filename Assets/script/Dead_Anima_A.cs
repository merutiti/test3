using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead_Anima_A : MonoBehaviour
{
    private Animator anim = null;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0)
        {
            transform.localScale = new Vector3(1, 1, 1);

            anim.SetBool("DeadEnd", true);
        }

        else
        {
            anim.SetBool("DeadEnd", false);
        }

    }

}
