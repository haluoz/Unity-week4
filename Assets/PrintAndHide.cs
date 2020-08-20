using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i = 0;
    public Renderer render;
    int randomNum=0;

    // Start is called before the first frame update
    void Start()
    {
        randomNum = Random.Range(200, 250);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name +" : "+ ++i);
        if(i == 100 && gameObject.tag =="Red")
        {
            gameObject.SetActive(false);
        }
        if (i== randomNum && gameObject.tag =="Blue")
        {
            render.enabled = false;
        }
    }
}
