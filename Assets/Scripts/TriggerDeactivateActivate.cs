﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDeactivateActivate : MonoBehaviour
{
	public GameObject targetObject;
	private MeshRenderer meshRendererComponent;

	void Start()
	{
		meshRendererComponent = this.GetComponentInChildren<MeshRenderer>();
		meshRendererComponent.enabled = false;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			targetObject.SetActive(true);
		}
	}
}