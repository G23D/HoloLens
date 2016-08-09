//feel free to use in any way-Kyle "G" vision@wavelength.space
//coded to be used with https://www.assetstore.unity3d.com/en/#!/content/10104 but any animated model can be initialized
using UnityEngine;
using UnityEngine.VR.WSA;

[RequireComponent(typeof(AudioSource))]
public class SpiderCommands : MonoBehaviour
{
    Vector3 originalPosition;

    public int countCollisions = 0;

    //public object particle { get; private set; }
    //public ParticleEmitter particle;
    public GameObject explosion;
    public GameObject playerExplosion;

    // Use this for initialization
    void Start()
    {
        // Grab the original local position of the spider when the app starts.
        //originalPosition = this.transform.localPosition;

        //Anchor the spider to a specific Vector3 location
        //DestroyImmediate(gameObject.GetComponent<WorldAnchor>());
        gameObject.transform.position = new Vector3(0, 0, 10);
        WorldAnchor anchor = gameObject.AddComponent<WorldAnchor>();
    }

    void OnSelect()
    {
        //Load the exploision prefab by name from the resources folder
        GameObject monster = (GameObject)Instantiate(Resources.Load("Detonator-Simple"));
        Instantiate(monster, transform.position, transform.rotation);
        //monster.velocity = transform.TransformDirection(Vector3.forward * 100);
        
        //Apply physics to spider
        //var rigidbody = this.gameObject.AddComponent<Rigidbody>();
        //rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;

        //Play growl sound when struck/Attach and audio component/sound to the enemy creature mesh
        gameObject.GetComponent<AudioSource>().Play();
       
        countCollisions = countCollisions + 1;

        if (countCollisions <= 1)
        {

            //Play attack animation in response to gaze selection
            GetComponent<Animation>().Play("attack1");

            
        }
        else if (countCollisions >= 4)
        {
            //GameObject monster = (GameObject)Instantiate(Resources.Load("Detonator-Simple"));
            GetComponent<Animation>().Play("death1"); 
        }



    }
}