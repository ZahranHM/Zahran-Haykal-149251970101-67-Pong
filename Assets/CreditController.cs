using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditController : MonoBehaviour
{
    public void OpenMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
