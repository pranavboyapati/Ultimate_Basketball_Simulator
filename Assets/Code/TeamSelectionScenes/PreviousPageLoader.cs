//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreviousPageLoader : MonoBehaviour
{
    //this function loads the first page of the team selections
    public void Clicked()
    {
        SceneManager.LoadScene("TeamSelectionScene1");
    }
}
