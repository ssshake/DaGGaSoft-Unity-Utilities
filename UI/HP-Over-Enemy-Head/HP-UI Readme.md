		GameObject HPUI = GameObject.Instantiate (
			Resources.Load ("HPUI", typeof(GameObject)),
			new Vector3(transform.position.x, transform.position.y, transform.position.z-4), 
			Quaternion.Euler (0, 0, 0)
		) as GameObject;
		HPUI.SendMessage ("SetText", dmg * -1);


////////////////////////////

showHPUI (damage * -1);

	void showHPUI(int value){
		HPUI = GameObject.Instantiate (
			Resources.Load ("HPUI", typeof(GameObject)),
			new Vector3(transform.position.x, gameObject.GetComponent<BoxCollider>().size.y / 2, transform.position.z - 1), 
			Quaternion.Euler (0, 0, 0)
		) as GameObject;
		HPUI.SendMessage ("SetText", value);	
	