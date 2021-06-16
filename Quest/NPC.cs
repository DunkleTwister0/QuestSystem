using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Quest
{
    class NPC: QuestGiver
    {
        public bool isActive { get; set; }
        private string _NPCName;

        /// <summary>
        /// The NPCName parameter must match the name of the GameObject which represents the NPC.
        /// </summary>
        /// <param name="NPCName"></param>
        public NPC(string NPCName)
        {
            isActive = true;
            _NPCName = NPCName;

            AttachToGameObject();
        }

        /// <summary>
        /// Manually assign the gameObject. NPCName does not have to match GameObject name.
        /// </summary>
        /// <param name="NPCName"></param>
        /// <param name="giver"></param>
        public NPC(string NPCName, GameObject giver)
        {
            isActive = true;
            _NPCName = NPCName;
            _giver = giver;
            _giverLocation = _giver.transform.position;
        }

        private void AttachToGameObject()
        {
            if(GameObject.Find(_NPCName) != null)
            {
                _giver = GameObject.Find(_NPCName);
                _giverLocation = _giver.transform.position;
            }
            else
            {
                Debug.LogError("NPC initialization error: GameObject with name '" + _NPCName + "' not found!");
            }
        }
    }
}
