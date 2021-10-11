using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSad : MonoBehaviour
{
    // Start is called before the first frame update
    public void SadClick()
    {
        Debug.Log("ノースマイルください");
        if (GameManager.Instance.point > 0)
        {
            GameManager.Instance.point -= 1;
            GameManager.Instance.Point.fillAmount -= GameManager.Instance.wariai;
            GameManager.Instance.Point2.fillAmount -= GameManager.Instance.wariai;
            if (GameManager.Instance.w2 > 0)
            {
                GameManager.Instance.w2 -= 5;
            }
            else if (GameManager.Instance.w <= 100)
            {
                GameManager.Instance.w += 5;
            }
        }
        else
        {
            return;
        }
    }
}
