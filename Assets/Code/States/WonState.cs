using UnityEngine;

namespace Assets.Code.States {

	public class WonState : StateBase {
		private StateManager manager;

		public WonState (StateManager manager) {
            this.manager = manager;
            Debug.Log("Constructing WonState");
		}

        public void Update() {
            if (Input.GetKeyUp(KeyCode.Space)) {
                manager.SwitchState(new LostState(manager));
            }
        }

		public void ShowIt () {
            Debug.Log("Showing WonState");
		}
	}
}
