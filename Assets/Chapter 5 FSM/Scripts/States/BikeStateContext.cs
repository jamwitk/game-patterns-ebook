using Chapter_5_FSM.Scripts.Controllers;
using Chapter_5_FSM.Scripts.Interface;
using UnityEngine;

namespace Chapter_5_FSM.Scripts.States
{
    public class BikeStateContext 
    {
        private IBikeState CurrentState
        {
            get;
            set;
        }
        private readonly BikeController _bikeController;
        
        public BikeStateContext(BikeController bikeController)
        {
            _bikeController = bikeController;
        }
        public void Transition()
        {
            CurrentState.Handle(_bikeController);
        }
        public void Transition(IBikeState state)
        {
            CurrentState = state;
            CurrentState.Handle(_bikeController);
        }
    }
}
