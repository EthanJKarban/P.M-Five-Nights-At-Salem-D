using UnityEngine;
using UnityEngine.SceneManagement;
public class Evi : MonoBehaviour
{
        public GameObject Player;
        public string level = "";

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Player.gameObject.tag == "Player")
        SceneManager.LoadScene(level);
    }
}
