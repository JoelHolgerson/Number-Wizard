using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
  public void ChangeScene(int buildindex)
  {
        SceneManager.LoadScene(buildindex);
  }

}

//Lmao