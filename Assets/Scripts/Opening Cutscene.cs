using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningCutscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("changeScene", 6);
    }

    void changeScene()
    {
        SceneManager.LoadScene(1);
    }
}
