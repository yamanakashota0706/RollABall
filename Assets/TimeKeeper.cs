using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeKeeper : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI TimeText;

    public GameResultViewer GameResultViewer;

    public float TimeLimt = 20f;

    public GameState GameState;

    public BGMSoundManager BGMSoundManager;
    private void Update()
    {
        if(GameState.GameProgressState == GameState.GameProgressStates.GameResult)
        {
            return;
        }

        if (TimeLimt > 0 && !GameResultViewer.PlayerPickupItemManager.GetAllPickupItems)
        {

            TimeLimt -= Time.deltaTime;
            TimeText.text = $"{(int)TimeLimt + 1}";
        }
        else if (GameResultViewer.PlayerPickupItemManager.GetAllPickupItems)
        {
            TimeText.text = $"{(int)TimeLimt + 1}";
        }
        else
        {
            GameState.SetGameProgressState(GameState.GameProgressStates.GameResult);
            TimeText.text = $"{0}";
            GameResultViewer.ResultText.text = "Game Over";
            BGMSoundManager.PlayGameOverBGM();
        }
    }
}

    
