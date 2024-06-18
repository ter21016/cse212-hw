public static class Sorting {
    public static void Run() {
        var numbers = new[] { 3, 2, 1, 6, 4, 9, 8 };
        SortArray(numbers);
        Console.Out.WriteLine("int[]{{{0}}}", string.Join(", ", numbers)); //int[]{1, 2, 3, 4, 6, 8, 9}
    }

    private static void SortArray(int[] data) {
        for (var sortPos = data.Length - 1; sortPos >= 0; sortPos--) {
            for (var swapPos = 0; swapPos < sortPos; ++swapPos) {
                if (data[swapPos] > data[swapPos + 1]) {
                    (data[swapPos + 1], data[swapPos]) = (data[swapPos], data[swapPos + 1]);
                }
            }
        }
    }

    public static double StandardDeviation1(List<int> data) {
    double mean = data.Average();
    double sumOfSquares = data.Sum(x => Math.Pow(x - mean, 2));
    return Math.Sqrt(sumOfSquares / data.Count);
    }

    public static double StandardDeviation2(List<int> data) {
    double sum = 0;
    double squareSum = 0;
    foreach (var num in data) {
        sum += num;
        squareSum += num * num;
    }
    double mean = sum / data.Count;
    double variance = squareSum / data.Count - (mean * mean);
    return Math.Sqrt(variance);
    }

    public static double StandardDeviation3(List<int> data) {
    double mean = data.Average();
    double variance = data.Select(val => (val - mean) * (val - mean)).Sum() / data.Count;
    return Math.Sqrt(variance);
    }



}
