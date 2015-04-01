using UnityEngine;

namespace Assets.Code.States {

	public class BeginState : StateBase {
		private StateManager manager;

		public BeginState (StateManager manager) {
			this.manager = manager;
			Debug.Log("Constructing BeginState");
		}

		public void Update() {

		}

		public void ShowIt () {
			if(GUI.Button(new Rect(10, 10, 150, 100), "Press to play")){
				Switch();
			}
		}

		void Switch () {
			Application.LoadLevel("PlayScene01");
			manager.SwitchState(new PlayState(manager));
		}
	}
}
