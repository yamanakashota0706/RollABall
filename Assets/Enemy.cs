using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    // ’Ç‚¢‚©‚¯‚éPlayer‚ÌˆÊ’u
    public Transform TargetPlayer;

    // Œ‹‰Ê‚ð
    public GameResultViewer GameResultViewer;

    private NavMeshAgent navMeshAgent;

    public GameState GameState;

    public BGMSoundManager BGMSoundManager;

    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        if (GameState.GameProgressState == GameState.GameProgressStates.GameResult)
        {
            return;
        }
        navMeshAgent.SetDestination(TargetPlayer.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
         if(collision.gameObject.tag.Equals("Player"))
        {
            GameResultViewer.ResultText.text = "Game Over";
            GameState.SetGameProgressState(GameState.GameProgressStates.GameResult);
            BGMSoundManager.PlayGameOverBGM();
        }
    }
}
