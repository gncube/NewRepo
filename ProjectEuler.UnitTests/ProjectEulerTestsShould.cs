using ProjectEuler.Core;

namespace ProjectEuler.UnitTests;

public class ProjectEulerTestsShould
{
    [Theory]
    [InlineData(1, 233168)]
    [InlineData(2, 4613732)]
    [InlineData(3, 6857)]
    [InlineData(4, 906609)]
    [InlineData(5, 232792560)]
    public void ProblemTests(int problemNumber, int expectedResult)
    {
        IProblem problem = ProblemFactory.CreateProblem(problemNumber);

        Assert.Equal(expectedResult, problem.Solve());
    }
}