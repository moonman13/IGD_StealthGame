using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevels : MonoBehaviour
{

    public void LoadScene(int next)
    {
        SceneManager.LoadScene(next);
    }
}
