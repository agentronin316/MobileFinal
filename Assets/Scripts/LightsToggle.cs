using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LightsToggle : MonoBehaviour {

    //public bool IsOn { get; private set; }

    //public GameObject other;
    Animator animator;

    void Start()
    {
        
        animator = GetComponent<Animator>();
    }

	public void Change ()
    {
        gameObject.GetComponent<Button>().interactable = false;
    }
}
