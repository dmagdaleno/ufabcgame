using UnityEngine;

namespace Assets.Code.States {

	public class PlayState : StateBase {
		private StateManager manager;

		public PlayState (StateManager manager) {
			this.manager = manager;
            Debug.Log("Constructing PlayState");
		}

        public void Update() {
            if (Input.GetKeyUp(KeyCode.Space)) {
                manager.SwitchState(new WonState(manager));
            }
        }

		public void ShowIt () {
            Debug.Log("Showing PlayState");
		}
	}
}
