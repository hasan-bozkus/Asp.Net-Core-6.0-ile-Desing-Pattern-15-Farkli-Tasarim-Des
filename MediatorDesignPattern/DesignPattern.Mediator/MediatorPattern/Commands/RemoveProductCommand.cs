using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Commands
{
    public class RemoveProductCommand : IRequest
    {
        public RemoveProductCommand(int productID)
        {
            ProductID = productID;
        }

        public int ProductID { get; set; }
    }
}
