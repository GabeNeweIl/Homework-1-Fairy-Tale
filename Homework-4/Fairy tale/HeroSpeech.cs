﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fairy_tale
{
    interface HeroSpeech
    {
        public int Speak { get; set; }
        public  void Speech() { }
        public void WinningSpeech() { }
        public  void LosingSpeech() { }
    }
}
