using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueButton : MonoBehaviour
{
    public GameObject popupBox;

    public void ContinueGame()
    {
        
        popupBox.SetActive(false);
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

}
