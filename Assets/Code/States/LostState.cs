using UnityEngine;

namespace Assets.Code.States {

	public class LostState : StateBase {
		private StateManager manager;

		public LostState (StateManager manager) {
            this.manager = manager;
            Debug.Log("Constructing LostState");
		}

        public void Update() {
            if (Input.GetKeyUp(KeyCode.Space)) {
                manager.SwitchState(new BeginState(manager));
            }
        }

		public void ShowIt () {
            Debug.Log("Showing LostState");
		}
	}
}
