using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public string nomeDaFase;

    // Start is called before the first frame update
    void Start()
    {


    }

    public void StartGame()
    {
        SceneManager.LoadScene(nomeDaFase);
    }

    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
