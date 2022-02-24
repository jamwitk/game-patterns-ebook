using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    private DateTime _sessionStartTime;
    private DateTime _sessionEndTime;

    private void Start()
    {
        //TODO:
        //- LOAD PLAYER SAVE
        //- IF NO SAVE, REDIRECT PLAYER TO REGISTRATION SCENE
        //- CALL BACKEND AND GET DAILY CHALLENGE AND REWARDS
        
        _sessionEndTime = DateTime.Now;
        print("Game session start @: "+DateTime.Now);
    }

    private void OnApplicationQuit()
    {
        _sessionEndTime = DateTime.Now;
        var timeDifference = _sessionEndTime.Subtract(_sessionStartTime);
        print("Game session ended @: "+DateTime.Now);
        print("Game session lasted @: "+timeDifference);
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Next Scene"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
