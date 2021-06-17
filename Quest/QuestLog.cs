using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace QuestSystem
{
    static class QuestLog
    {
        private static List<Quest> _acceptedQuests = new List<Quest>();
        private static List<Quest> _completedQuests = new List<Quest>();

        /// <summary>
        /// Returns true if the player meets level requirement for quest and adds that quest to accepted quest list. Returns false otherwise.
        /// </summary>
        /// <param name="quest"></param>
        /// <param name="playerLevel"></param>
        /// <returns></returns>
        public static bool AcceptQuest(Quest quest, int playerLevel)
        {
            bool canBeAccepted = true;
            foreach(Quest questCheck in _acceptedQuests)
            {
                if(questCheck == quest)
                {
                    canBeAccepted = false;
                }
            }
            foreach(Quest questCheck in _completedQuests)
            {
                if(questCheck == quest)
                {
                    canBeAccepted = false;
                }
            }

            if(playerLevel >= quest.GetLevelRequirement() && canBeAccepted)
            {
                _acceptedQuests.Add(quest);

                return true;
            }

            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks a quest's completion status. If it's true, removes it from accepted quests list and adds it to completed quests list.
        /// </summary>
        /// <param name="quest"></param>
        /// <returns></returns>
        public static bool CompleteQuest(Quest quest)
        {
            bool canBeCompleted = false;
            foreach(Quest questCheck in _acceptedQuests)
            {
                if(questCheck == quest)
                {
                    canBeCompleted = true;
                }
            }

            if (quest.GetCompletionStatus() && canBeCompleted)
            {
                if (!_acceptedQuests.Any())
                {
                    foreach(Quest removeThis in _acceptedQuests)
                    {
                        if(removeThis == quest)
                        {
                            _acceptedQuests.Remove(removeThis);
                        }
                    }
                }

                _completedQuests.Add(quest);

                return true;
            }

            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns int value with XP reward from a quest.
        /// </summary>
        /// <param name="quest"></param>
        /// <returns></returns>
        public static int GiveXPReward(Quest quest)
        {
            if (!quest.GetReward().redeemedXP)
            {
                quest.GetReward().redeemedXP = true;

                return quest.GetReward().XPamount;
            }

            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Returns gameObject with item reward from quest.
        /// </summary>
        /// <param name="quest"></param>
        /// <returns></returns>
        public static GameObject GiveItemReward(Quest quest)
        {
            if (!quest.GetReward().redeemedItem && quest.GetReward() != null)
            {
                quest.GetReward().redeemedItem = true;

                return quest.GetReward().reward;
            }

            else
            {
                return null;
            }
        }

        public static List<Quest> GetAcceptedQuests()
        {
            return _acceptedQuests;
        }

        public static List<Quest> GetCompletedQuests()
        {
            return _completedQuests;
        }
    }
}
