using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UIElements;

namespace UITTimeline
{
    /// <summary>
    /// The behaviour / data of the visibility enable / disable.
    /// 
    /// <see cref="UITVisibilityClip"/>
    /// </summary>
    [Serializable]
    public class UITVisibilityBehaviour : UITBehaviour
    {
        public bool VisibleOnStart;
        public bool VisibleOnEnd;

        [HideInInspector] public List<VisualElement> Elements;

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
            if (Elements == null) return;
            foreach (var e in Elements)
            {
                e.visible = VisibleOnStart;
            }
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
            if (Elements == null) return;
            foreach (var e in Elements)
            {
                e.visible = VisibleOnEnd;
            }
        }
    }
}