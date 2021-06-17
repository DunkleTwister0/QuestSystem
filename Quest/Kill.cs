using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace QuestSystem
{
    class Kill: Quest
    {
        private string _targetName;
        private GameObject _target;

        /// <summary>
        /// Quest location is tied to target's location
        /// </summary>
        /// <param name="questName"></param>
        /// <param name="questDescription"></param>
        /// <param name="levelRequirement"></param>
        /// <param name="reward"></param>
        /// <param name="questGiver"></param>
        /// <param name="target"></param>
        /// <param name="targetName"></param>
        public Kill(string questName, string questDescription, int levelRequirement, Reward reward, QuestGiver questGiver, GameObject target, string targetName)
        {
            _questName = questName;
            _questDescription = questDescription;
            _target = target;
            _questLocation = _target.transform.position;
            _completionStatus = false;
            _levelRequirement = levelRequirement;
            _reward = reward;
            _questGiver = questGiver;
            _targetName = targetName;

            _quests.Add(this);
        }

        /// <summary>
        /// Quest location is manually inputed (if player has to search for target)
        /// </summary>
        /// <param name="questName"></param>
        /// <param name="questDescription"></param>
        /// <param name="levelRequirement"></param>
        /// <param name="questLocation"></param>
        /// <param name="reward"></param>
        /// <param name="questGiver"></param>
        /// <param name="target"></param>
        /// <param name="targetName"></param>
        public Kill(string questName, string questDescription, int levelRequirement, Vector3 questLocation, Reward reward, QuestGiver questGiver, GameObject target, string targetName)
        {
            _questName = questName;
            _questDescription = questDescription;
            _target = target;
            _questLocation = questLocation;
            _completionStatus = false;
            _levelRequirement = levelRequirement;
            _reward = reward;
            _questGiver = questGiver;
            _targetName = targetName;

            _quests.Add(this);
        }

        public string GetTargetName()
        {
            return _targetName;
        }

        public GameObject GetTarget()
        {
            return _target;
        }
    }
}
