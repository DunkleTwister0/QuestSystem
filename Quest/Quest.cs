using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Quest
{
    abstract class Quest
    {
        protected string _questName;
        protected string _questDescription;
        protected Vector3 _questLocation;
        protected bool _completionStatus;
        protected int _levelRequirement;

        protected Reward _reward;
        protected QuestGiver _questGiver;

        protected static List<Quest> _quests = new List<Quest>();

        public string GetQuestName()
        {
            return _questName;
        }

        public string GetQuestDescription()
        {
            return _questDescription;
        }

        public Vector3 GetQuestLocation()
        {
            return _questLocation;
        }

        public int GetLevelRequirement()
        {
            return _levelRequirement;
        }

        public Reward GetReward()
        {
            return _reward;
        }

        public QuestGiver GetQuestGiver()
        {
            return _questGiver;
        }

        public bool GetCompletionStatus()
        {
            return _completionStatus;
        }

        public List<Quest> GetQuestList()
        {
            return _quests;
        }

        public void SetQuestToComplete()
        {
            _completionStatus = true;
        }
    }
}
