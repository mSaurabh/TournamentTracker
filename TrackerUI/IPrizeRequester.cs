using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerUI
{
    // Check Youtube Reference: https://youtu.be/rS734DJL6zM?t=529
    public interface IPrizeRequester
    {
        void PrizeComplete(PrizeModel model);
    }
}
