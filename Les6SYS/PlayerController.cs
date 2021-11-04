using System;

namespace Les6SYS
{
    public class PlayerController : ICharacterController
    {
        IInputDevice InputDevice;  
       public PlayerController(IInputDevice inputDevice)
        {
            this.InputDevice = inputDevice;
        }
        
        public void Logic(float frametime) 
        {
            InputDevice.GetHorizontalAnalog();
        }

        public void SetCharacter(ICharacter character)
        {
            
        }
    }
}