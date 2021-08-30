using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
  public void OnClick()
    {
        if (SceneManager.GetActiveScene().name == "start") SceneManager.LoadScene("SampleScene");
    }
}
