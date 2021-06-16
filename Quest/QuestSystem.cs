using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Quest;

public class QuestSystem : MonoBehaviour
{
    private NPC _jayWilliams;

    private void Start()
    {
        _jayWilliams = new NPC("Jay Williams");
    }
}
