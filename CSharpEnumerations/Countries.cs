namespace CSharpEnumerations;

[Flags]
enum Country
{
    MW = 0,
    ET = 1,
    ZA = 2,
    TA = 4,
    META = MW | TA
}