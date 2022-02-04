using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startButton()
    {
        SceneManager.LoadScene(1);
    }
    public void RestartButton()
    {
        SceneManager.LoadScene(1);
    }
   public void Exitbutton()
    {
        Application.Quit();
    }
}
