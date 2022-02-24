﻿using System.Resources;
using Chapter_5_FSM.Scripts.Controllers;
using Chapter_5_FSM.Scripts.Interface;
using UnityEngine;

namespace Chapter_5_FSM.Scripts
{
    public class BikeTurnState : MonoBehaviour,IBikeState
    {
        private Vector2 _turnDirection;
        private BikeController _bikeController;
        public void Handle(BikeController bikeController)
        {
            if (!_bikeController)
            {
                _bikeController = bikeController;
            }

            _turnDirection.x = (float) _bikeController.CurrentTurnDirection;

            if (_bikeController.CurrentSpeed > 0)
            {
             transform.Translate(_turnDirection * _bikeController.turnDistance);   
            }
        }
    }
}