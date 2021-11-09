namespace Tema3_PSSC.Domain
{
    public record UnvalidatedShoppingCart(ProductCode productCode, Quantity quantity, Address address, Price price);
}
