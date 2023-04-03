using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenTransition : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //’Ç‰Á‚µ‚½
    //ƒ{ƒ^ƒ“‚ğ‰Ÿ‚µ‚½‚Ìˆ—
    public void PushButton()
    {
        SceneManager.LoadScene("title");
    }
}
