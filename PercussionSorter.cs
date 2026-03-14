using System;
using System.Collections.Generic;
using System.Text;

namespace FL_Sample_Library_GUI
{
    class PercussionSorter
    {
        //this will use the info from PitchFFT to ID percussion (i.e. white noise from hats should be obvious,
        //whereas snares will have a high pitch fundamental
        //and kicks will have a low pitch fundamental
        //ADSR envelope is useful too - use volume over time to get this
        //hey we could honestly pull out ADSR into metadata - i.e. time from zero to peak is A, peak to mid is D, mid to zero is R
    }
}
