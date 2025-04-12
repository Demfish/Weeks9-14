using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Points code helped to be made with video by Velvary
public class PointHUD : MonoBehaviour
{

    [SerializeField] Text pointText;

    int points = 0;

    private void Awake()
    {
        UpdateHUD();
    }

    public int Points
    {
        get
        {
            return points;
        }
        set
        {
            points = value;
            UpdateHUD();
        }
    }

    private void UpdateHUD()
    {
        pointText.text = points.ToString();
    }

}
