using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class TypeWriter : MonoBehaviour
{
    public float delay = 0.1f;
    public AudioClip TypeSound;
    [Multiline]
    public string yazi;

    AudioSource audSrc;
    Text thisText;
    public GameObject textmenusu;

    private void Start()
    {
        audSrc = GetComponent<AudioSource>();
        thisText = GetComponent<Text>();
        StartCoroutine(TypeWrite());
    }

    IEnumerator TypeWrite()
    {
        foreach (char i in yazi)
        {
            thisText.text += i.ToString();

            audSrc.pitch = Random.Range(0.7f, 1.1f);
            audSrc.PlayOneShot(TypeSound);

            if (i.ToString() == ".") { yield return new WaitForSeconds(0.6f); }
            else {
                yield return new WaitForSeconds(delay);
                
            }
            
        }
        textmenusu.SetActive(false);
    }
}