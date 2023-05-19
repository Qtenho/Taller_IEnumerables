using System.Runtime.Intrinsics.X86;
using System;
using System.Globalization;

namespace IEnumerables.Logic
{
    public class FactorDecomposition
    {
        private int _n;
        private int[,] _matrix;
        private string _factors;
        private int top;

        public FactorDecomposition(int n)
        {
            _n = n;    
            _matrix = new int [20,2];
        }

        public int N => _n;

        public override string ToString()
        {
            _factors = N + " = ";
            for (int i = 0; i <= top; i++)
            {
                _factors += _matrix[i, 1] + " x ";
            }

            _factors = _factors.Substring(0, _factors.Length - 3);
            return $"******* Descomposición en Factores *******\n{_factors}";
        }

        public void GetFactors()
        {
            int i;
            int j = 0;
            _matrix[j, 0] = N;

            while (!Primes(_matrix[j,0]))
            {
                for (i = 2; i < _matrix[j,0]; i++)
                {
                    if (_matrix[j, 0] % i == 0)
                    {
                        break;
                    }
                }
                _matrix[j, 1] = i;
                _matrix[j + 1, 0] = _matrix[j, 0] / i;
                j++;
                top = j;
            }
            _matrix[j, 1] = _matrix[j, 0];
            

            //Llenamos un string con los factores hallados
            for ( i = 0; i <= j; i++)
            {
                _factors = _factors + _matrix[i, 1] + " x ";
            }
        }

        public bool Primes(int n)
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
