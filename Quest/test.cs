using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Quest;

public class test : MonoBehaviour
{
    [SerializeField] private GameObject _pirateCaptain;

    Quest testQuest;

    private void Start()
    {
        testQuest = new Kill("Pirate Hunting", "Kill the pirate captain", 1, new Reward(50, 20), new NPC("Jay Williams", gameObject), _pirateCaptain, "Pirate Captain");

        if (QuestLog.AcceptQuest(testQuest, PlayerMovement._playerLevel))
        {
            Debug.Log("Quest accepted");
        }

        else
        {
            Debug.Log("Player does not meet level requirement");
        }

        Debug.Log(PlayerMovement._playerXP);

        PlayerMovement._playerXP += QuestLog.GiveXPReward(testQuest);
        PlayerMovement._playerXP += QuestLog.GiveXPReward(testQuest);


        Debug.Log(PlayerMovement._playerXP);
    }


}
