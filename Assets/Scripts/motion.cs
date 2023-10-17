using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motion : MonoBehaviour
{
	public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
      //   cube.transform.position = new Vector3(5, 2, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
     		{
			cube.transform.Translate(Vector3.forward * Time.deltaTime);
    }
 if (Input.GetKey(KeyCode.DownArrow))
     		{
			cube.transform.Translate(Vector3.back * Time.deltaTime);
    }
 if (Input.GetKey(KeyCode.LeftArrow))
     		{
			cube.transform.Translate(Vector3.left * Time.deltaTime);
    }

 if (Input.GetKey(KeyCode.RightArrow))
     		{
			cube.transform.Translate(Vector3.right * Time.deltaTime);
    }
    }
}
