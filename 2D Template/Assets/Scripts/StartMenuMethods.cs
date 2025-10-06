using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("main");    
    }

    public void QuitButton()
    {
        Debug.Log("Quit the game!");
        Application.Quit(); 
    }
}
