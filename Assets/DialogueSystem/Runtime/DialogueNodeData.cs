﻿using System;

namespace lastmilegames.DialogueSystem
{
    /// <summary>
    /// Represents the data a DialogueNode should track.
    /// </summary>
    [Serializable]
    public class DialogueNodeData : BaseNodeData
    {
        /// <summary>
        /// The spoken dialogue.
        /// </summary>
        public string dialogueText;
        
        /// <summary>
        /// The speaker.
        /// </summary>
        public string speakerName;
    }
}