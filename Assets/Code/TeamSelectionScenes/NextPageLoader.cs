//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextPageLoader : MonoBehaviour
{
    //this function loads the second team selection page
    public void Clicked()
    {
        SceneManager.LoadScene("TeamSelectionScene2");
    }
}
