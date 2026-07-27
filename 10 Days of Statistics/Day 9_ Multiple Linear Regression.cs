using System;
using System.Collections.Generic;
using System.Linq;

public class LinearRegression
{
    public static void Main(string[] args)
    {
        string[] datas = Console.ReadLine().Split(' ');
        int m = int.Parse(datas[0]);
        int n = int.Parse(datas[1]);

        List<double[]> X = new List<double[]>();
        List<double> y = new List<double>();

        for (int i = 0; i < n; i++)
        {
            double[] parts = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            X.Add(parts.Take(m).ToArray());
            y.Add(parts.Last());
        }

        int q = int.Parse(Console.ReadLine());
        List<double[]> new_X = new List<double[]>();

        for (int i = 0; i < q; i++)
        {
            double[] parts = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            new_X.Add(parts);
        }

        double[] coefficients = Fit(X, y);
        double[] predicted = Predict(new_X, coefficients);

        foreach (double value in predicted)
        {
            Console.WriteLine($"{value:F2}");
        }
    }

    public static double[] Fit(List<double[]> X, List<double> y)
    {
        int n = X.Count;
        int m = X[0].Length + 1; // +1 for the intercept

        double[,] XMatrix = new double[n, m];
        double[,] yMatrix = new double[n, 1];

        for (int i = 0; i < n; i++)
        {
            XMatrix[i, 0] = 1; // Intercept
            for (int j = 0; j < X[i].Length; j++)
            {
                XMatrix[i, j + 1] = X[i][j];
            }
            yMatrix[i, 0] = y[i];
        }

        double[,] XTranspose = Transpose(XMatrix);
        double[,] XTransposeX = Multiply(XTranspose, XMatrix);
        double[,] XTransposeXInverse = MatrixInverse(XTransposeX);
        double[,] XTransposeY = Multiply(XTranspose, yMatrix);
        double[,] coefficientsMatrix = Multiply(XTransposeXInverse, XTransposeY);

        double[] coefficients = new double[m];
        for (int i = 0; i < m; i++)
        {
            coefficients[i] = coefficientsMatrix[i, 0];
        }

        return coefficients;
    }

    public static double[] Predict(List<double[]> new_X, double[] coefficients)
    {
        int n = new_X.Count;
        int m = coefficients.Length;
        double[] predicted = new double[n];

        for (int i = 0; i < n; i++)
        {
            double prediction = coefficients[0]; // Intercept
            for (int j = 1; j < m; j++)
            {
                prediction += coefficients[j] * new_X[i][j - 1];
            }
            predicted[i] = prediction;
        }

        return predicted;
    }

    public static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] transposed = new double[cols, rows];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposed[j, i] = matrix[i, j];
            }
        }
        return transposed;
    }

    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int cols2 = matrix2.GetLength(1);
        double[,] result = new double[rows1, cols2];
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                for (int k = 0; k < cols1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }

    public static double[,] MatrixInverse(double[,] matrix)
    {
        int n = matrix.GetLength(0);
        double[,] augmented = new double[n, 2 * n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                augmented[i, j] = matrix[i, j];
                augmented[i, j + n] = (i == j) ? 1.0 : 0.0;
            }
        }
        for (int i = 0; i < n; i++)
        {
            double pivot = augmented[i, i];
            for (int j = 0; j < 2 * n; j++)
            {
                augmented[i, j] /= pivot;
            }
            for (int k = 0; k < n; k++)
            {
                if (k != i)
                {
                    double factor = augmented[k, i];
                    for (int j = 0; j < 2 * n; j++)
                    {
                        augmented[k, j] -= factor * augmented[i, j];
                    }
                }
            }
        }
        double[,] inverse = new double[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                inverse[i, j] = augmented[i, j + n];
            }
        }
        return inverse;
    }
}