using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Script : MonoBehaviour
{
   /* public Button button;
    public int Scene;
  
    private void start()
    {
        button.onClick.AddListener(goToScene);
    }*/

    public void LoadScene(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }
}
