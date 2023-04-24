using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueButton : MonoBehaviour
{
    public GameObject popupBox;

    public void ContinueGame()
    {
        Time.timeScale = 1f;
        popupBox.SetActive(false);
        gameObject.SetActive(false);
    }
    public void OnContinueButtonClicked()
    {
        Time.timeScale = 1f; // Resume the game
       // popupBox.SetActive(false); // Hide the popup box
      //  Destroy(gameObject); // Destroy the popup box game object
    }
}
