using Test_Demo1.Models;

namespace Test_Demo1.Mappers
{
    public interface IMapper<TA, TB> where TA : IEntity where TB : IEntity
    {
        TB FromAToB(TA a);
        TA FromBToA(TB b);
    }
}