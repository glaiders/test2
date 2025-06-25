using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour
{
    public bool isClick;
    // Start is called before the first frame update
    void Start()
    {
        isClick = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPushedBotton()
    {
        Debug.Log("aaaa");
        isClick = true;
        this.gameObject.SetActive(false);
    }
}
