using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoiceHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BookScene()
    {
        SceneManager.LoadScene("BookScene");
    }

    public void TvScene()
    {
        SceneManager.LoadScene("TvScene");
    }

    public void TeacherScene()
    {
        SceneManager.LoadScene("TeacherScene");
    }

    public void BuilderScene()
    {
        SceneManager.LoadScene("BuilderScene");
    }
}
