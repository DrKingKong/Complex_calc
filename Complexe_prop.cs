using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_calc
{
    internal class Complexe_prop
    {
        private double mRe, mIm;
        private double mB, mW;
        
        public Complexe_prop() { }

        public double Re
        {
            get { return mRe; } 
            
            set
            {
                if (value!=mRe)
                {
                    mRe = value;
                    KarthToPolar(mRe, mIm);
                }
                    
            }
        }

        public double B
        {
            get
            {
                return mB;
            }
            set
            {
                if (value!=mB)
                {
                    mB= value;
                    PolarToKarth(mB, mIm);
                }
            }
        }
        public double W
        {
            get { return mW * 180.0 / Math.PI; }
            set { mW = value + Math.PI / 180.0; }
        }
        //public static Complexe_prop operator +
        

        private void KarthToPolar(double mRe, double mIm)
        {
            mB=Math.Sqrt(mRe * mRe + mIm * mIm);
            mW = Math.Atan2(mIm, mRe);
        }

        private void PolarToKarth(double mRe, double mIm)
        {
            mRe = mB * Math.Cos(mW);
            mIm=mB*Math.Sin(mW);
        }
    }
}
