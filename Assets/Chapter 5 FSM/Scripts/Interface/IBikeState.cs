using Chapter_5_FSM.Scripts.Controllers;

namespace Chapter_5_FSM.Scripts.Interface
{
    public interface IBikeState
    {
        void Handle(BikeController controller);
    }
}
