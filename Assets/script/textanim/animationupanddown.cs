using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationupanddown : MonoBehaviour
{
    public float WaitBetween = 0.15f;
    public float WaitEnd = 0.5f;
    List<Animation> _animators;

    // Start is called before the first frame update
    void Start()
    {
       // _animators = new List<Animation>(GetComponentInChildren<Animator>());

        StartCoroutine(DOanimation());
    }

     IEnumerator DOanimation()
    {
        while (true)
        {
            foreach(var animator in _animators)
            {
                //animator.SetTrigger("DOanimation");
                yield return new WaitForSeconds(WaitBetween);

            }
            yield return new WaitForSeconds(WaitEnd);
        }
    }
}
