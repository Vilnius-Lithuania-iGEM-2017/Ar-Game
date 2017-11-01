﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public interface ITrackableSourceHandler : IEventSystemHandler
{
    void OnTrackableSourceChange();
}