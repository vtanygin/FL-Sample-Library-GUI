using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SoundTouch;

namespace FL_Sample_Library_GUI
{
    class PitchFFT
    {
        public SoundTouchProcessor processor;
        //public Collection<float> samples;
        private void FFT()
        {
            BpmDetect detect = new BpmDetect(3, 44000);
            //detect.InputSamples(samples, 3);
        }
    }
}
