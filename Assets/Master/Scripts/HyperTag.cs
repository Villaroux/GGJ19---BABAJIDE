﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyperTag : MonoBehaviour {

    public enum Tag { Player, Hazzards, TP };

    public Tag[] tags;

    public bool IsTag(Tag tag)
    {
        bool found = false;

        for (int i = 0; i < tags.Length; i++)
        {
            if (tag == tags[i])
            {
                found = true;
                break;
            }
        }

        return found;
    }

    public Tag GetTag()
    {
        return tags[0];
    }
}
