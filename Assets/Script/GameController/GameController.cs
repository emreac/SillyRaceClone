using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 5f;

    public void EndGame()
    {   
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);

            //Restart The Game
            Restart();
        }
       
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
