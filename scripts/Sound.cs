using UnityEngine;
using System.Collections;

public class AudioClass
{

    public void PlayAudio(int clip)
    {
        AudioSource audiosource;
        AudioClip[] geluid;
        audiosource = Camera.main.transform.Find("EmptyCamera").GetComponent<AudioSource>();
        //AudioSource audio = GetComponent<AudioSource> ();
        geluid = new AudioClip[]
        {
            (AudioClip)Resources.Load ("geluid/ontplof") as AudioClip,
            (AudioClip)Resources.Load ("geluid/spacesound") as AudioClip,
            (AudioClip)Resources.Load ("geluid/snoop") as AudioClip
        };
        //audio.PlayOneShot (geluid [clip], 0.7f);
        audiosource.clip = geluid[clip];
        audiosource.Play();
    }

    public void PlayAudio(int clip, string AudioSourceString)
    {
        AudioSource audio;
        AudioClip[] geluid;

        audio = Camera.main.transform.Find(AudioSourceString).GetComponent<AudioSource>();
        geluid = new AudioClip[]
        {
            (AudioClip)Resources.Load ("geluid/ontplof") as AudioClip,
            (AudioClip)Resources.Load ("geluid/spacesound") as AudioClip,
            (AudioClip)Resources.Load ("geluid/snoop") as AudioClip
        };
        //audio.PlayOneShot (geluid [clip], 0.7f);
        audio.clip = geluid[clip];
        audio.Play();
    }

}
