namespace IEnumerables.Logic
{
    public class SandTimer
    {
        private string[,] _matrixTimer;
        private int[,] _completeMatrix;
        private int _n;

        public SandTimer(int n)
        {
            _n = n;
            _completeMatrix = new int[N, N];
            _matrixTimer = new string[N, N];
        }

        public int N => _n;

        public override string ToString()
        {
            var output = string.Empty;
            var output2 = string.Empty;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    output += $"{_completeMatrix[i, j]}\t";
                }
                output += "\n";
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    output2 += $"{_matrixTimer[i, j]}\t";
                }
                output2 += "\n";
            }

            return $"******* MATRIX COMPLETA *******\n{output}\n" +
                   $"******* MATRIX RELOJ DE ARENA *******\n{output2}";
        }


        public void FillCompleteMatrix()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    _completeMatrix[i, j] = (i * 2) + j;
                }
            }
        }

        public void FillSandTimerMatrix()
        {
            int k = (N / 2) + 1;
            for (int i = 0; i < k; i++)
            {
                for (int j = i; j < N - i; j++)
                {
                    _matrixTimer[i, j] = "" + _completeMatrix[i, j];
                    _matrixTimer[N - i -1, j] = "" + _completeMatrix[N - i - 1  , j];
                }
            }
        }

    }
}
