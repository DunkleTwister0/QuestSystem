using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Quest
{
    class Fetch: Quest
    {
        private int _amountNeeded;
        public int amountNeeded
        {
            get
            {
                return _amountNeeded;
            }
            set
            {
                if(value <= 0)
                {
                    _amountNeeded = 1;
                }
                else
                {
                    _amountNeeded = value;
                }
            }
        }

        private int _objectID;
        public int objectID
        {
            get
            {
                return _objectID;
            }
            set
            {
                if(value < 0)
                {
                    _objectID = 0;
                }
                else
                {
                    _objectID = value;
                }
            }
        }
        public GameObject _item { get; set; }

        /// <summary>
        /// Quest location is attached to item location. Amount required set to 1
        /// </summary>
        /// <param name="questName"></param>
        /// <param name="questDescription"></param>
        /// <param name="levelRequirement"></param>
        /// <param name="reward"></param>
        /// <param name="questGiver"></param>
        /// <param name="objectID"></param>
        /// <param name="item"></param>
        public Fetch(string questName, string questDescription, int levelRequirement, Reward reward, QuestGiver questGiver, int objectID, GameObject item)
        {
            _questName = questName;
            _questDescription = questDescription;
            _levelRequirement = levelRequirement;
            _item = item;
            _questLocation = _item.transform.position;
            _reward = reward;
            _questGiver = questGiver;
            _completionStatus = false;

            amountNeeded = 1;
            this.objectID = objectID;
        }

        /// <summary>
        /// Quest location is manually inputed. Allows for requirement to collect more than 1 item.
        /// </summary>
        /// <param name="questName"></param>
        /// <param name="questDescription"></param>
        /// <param name="levelRequirement"></param>
        /// <param name="questLocation"></param>
        /// <param name="reward"></param>
        /// <param name="questGiver"></param>
        /// <param name="objectID"></param>
        /// <param name="item"></param>
        /// <param name="amountNeeded"></param>
        public Fetch(string questName, string questDescription, int levelRequirement, Vector3 questLocation, Reward reward, QuestGiver questGiver, int objectID, GameObject item, int amountNeeded)
        {
            _questName = questName;
            _questDescription = questDescription;
            _levelRequirement = levelRequirement;
            _item = item;
            _questLocation = questLocation;
            _reward = reward;
            _questGiver = questGiver;
            _completionStatus = false;

            this.amountNeeded = amountNeeded;
            this.objectID = objectID;
        }
    }
}
