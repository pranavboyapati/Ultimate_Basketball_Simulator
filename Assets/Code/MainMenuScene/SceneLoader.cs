//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//this function loads the page of the specified scenename
public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string Scenename)
    {
        SceneManager.LoadScene(Scenename);
    }
}
