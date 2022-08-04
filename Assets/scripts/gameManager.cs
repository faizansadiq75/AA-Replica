using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameManager : MonoBehaviour
{

    private bool gameEnded = false;
    public rotator rotate;
    public spawner spawn;
    public Animator animator;

    public void endGame()
    {
        if (gameEnded)
            return;

        rotate.enabled = false;
        spawn.enabled = false;

        animator.SetTrigger("EndGame");
        gameEnded = true;
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
