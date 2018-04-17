using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour {

	//public List<GameObject> pooledObjects;
	public GameObject objectToPool;
	public GameObject pla;
	//public int amountToPool;
	//int i=0;
	// Use this for initialization

//	void Start () {
//		pooledObjects = new List<GameObject>();
//		for (int i = 0; i < amountToPool; i++) {
//			GameObject obj = (GameObject)Instantiate(objectToPool);
//			obj.SetActive(false); 
//			pooledObjects.Add(obj);
//		}
//		pooledObjects.ToArray () [i].SetActive (true);
//	}

//	public GameObject GetPooledObject() {
//
//		for (int i = 0; i < pooledObjects.Count; i++) {
//			if (!pooledObjects[i].activeInHierarchy) {
//				return pooledObjects[i];
//			}
//		}
//		return null;
//	}


	void Start(){
		create ();
	}

	IEnumerator mycoroutine()
	{
		yield return new WaitForSeconds(Random.Range(0.5f,1.0f));
		create ();
	}


	void create(){
		GameObject ob = (GameObject)Instantiate(objectToPool);
		ob.SetActive (true);
		ob.transform.parent = pla.transform;
		StartCoroutine(mycoroutine ());
	}


	// Update is called once per frame
//	void FixedUpdate () {
//
//		if (pooledObjects.ToArray () [i].transform.position.y < -1.5) {
//			pooledObjects.ToArray () [i].SetActive (false);
//			//pooledObjects.ToArray () [i].transform.position = objectToPool.transform.position;  
//			i++;
//			if (i == this.amountToPool) {
//				i = 0;
//				for (int i = 0; i < this.amountToPool; i++) {
//					Destroy (pooledObjects.ToArray () [i]);
//				}
//					
//				setArray ();
//			}
//			pooledObjects.ToArray () [i].SetActive (true);
//		}
//	}

//	public void setArray(){
//		pooledObjects = new List<GameObject>();
//		for (int i = 0; i < amountToPool; i++) {
//			GameObject obj = (GameObject)Instantiate(objectToPool);
//			obj.SetActive(false); 
//			pooledObjects.Add(obj);
//		}
//		pooledObjects.ToArray () [i].SetActive (true);
//	}

//	public GameObject createObj(){
//		return (GameObject)Instantiate(objectToPool);
//	}

}
