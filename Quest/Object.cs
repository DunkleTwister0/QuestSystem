using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Quest
{
    class Object: QuestGiver
    {
        private GiverType _giverType;
        private bool _takeable;
        public bool takeable
        {
            get
            {
                return _takeable;
            }
            set
            {
                if(_giverType == GiverType.Note)
                {
                    _takeable = true;
                }
                else
                {
                    _takeable = false;
                }
            }
        }

        public Object(GameObject giver, GiverType giverType)
        {
            _giver = giver;
            _giverLocation = _giver.transform.position;
            _giverType = giverType;
            takeable = false;
        }
    }
}
