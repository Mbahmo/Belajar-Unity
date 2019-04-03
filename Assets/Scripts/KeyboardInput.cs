using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput: MonoBehaviour {
    string myText,
    myText2;
    public KeyCode myKey;
    // Use this for initialization
    void Start() {}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("a")) {
            myText = "KeyPress: Tombol A";
        }
        if (Input.GetKey(KeyCode.B)) {
            myText = "KeyDown: Tombol B";
        }
        if (Input.GetKeyUp(myKey)) {
            myText = "KeyPress: Tombol Pilihan User";
        }
        if (Input.anyKey) {
            myText2 = "Ada tombol yang dipencet terus";
        } else {
            myText2 = "";
        }
        if (Input.GetAxis("Fire1") > 0) {
            myText = "KeyUp: Left Ctrl/Left Mouse";
        }
    } 
	void OnGUI() {
		GUILayout.BeginArea(new Rect(10, 10, 200, 200));
		GUILayout.Label(myText);
		GUILayout.Label(myText2);
		GUILayout.EndArea();
	}
}
