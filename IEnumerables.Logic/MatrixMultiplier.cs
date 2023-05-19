namespace IEnumerables.Logic
{
    public class MatrixMultiplier
    {
        private int[,] _matrixA;
        private int[,] _matrixB;
        private int[,] _matrixC;
        private int _m; // rows
        private int _n; // rows ó columns
        private int _p; // columns

        public MatrixMultiplier(int m, int n, int p)
        {
            _n = n;
            _m = m;
            _p = p;
            _matrixA = new int[_m, _n];
            _matrixB = new int[_n, _p];
            _matrixC = new int[_m, _p];
        }

        public int M => _m;

        public int N => _n;

        public int P => _p;

        public override string ToString()
        {
            var output = string.Empty;
            var output2 = string.Empty;
            var output3 = string.Empty;

            for (int i = 0; i < _m; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    output += $"{_matrixA[i, j]}\t";
                }
                output += "\n";
            }

            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _p; j++)
                {
                    output2 += $"{_matrixB[i, j]}\t";
                }
                output2 += "\n";
            }

            for (int i = 0; i < _m; i++)
            {
                for (int j = 0; j < _p; j++)
                {
                    output3 += $"{_matrixC[i, j]}\t";
                }
                output3 += "\n";
            }

            return $"******* Matrix A *******\n{output}\n" +
                   $"******* Matrix B *******\n{output2}\n" + 
                   $"******* Matrix C *******\n{output3}";
        }

        public void FillMatrix()
        {
            for (int i = 0; i < _m; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    _matrixA[i, j] = (i+1)*j;
                }
            }

            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _p; j++)
                {
                    _matrixB[i, j] = (j + 1) * i;
                }
            }
        }

        public void MultiplierAB()
        {
            for (int i = 0; i < _m; i++)
            {
                for (int j = 0; j < _p; j++)
                {
                    for (int k = 0; k < _n; k++)
                    {
                        _matrixC[i, j] += _matrixA[i, k] * _matrixB[k, j];
                    }
                }
            }
        }
    }
}