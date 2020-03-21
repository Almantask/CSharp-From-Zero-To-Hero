using System;
using System.Collections.Generic;
using System.Text;
// ReSharper disable All

namespace BootCamp.Chapter.Demos.Covariance
{
    interface ICovariance<out T> { }
    class Covariance<T> : ICovariance<T> { }

    interface IContravariance<in T> { }
    class Contravariance<T> : IContravariance<T> { }
    
    class CoContraSamples
    {
        public void Test()
        {
            // specific type
            ICovariance<string> covarianceSpecific = new Covariance<string>();
            ICovariance<object> covarianceGeneral = new Covariance<object>();

            // We can generalize
            ICovariance<object> covarianceGeneralized = covarianceSpecific;

            IContravariance<string> contravarianceSpecific = new Contravariance<string>();
            IContravariance<object> contravarianceGeneral = new Contravariance<object>();

            // We can assign generalized form to specific.
            contravarianceSpecific = contravarianceGeneral;

            string s = default;
            object o = default;

            // However for normal values we can assign specific to generalized.
            o = s;
            // But not the other way round.
            // Which makes sense, but why isn't the same for generics?
            //s = o;
            
        }
    }
}
