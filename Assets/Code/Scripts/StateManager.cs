using UnityEngine;
using Assets.Code.States;

public class StateManager : MonoBehaviour {

	private StateBase activeState;
	
    /*	
	[HideInInspector]
	public GameData gameDataRef;
     */

	private static StateManager instanceRef;

	void Awake () {

		if(instanceRef == null) {
			instanceRef = this;
			DontDestroyOnLoad(gameObject);
		} else {
			DestroyImmediate(gameObject);
		}
	}
			
	void Start () {
		activeState = new BeginState(this);
		//gameDataRef = GetComponent<GameData>();
	}

	void Update() {
		if (activeState != null)
			activeState.Update();
	}
	
	void OnGUI() {
		if(activeState != null)
			activeState.ShowIt();
	}
			
	public void SwitchState(StateBase newState) {
		activeState = newState;
	}
		
	public void Restart() {
		Destroy(gameObject);
		Application.LoadLevel("Scene0");
	}
}