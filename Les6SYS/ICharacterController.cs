using System;

namespace Les6SYS
{
		public interface ICharacterController
		{
			void SetCharacter(ICharacter character);
			void Logic(float frametime);
		}
}