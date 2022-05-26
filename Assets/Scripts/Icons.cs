using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Icons : MonoBehaviour
{
    public void OpenHome()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
