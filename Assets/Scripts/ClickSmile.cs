﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Threading;
using UnityEditor;
using UnityEngine;

using UnityEngine.EventSystems;
using UnityEngine.UI;
public class ClickSmile : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("スマイルください");
        if (GameManager.Instance.point > 0)
        {
            GameManager.Instance.point -= 1;
            GameManager.Instance.Point.fillAmount -= GameManager.Instance.wariai;
            GameManager.Instance.Point2.fillAmount -= GameManager.Instance.wariai;
            if (GameManager.Instance.w > 5)
            {
                GameManager.Instance.w -= 5;
            }
            else
            {
                GameManager.Instance.w2 += 5;
            }
        }
        else
        {
            return;
        }
    }
}