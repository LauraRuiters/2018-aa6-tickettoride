using UnityEngine;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LeaveGame()
    {
        Debug.Log("Verlaten is in Unity editor niet mogelijk");
        Application.Quit();
    }
    public void OpenRegels()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

    }
   
}