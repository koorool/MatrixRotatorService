namespace MatrixRotatorService
{
    public static class MatrixEx
    {
        public static int[][] RotateRight(this int[][] arr)
        {
            var n = arr.Length - 1;
            //Shrink perimeter (could be done with recursion)
            for (var ic = 0; n - ic > 0; ic += 1)
            {
                for (var i = ic; i < n - ic; i++)
                {
                    var j = ic;

                    var prevValue = arr[i][j];
                    for (var k = 0; k < 4; k++)
                    {
                        var iTemp = i;
                        i = j;
                        j = n - iTemp;

                        var swapTmp = prevValue;
                        prevValue = arr[i][j];
                        arr[i][j] = swapTmp;
                    }
                }
            }
            return arr;
        }
    }
}