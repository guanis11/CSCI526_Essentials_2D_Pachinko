using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void Load2DEssentials()
    {
        SceneManager.LoadScene("Essential2D");
    }

    public void LoadPachinkoChallenge()
    {
        SceneManager.LoadScene("Pachinko");
    }
}
