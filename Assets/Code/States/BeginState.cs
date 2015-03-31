using UnityEngine;

namespace Assets.Code.States {

	public class BeginState : StateBase {
		private StateManager manager;

		public BeginState (StateManager manager) {
			this.manager = manager;
            Debug.Log("Constructing BeginState");
		}

        public void Update() {
            if (Input.GetKeyUp(KeyCode.Space)) {
                manager.SwitchState(new PlayState(manager));
            }
        }

		public void ShowIt () {
            Debug.Log("Showing BeginState");
		}
	}
}
