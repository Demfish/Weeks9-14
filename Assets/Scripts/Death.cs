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
    private void OnMouseDown()
    {
        this.gameObject.transform.position = new Vector3(-5, 3, 1);
    }
    private void OnMouseExit()
    {
        this.gameObject.transform.position = new Vector3(Random.Range(-5,5), Random.Range(-2,2), 0);
  
    }
    void Update()
            {
            }
        }
