using UnityEngine;
using MalbersAnimations.Events;

namespace MalbersAnimations
{   
    // I add this script to the same object my MobileJoyStick is.
    public class CatSprintJoyStick : MonoBehaviour
    {
        // Add your MobileJoystick here in editor
        [SerializeField] MobileJoystick sprintJoyStick;
        // Add the Set Sprint Event from Animal controller 
        public BoolEvent fullJoySitck;
       
        void Update()
        {
            // using the ABS for controller values as they can be negtive. If the combine value is greater or equal to 1 you should be pressing max on the joystick
            if(Mathf.Abs(sprintJoyStick.AxisValue.x) + Mathf.Abs(sprintJoyStick.AxisValue.y) >= 1)
            {
                fullJoySitck.Invoke(true);
            }
            else
            {
                fullJoySitck.Invoke(false);
            }
        }
    }
}
