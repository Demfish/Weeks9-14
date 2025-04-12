using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCounter : MonoBehaviour
//Points code helped to be made with video by Velvary
{
    [SerializeField] PointHUD pointHUD;

    private void Start()
    {
        StartCoroutine(CountPoints());
        StartCoroutine(GameOver());
    }

    private IEnumerator CountPoints()
    {
        //Adding 1 point per second to the timer
        while (true)
        {
            pointHUD.Points += 1;

            yield return new WaitForSeconds(1);
        }

    }
    private IEnumerator GameOver()
    {
            float idleTime = 0f;

            //Checking each frame
            while (true)
            {
                //Horizontal and Vertical Mouse Movements
                float mouseX = Input.GetAxis("Mouse X");
                float mouseY = Input.GetAxis("Mouse Y");

                if ((mouseX) < 0.1f && (mouseY) < 0.1f)
                {
                    idleTime += Time.deltaTime;
                //2 seconds gives little time to slow, but just enough
                    if (idleTime >= 2f)
                    {
                        //Deactivate gameObject
                        gameObject.SetActive(false);
                        yield break;
                    }
                }
                else
                {
                    idleTime = 0f; // Reset if any mouse movement
                }

            yield return null;
            }      
    }
}