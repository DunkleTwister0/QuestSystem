using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Quest
{
    class Reward
    {
        public GameObject reward { get; set; }
        private int _rewardID;
        public bool redeemedXP { get; set; }
        public bool redeemedItem { get; set; }
        public int rewardID
        {
            get
            {
                return _rewardID;
            }
            set
            {
                if(value < 0)
                {
                    _rewardID = 0;
                }
                else
                {
                    _rewardID = value;
                }
            }
        }

        private int _XPamount;
        public int XPamount
        {
            get
            {
                return _XPamount;
            }
            set
            {
                if(value < 1)
                {
                    _XPamount = 1;
                }
                else
                {
                    _XPamount = value;
                }
            }
        }

        /// <summary>
        /// Constructor for initializing Item rewards with ID system
        /// </summary>
        /// <param name="XPamount"></param>
        /// <param name="rewardID"></param>
        public Reward(int XPamount, int rewardID)
        {
            this.XPamount = XPamount;
            this.rewardID = rewardID;
            redeemedXP = false;
            redeemedItem = false;
        }

        /// <summary>
        /// Constructor for initializing Item rewards with manual gameObject assignment
        /// </summary>
        /// <param name="XPamount"></param>
        /// <param name="reward"></param>
        public Reward(int XPamount, GameObject reward)
        {
            this.XPamount = XPamount;
            this.reward = reward;
            redeemedXP = false;
            redeemedItem = false;
        }
    }
}
