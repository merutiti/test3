using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class player_engel : MonoBehaviour
{
    player_devil p_d;
    public Text text;

    public static bool angel_get;//ゲットエフェクト
    private void Start()
    {
        GameObject obj = GameObject.Find("devil");
        p_d = obj.GetComponent<player_devil>();
        angel_get = false;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "green")
        {
            p_d.score++ ;
            Destroy(col.gameObject);
            text.text = p_d.score.ToString();

            //getanima
            angel_get = true;

        }
       
    }
}
