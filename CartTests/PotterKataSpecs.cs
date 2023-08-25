using Cart;

namespace CartTests;

public class When_Buying_No_Books
{
    static ShoppingCart ClassUnderTest;
    static decimal result;

    Establish context = () =>
    {
        ClassUnderTest = new ShoppingCart();
    };

    Because of = () =>
    {
        result = ClassUnderTest.GetCost(new[] { 1 });
    };

    It Should_calculate_cost = () => result.ShouldEqual(0m);
}

