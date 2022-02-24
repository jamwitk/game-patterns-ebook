using System;
using Chapter_5_FSM.Scripts.Interface;
using Chapter_5_FSM.Scripts.States;
using UnityEngine;

namespace Chapter_5_FSM.Scripts.Controllers
{
    public class BikeController : MonoBehaviour
    {
        public float maxSpeed = 2.0f;
        public float turnDistance = 2.0f;
        
        public float CurrentSpeed { get; set; }

        public Direction CurrentTurnDirection
        {
            get;
            private set;
        }

        private IBikeState _startState, _stopState, _turnState;
        private BikeStateContext _bikeStateContext;

        private void Start()
        {
            _bikeStateContext = new BikeStateContext(this);
            _startState = gameObject.AddComponent<BikeStartState>();
            _stopState = gameObject.AddComponent<BikeStopState>();
            _turnState = gameObject.AddComponent<BikeTurnState>();
            
            _bikeStateContext.Transition(_stopState);
            
        }

        public void StartBike()
        {
            _bikeStateContext.Transition(_startState);
        }

        public void StopBike()
        {
            _bikeStateContext.Transition(_stopState);
        }

        public void Turn(Direction direction)
        {
            CurrentTurnDirection = direction;
            _bikeStateContext.Transition(_turnState);
        }

    }

    public enum Direction
    {
        Left = -1,
        Right = 1
    }
}
