using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    public void OnMouseDown()
    {
        //Makes GameObject transform when the mouse is down
        gameObject.transform.position = new Vector3(Random.Range(-8, 8), Random.Range(-3, 1), 1);
    }
    public void OnMouseExit()
    {
        //Makes gameObject transform upon mouse exit
        gameObject.transform.position = new Vector3(Random.Range(-8, 8), Random.Range(-3, 1), -5);
    }
   
}
