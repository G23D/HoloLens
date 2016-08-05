//feel free to use in any way-Kyle "G" vision@wavelength.space
//coded to be used with https://www.assetstore.unity3d.com/en/#!/content/10104 but any animated model can be initialized
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SpiderCommands : MonoBehaviour
{
    Vector3 originalPosition;

    // Use this for initialization
    void Start()
    {
        // Grab the original local position of the sphere when the app starts.
        originalPosition = this.transform.localPosition;
    }

    void OnSelect()
    {
        //Apply physics to spider
        //var rigidbody = this.gameObject.AddComponent<Rigidbody>();
        //rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;

        //Play growl sound when struck/Attach and audio component/sound to the enemy creature mesh
        gameObject.GetComponent<AudioSource>().Play();

        //Play attack animation in response to gaze selection
        GetComponent<Animation>().Play("attack1");
        //GetComponent<Animation>().Play("death1");       
    }  
}