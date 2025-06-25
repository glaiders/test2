using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour
{
    public bool isClicked;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPushedBotton()
    {
        Debug.Log("aaaa");
        isClicked = true;
        this.gameObject.SetActive(false);
    }
}
