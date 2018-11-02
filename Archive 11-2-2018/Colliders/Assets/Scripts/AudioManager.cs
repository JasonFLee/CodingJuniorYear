using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Object = UnityEngine.Object;

public enum SoundEffect {
GunShot, 
BulletHitWall,
Dash,
Jump,
BossShoot,
Explosion,
NukeFall,


}

public class AudioManager {
    static AudioManager instance;
    private Dictionary<SoundEffect, AudioClip> SoundEffects
    { get; set; }




    private AudioSource SoundEffectSource { get; set; }

    private AudioSource BGMsource { get; set; }

    public static AudioManager Instance { get { return instance ?? (instance = new AudioManager()); } }

    private AudioManager()
    {
        SoundEffects = Resources.LoadAll<AudioClip>("")
            .ToDictionary(t => (SoundEffect)Enum.Parse(typeof(SoundEffect), t.name, true));

        SoundEffectSource = new GameObject("SoundEffectSource", typeof(AudioSource)).GetComponent<AudioSource>();
        Object.DontDestroyOnLoad(BGMsource.gameObject);
      //  ChangeBGM(Resources.Load<AudioClip>("Sound/Music/DancingMidgets"));
    }

    public void PlayOneShot(SoundEffect sound, float volumeScale = 1)
    {
        SoundEffectSource.PlayOneShot(SoundEffects[sound], volumeScale * 1);

    }
    public void ChangeBGM(AudioClip clip)
    {
        BGMsource.clip = clip;
        BGMsource.Play();
    }


    }


   

