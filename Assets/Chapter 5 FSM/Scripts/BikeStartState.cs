﻿using System;
using Chapter_5_FSM.Scripts.Controllers;
using Chapter_5_FSM.Scripts.Interface;
using UnityEngine;

namespace Chapter_5_FSM.Scripts
{
    public class BikeStartState: MonoBehaviour,IBikeState
    {
        private BikeController _bikeController;
        public void Handle(BikeController bikeController)
        {
            if (!_bikeController)
            {
                _bikeController = bikeController;
            }

            _bikeController.CurrentSpeed = _bikeController.maxSpeed;
        }

        private void Update()
        {
            if (!_bikeController) return;
            if (_bikeController.CurrentSpeed > 0)
            {
                _bikeController.transform.Translate(Vector3.forward * (_bikeController.CurrentSpeed * Time.deltaTime));
            }
        }
    }
}