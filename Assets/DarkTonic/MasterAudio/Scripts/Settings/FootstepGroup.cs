﻿using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

[Serializable]
public class FootstepGroup {
	public bool isExpanded = true;

	// tag / layer filters
	public bool useLayerFilter = false;
	public bool useTagFilter = false;
	public List<int> matchingLayers = new List<int>() { 0 };
	public List<string> matchingTags = new List<string>() { "Default" };

	public string soundType = MasterAudio.NO_GROUP_NAME;
	public EventSounds.VariationType variationType = EventSounds.VariationType.PlayRandom;
	public string variationName = string.Empty;
	public float volume = 1.0f;
	public bool useFixedPitch = false;
	public float pitch = 1f;
	public float delaySound = 0f;
}