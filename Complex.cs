using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_calc
{
    class Complex
    {
        public double RE, IM, add_1, add_2, sub_1, sub2;
        //default Konstruktor
        public Complex()
        {
            //setzen von Member-VAR // Return Member-Meth
        }
        //überladener Konstruktor
        public Complex(double re, double im)
        {     
            //if member not null...
            RE= re;
            IM= im;
        }

        public void Add(Complex rhs)
        {
            RE+= rhs.RE;
            IM += rhs.IM;
        }

        public void Sub(Complex rhs)
        {
            RE -= rhs.RE;
            IM -= rhs.IM;
        }

        public void Multi(Complex rhs, Complex lhs)
        {
            IM = (lhs.IM * rhs.RE) + (lhs.RE * rhs.IM);
            RE= (lhs.RE * rhs.RE) + (-1 * (lhs.IM * rhs.IM));
        }

        public void Div(Complex lhs, Complex rhs)
        {
            Complex step1 = new();
            Complex step2 = new();
            Complex conj = new()
            {
                RE = rhs.RE,
                IM = rhs.IM * -1
            };

            step1.IM = (lhs.IM * conj.RE) + (lhs.RE * conj.IM);
            step1.RE = (lhs.RE * conj.RE) + (-1 * (lhs.IM * conj.IM));
            step2.RE = (rhs.RE * conj.RE) + (-1 * rhs.IM * conj.IM);
            RE = Math.Round(step1.RE / step2.RE,2);
            IM = Math.Round(step1.IM / step2.RE,2);
        }
        
    }
    

}
