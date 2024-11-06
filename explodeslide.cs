using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class explodeslide : MonoBehaviour
{
    Animator anim;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.Play("explode",-1,slider.value);
    }
}
