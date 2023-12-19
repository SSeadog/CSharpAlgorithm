namespace AlgorithmStudy
{
    public class ThreeMatch
    {
        private int size = 5;
        private int[][] map;

        // 매칭하려는 패턴을 각 칸마다 쭉 검사? -> 패턴 검사는 어떻게 하지?
        // 가로 3개, 세로 3개


        /*
         * [99, 99, 99, 01, 02]
         * [01, 02, 03, 04, 05]
         * [02, 03, 04, 05, 06]
         * [03, 04, 05, 06, 07]
         * [04, 05, 06, 07, 08]
         */
        public void Run()
        {
            MakeMap();

            ShowMap();
        }

        private void MakeMap()
        {
            map = new int[size][];
            for (int i = 0; i < size; i++)
            {
                map[i] = new int[] { i, i+1, i+2, i+3, i+4 };
            }

            map[0][0] = 99;
            map[0][1] = 99;
            map[0][2] = 99;
        }

        private void ShowMap()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    System.Console.Write(map[i][j].ToString("00") + " ");
                }
                System.Console.WriteLine();
            }
        }

        private void Check()
        {

        }
    }
}
