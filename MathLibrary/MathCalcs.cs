using Accord.Statistics.Models.Regression.Linear;

namespace MathLibrary
{
    public class MathCalcs
    {
        public double GetResult(double value)
        {
            double[] inputs = { 80, 60, 10, 20, 30,36, 37 };
            double[] outputs = { 20, 40, 30, 50, 60,66, 67 };

            // Use Ordinary Least Squares to learn the regression
            OrdinaryLeastSquares ols = new OrdinaryLeastSquares();

            // Use OLS to learn the simple linear regression
            SimpleLinearRegression regression = ols.Learn(inputs, outputs);

            // Compute the output for a given input:
            return regression.Transform(value);
        }
    }
}
