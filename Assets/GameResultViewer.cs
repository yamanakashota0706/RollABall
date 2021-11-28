using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class GameResultViewer : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerPickupItemManager PlayerPickupItemManager;

    public TextMeshProUGUI ResultText;

    public BGMSoundManager BGMSoundManager;

    public GameState GameState;

    private void Start()
    {
        ResultText.text = string.Empty;
    }

    // Update is called once per frame

    private bool PlayedGameClearBGM = false;

    void Update()
    {

        if(PlayerPickupItemManager.GetAllPickupItems)
        {
            GameState.SetGameProgressState(GameState.GameProgressStates.GameResult);

            if (!PlayedGameClearBGM)
            {
                BGMSoundManager.PlayGameClearBGM();
                PlayedGameClearBGM = true;
            }
            ResultText.text = "Game Clear";
        }
    }
}
