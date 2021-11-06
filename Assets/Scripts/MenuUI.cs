using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MenuUI : MonoBehaviour
{
    public static string player;
    [SerializeField] private TMP_InputField textOnScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player = textOnScreen.text;
    }
   public void StartIsClicked()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitIsClicked()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
    application.Quit;
#endif
    }
}
