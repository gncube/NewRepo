

namespace ProjectEuler.Core;

public abstract class ProblemFactory
{
    public static IProblem CreateProblem(int problemNumber)
    {
        return problemNumber switch
        {
            1 => new Problem001(),
            2 => new Problem002(),
            _ => throw new ArgumentException("Invalid number."),
        };
    }
}