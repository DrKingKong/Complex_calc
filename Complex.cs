using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Complex_calc
{
    class Complex
    {
        // public double RE, IM, add_1, add_2, sub_1, sub2;
        ////default Konstruktor
        //public Complex()
        //{
        //    //setzen von Member-VAR // Return Member-Meth
        //}
        ////überladener Konstruktor
        //public Complex(double re, double im)
        //{     
        //    //if member not null...
        //    RE= re;
        //    IM= im;
        //}

        //public void Add(Complex rhs)
        //{
        //    RE += rhs.RE;
        //    IM += rhs.IM;
        //}

        //public void Sub(Complex rhs)
        //{
        //    RE -= rhs.RE;
        //    IM -= rhs.IM;
        //}

        //public void Multi(Complex rhs, Complex lhs)
        //{
        //    IM = (lhs.IM * rhs.RE) + (lhs.RE * rhs.IM);
        //    RE = (lhs.RE * rhs.RE) + (-1 * (lhs.IM * rhs.IM));
        //}

        //public void Div(Complex lhs, Complex rhs)
        //{
        //    Complex step1 = new();
        //    Complex step2 = new();
        //    Complex conj = new()
        //    {
        //        RE = rhs.RE,
        //        IM = rhs.IM * -1
        //    };

        //    step1.IM = (lhs.IM * conj.RE) + (lhs.RE * conj.IM);
        //    step1.RE = (lhs.RE * conj.RE) + (-1 * (lhs.IM * conj.IM));
        //    step2.RE = (rhs.RE * conj.RE) + (-1 * rhs.IM * conj.IM);
        //    RE = Math.Round(step1.RE / step2.RE, 2);
        //    IM = Math.Round(step1.IM / step2.RE, 2);
        //}
        
        private double mRe, mIm;
        private double mB, mW;
        public Complex() { }
        public Complex(double re, double im)
            {
                Re = re;
                Im = im;
            }
        public override string ToString()
        {
            if (mIm >= 0)
                return $"{mRe} + j{mIm}";
            else
                return $"{mRe} + j{mIm}";
        }

        public double Re
        {
            get
            {
                return mRe;
            }
            set
            {
                if (value != mRe)
                {
                    mRe = value;
                    KarthToPolar();
                }
            }
        }

        public double Im
        {
            get
            {
                return mIm;
            }
            set
            {
                if (value != mIm)
                {
                    mIm = value;
                    KarthToPolar();
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
                if(value!=mB)
                {
                    mB= value;
                }
                PolarToKarth();
            }
        }

        public double W
        {
            get
            {
                return mW;
            }
            set
            {
                if (value != mW)
                {
                    mW = value;
                }
                PolarToKarth();
            }
        }

        private void KarthToPolar()
        {
            mB=Math.Sqrt(mRe*mRe+mIm* mIm);
            mW=Math.Atan2(mIm,mRe);
        }
        private void PolarToKarth()
        {
            mRe=mB*Math.Cos(mW);
            mIm=mB+Math.Sin(mW);
        }
        public double Wdeg
        {
            get
            {
                return mW * 180.0 / Math.PI;
            }
            set
            {
                mW = value * Math.PI / 180.0;
            }
        }
        public static Complex operator + (Complex lhs, Complex rhs)
        {
            Complex tmp = new();
            tmp.Re = lhs.Re + rhs.Re;
            tmp.Im=lhs.Im + rhs.Im;
            return tmp;
        }
        public static Complex operator - (Complex lhs, Complex rhs)
        {
            Complex tmp = new();
            tmp.Re = lhs.Re - rhs.Re;
            tmp.Im = lhs.Im - rhs.Im;
            return tmp;
        }
        public static Complex operator *(Complex lhs, Complex rhs)
        {
            Complex tmp = new();
            tmp.Re = lhs.B * rhs.B;
            tmp.Im = lhs.W + rhs.W;
            return tmp;
        }
        public static Complex operator /(Complex lhs, Complex rhs)
        {
            Complex tmp = new();
            tmp.Re = lhs.B / rhs.B;
            tmp.Im = lhs.W - rhs.W;
            return tmp;
        }

        //public Complex  Add(Complex lhs, Complex rhs)
        //{
        //    Complex sum = new();
        //    sum= lhs + rhs;
        //    return sum;
       
        //}
        //public Complex  Sub(Complex lhs, Complex rhs)
        //{
        //    Complex diff = new();
        //    diff=lhs - rhs;
        //    return diff;
        //}

        //public Complex Multi(Complex lhs, Complex rhs)
        //{
        //    Complex mul = new();
        //    mul = lhs * rhs;
        //    return mul;
        //}
        //public Complex Div(Complex lhs, Complex rhs)
        //{
        //    Complex quot = new();
        //    quot = lhs / rhs;
        //    return quot;
        //}
    }


}
