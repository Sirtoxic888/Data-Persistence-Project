using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

public class MenuUI : MonoBehaviour
{
    public static string player;
    [SerializeField] private TMP_InputField textOnScreen;
    [SerializeField] private TextMeshProUGUI bestScore;
    private int maxScore;
    private string bestPlayer;

    // Start is called before the first frame update
    void Start()
    {
        LoadName();
        bestScore.text = "Best score: " + bestPlayer + " " + maxScore;
    }

    // Update is called once per frame
    void Update()
    {
        player = textOnScreen.text;
    }

    public void LoadName()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            MainManager.Savedata data = JsonUtility.FromJson<MainManager.Savedata>(json);
            maxScore = data.score;
            bestPlayer = data.namePlayer;
        }
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
